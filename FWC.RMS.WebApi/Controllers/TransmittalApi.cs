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
    public class TransmittalApiController : ControllerBase
    {

        private readonly ITransmittalService _transmittalService;
      
        /// <summary>
       /// 
       /// </summary>
       /// <param name="transmittalService"></param>
        public TransmittalApiController(ITransmittalService transmittalService)
        {
            _transmittalService = transmittalService;
        }

        /// <summary>
        /// Create a Transmittal record
        /// </summary>
        /// <param name="body">Transmittal request object</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal server error</response>
        [HttpPost]
        [Route("/v1/transmittals")]
        [ValidateModelState]
        [SwaggerOperation("CreateTransmittals")]
        [SwaggerResponse(statusCode: 200, type: typeof(TransmittalDto), description: "successful operation")]
        public virtual IActionResult CreateTransmittals([FromBody]CreateTransmittalRequest body)
        {
                try
                {
                    return new ObjectResult(_transmittalService.CreateTransmittal(body));
                }
                catch (Exception) 
                { 
                    return StatusCode(500); 
                }
        }

        /// <summary>
        /// get transmittal records
        /// </summary>
        /// <param name="transmittalStatus">Transmittal Status</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal server error</response>
        [HttpGet]
        [Route("/v1/transmittals")]
        [ValidateModelState]
        [SwaggerOperation("GetTransmittals")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<TransmittalDto>), description: "successful operation")]
        public virtual IActionResult GetTransmittals([FromQuery][Required()]string transmittalStatus)
        {
            try 
            { 
                return new ObjectResult(_transmittalService.GetTransmittalsByStatus(transmittalStatus));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Update a Transmittal record
        /// </summary>
        /// <param name="body">Transmittal request object</param>
        /// <param name="transmittalNumber">Transmittal Number</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal server error</response>
        [HttpPatch]
        [Route("/v1/transmittals/{transmittalNumber}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateTransmittals")]
        [SwaggerResponse(statusCode: 200, type: typeof(TransmittalDto), description: "successful operation")]
        public virtual IActionResult UpdateTransmittals([FromBody]UpdateTransmittalRequest body, [FromRoute][Required]long? transmittalNumber)
        {
            try
            {
                return new ObjectResult(_transmittalService.UpdateTransmittal(transmittalNumber.GetValueOrDefault(), body));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
