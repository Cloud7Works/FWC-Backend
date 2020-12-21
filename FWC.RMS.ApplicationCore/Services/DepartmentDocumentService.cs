using AutoMapper;
using FWC.RMS.ApplicationCore.Data;
using FWC.RMS.ApplicationCore.DTOs;
using FWC.RMS.ApplicationCore.Entities;
using FWC.RMS.ApplicationCore.Interfaces;
using FWC.RMS.ApplicationCore.Specifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace FWC.RMS.ApplicationCore.Services
{
    public class DepartmentDocumentService : IDepartmentDocumentService
    {

       private readonly IAsyncRepository<DepartmentDocument, long> _departmentDocumentRepository;

        private readonly IMapper _mapper;

  
        public DepartmentDocumentService(IAsyncRepository<DepartmentDocument, long> departmentDocumentRepository, IMapper mapper)
        {
            _departmentDocumentRepository = departmentDocumentRepository;
            _mapper = mapper;
        }

        public DepartmentDocumentDto CreateDepartmentDocument(long transmittalNumber, DepartmentDocumentRequest departmentDocumentRequest)
        {
            
            var departmentDocumentEntity = _mapper.Map<DepartmentDocument>(departmentDocumentRequest);
            departmentDocumentEntity.TransmittalNumber = transmittalNumber;
            departmentDocumentEntity = _departmentDocumentRepository.AddAsync(departmentDocumentEntity).Result;

            return _mapper.Map<DepartmentDocumentDto>(departmentDocumentEntity);
        }

        public DepartmentDocumentDto UpdateDepartmentDocument(long departmentDocumentNumber, DepartmentDocumentRequest departmentDocumentRequest)
        {

            DepartmentDocument departmentDocumentEntity = _departmentDocumentRepository.GetByIdAsync(departmentDocumentNumber).Result;
           
            _mapper.Map(departmentDocumentRequest, departmentDocumentEntity);

            _departmentDocumentRepository.UpdateAsync(departmentDocumentEntity).Wait();

            return _mapper.Map<DepartmentDocumentDto>(departmentDocumentEntity);
        }

        public List<DepartmentDocumentDto> GetDepartmentDocumentsByTransmittalNumber(long transmittalNumber)
        {

           var departmentDocs = _departmentDocumentRepository.ListAsync(new DepartmentDocumentsByTransmittalNumberSpecification(transmittalNumber)).Result;

           return _mapper.Map<List<DepartmentDocumentDto>>(departmentDocs); ;

        }


        public bool DeleteDepartmentDocument(long departmentDocumentNumber)
        {
            DepartmentDocument departmentDocumentEntity = _departmentDocumentRepository.GetByIdAsync(departmentDocumentNumber).Result;

            if (departmentDocumentEntity != null)
            {
                _departmentDocumentRepository.DeleteAsync(departmentDocumentEntity).Wait();
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
