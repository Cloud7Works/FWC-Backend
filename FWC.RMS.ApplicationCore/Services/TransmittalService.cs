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
    public class TransmittalService : ITransmittalService
    {

       private readonly IAsyncRepository<Transmittal,long> _transmittalRepository;

        private readonly IMapper _mapper;

        public TransmittalService(IAsyncRepository<Transmittal, long> transmittalRepository, IMapper mapper)
        {
         _transmittalRepository = transmittalRepository;
            _mapper = mapper;
        }

        public TransmittalDto CreateTransmittal(CreateTransmittalRequest transmittalRequest)
        {
            
            var transmittalEntity = _mapper.Map<Transmittal>(transmittalRequest);

            transmittalEntity =  _transmittalRepository.AddAsync(transmittalEntity).Result;

            return _mapper.Map<TransmittalDto>(transmittalEntity);
        }

        public TransmittalDto UpdateTransmittal(long transmittalNumber, UpdateTransmittalRequest transmittalRequest)
        {

           Transmittal transmittalEntity =  _transmittalRepository.GetByIdAsync(transmittalNumber).Result;
            transmittalEntity.TransmittalStatus = transmittalRequest.TransmittalStatus;
            transmittalEntity.TransmittalTotal = transmittalRequest.TransmittalTotal.Value;
            transmittalEntity.TransmittalTotalCount = transmittalRequest.TransmittalTotalCount.Value;

            _transmittalRepository.UpdateAsync(transmittalEntity).Wait();

            return _mapper.Map<TransmittalDto>(transmittalEntity);
        }

        public List<TransmittalDto> GetTransmittalsByStatus(string transmittalStatus)
        {

           var transmitals = _transmittalRepository.ListAsync(new TransmittalsByStatusSpecification(transmittalStatus)).Result;

           return _mapper.Map<List<TransmittalDto>>(transmitals); ;

        }
}
}
