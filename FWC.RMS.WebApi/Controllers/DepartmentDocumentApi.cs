/*
 * Revenue Management System
 *
 * Florida Fish and Wildlife Conservation Commision - Revenue Management System.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@fwc.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using FWC.RMS.Attributes;
using FWC.RMS.Security;
using Microsoft.AspNetCore.Authorization;
using FWC.RMS.ApplicationCore.DTOs;
using FWC.RMS.ApplicationCore.Interfaces;

namespace FWC.RMS.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DepartmentDocumentApiController : ControllerBase
    {

        private readonly IDepartmentDocumentService _departmentDocumentService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="departmentDocumentService"></param>
        public DepartmentDocumentApiController(IDepartmentDocumentService departmentDocumentService)
        {
            _departmentDocumentService = departmentDocumentService;
        }


        /// <summary>
        /// Create a Department Document record
        /// </summary>
        /// <param name="body">Department Document request payload</param>
        /// <param name="transmittalNumber">Transmittal Number</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal server error</response>
        [HttpPost]
        [Route("/v1/transmittals/{transmittalNumber}/departmentDocuments")]
        [ValidateModelState]
        [SwaggerOperation("CreateDepartmentDocument")]
        [SwaggerResponse(statusCode: 200, type: typeof(DepartmentDocumentDto), description: "successful operation")]
        public virtual IActionResult CreateDepartmentDocument([FromBody]DepartmentDocumentRequest body, [FromRoute][Required]long? transmittalNumber)
        {
            try 
            { 
                return new ObjectResult(_departmentDocumentService.CreateDepartmentDocument(transmittalNumber.GetValueOrDefault(), body)); 
            }
            catch(Exception) 
            { 
                return StatusCode(500); 
            }
        }

        /// <summary>
        /// get Department Document records
        /// </summary>
        /// <param name="transmittalNumber">Transmittal Number</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal server error</response>
        [HttpGet]
        [Route("/v1/transmittals/{transmittalNumber}/departmentDocuments")]
        [ValidateModelState]
        [SwaggerOperation("GetDepartmentDocuments")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<DepartmentDocumentDto>), description: "successful operation")]
        public virtual IActionResult GetDepartmentDocuments([FromRoute][Required]long? transmittalNumber)
        {
            try
            {
                return new ObjectResult(_departmentDocumentService.GetDepartmentDocumentsByTransmittalNumber(transmittalNumber.GetValueOrDefault()));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Update a Department Document record
        /// </summary>
        /// <param name="body">DepartmentDocument request payload</param>
        /// <param name="transmittalNumber">Transmittal Number</param>
        /// <param name="departmentDocumentsNumber">Department Document Number</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal server error</response>
        [HttpPatch]
        [Route("/v1/transmittals/{transmittalNumber}/departmentDocuments/{departmentDocumentsNumber}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateDepartmentDocument")]
        [SwaggerResponse(statusCode: 200, type: typeof(DepartmentDocumentDto), description: "successful operation")]
        public virtual IActionResult UpdateDepartmentDocument([FromBody]DepartmentDocumentRequest body, [FromRoute][Required]long? transmittalNumber, [FromRoute][Required]long? departmentDocumentsNumber)
        {
            try
            {
                return new ObjectResult(_departmentDocumentService.UpdateDepartmentDocument(departmentDocumentsNumber.GetValueOrDefault(), body));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
