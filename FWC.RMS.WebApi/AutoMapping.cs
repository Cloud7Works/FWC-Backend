﻿using AutoMapper;
using FWC.RMS.ApplicationCore.DTOs;
using FWC.RMS.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FWC.RMS.WebApi
{
    /// <summary>
    /// 
    /// </summary>
    public class AutoMapping : Profile
    {
        /// <summary>
        /// 
        /// </summary>
        public AutoMapping()
        {
            CreateMap<Transmittal, TransmittalDto>() // map from Transmittal to TransmittalDto
            .ForMember(dto => dto.TransmittalNumber, m => m.MapFrom(u => u.Id));
            CreateMap<CreateTransmittalRequest, Transmittal>(); // map from CreateTransmittalRequest to Transmittal
            CreateMap<UpdateTransmittalRequest, Transmittal>(); // map from UpdateTransmittalRequest to Transmittal

            CreateMap<DepartmentDocument, DepartmentDocumentDto>() // map from DepartmentDocument to DepartmentDocumentDto
            .ForMember(dto => dto.DepartmentDocumentNumber, m => m.MapFrom(u => u.Id))
            .ForMember(dto => dto.DateTimeStamp, m => m.MapFrom(u => u.ModifiedOn ?? u.CreatedOn));
            CreateMap<DepartmentDocumentRequest, DepartmentDocument>(); // map from DepartmentDocumentRequest to DepartmentDocument
        }
    }
}
