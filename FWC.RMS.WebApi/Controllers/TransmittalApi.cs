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
using FWC.RMS.WebApi.Attributes;
using FWC.RMS.WebApi.Security;
using Microsoft.AspNetCore.Authorization;
using FWC.RMS.ApplicationCore.Dto;

namespace FWC.RMS.WebApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class TransmittalApiController : ControllerBase
    {
        /// <summary>
        /// Create a Transmittal record
        /// </summary>
        /// <param name="body">Transmittal request object</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal server error</response>
        [HttpPost]
        [Route("/v2/transmittals")]
        [ValidateModelState]
        [SwaggerOperation("CreateTransmittals")]
        [SwaggerResponse(statusCode: 200, type: typeof(Transmittal), description: "successful operation")]
        public virtual IActionResult CreateTransmittals([FromBody] CreateTransmittalRequest body)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Transmittal));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);
            string exampleJson = null;
            exampleJson = "{\n  \"transmittalTotalCount\" : 6,\n  \"transmittalTotal\" : 1.4658129805029452,\n  \"transmittalStatus\" : \"transmittalStatus\",\n  \"transmittalNumber\" : 0,\n  \"transmittalDate\" : \"2000-01-23\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Transmittal>(exampleJson)
            : default(Transmittal);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// get transmittal records
        /// </summary>
        /// <param name="transmittalStatus">Transmittal Status</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal server error</response>
        [HttpGet]
        [Route("/v2/transmittals")]
        [ValidateModelState]
        [SwaggerOperation("GetTransmittals")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Transmittal>), description: "successful operation")]
        public virtual IActionResult GetTransmittals([FromQuery][Required()] string transmittalStatus)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Transmittal>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);
            string exampleJson = null;
            exampleJson = "[ {\n  \"transmittalTotalCount\" : 6,\n  \"transmittalTotal\" : 1.4658129805029452,\n  \"transmittalStatus\" : \"transmittalStatus\",\n  \"transmittalNumber\" : 0,\n  \"transmittalDate\" : \"2000-01-23\"\n}, {\n  \"transmittalTotalCount\" : 6,\n  \"transmittalTotal\" : 1.4658129805029452,\n  \"transmittalStatus\" : \"transmittalStatus\",\n  \"transmittalNumber\" : 0,\n  \"transmittalDate\" : \"2000-01-23\"\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Transmittal>>(exampleJson)
            : default(List<Transmittal>);            //TODO: Change the data returned
            return new ObjectResult(example);
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
        [Route("/v2/transmittals/{transmittalNumber}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateTransmittals")]
        [SwaggerResponse(statusCode: 200, type: typeof(Transmittal), description: "successful operation")]
        public virtual IActionResult UpdateTransmittals([FromBody] UpdateTransmittalRequest body, [FromRoute][Required] long? transmittalNumber)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Transmittal));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);
            string exampleJson = null;
            exampleJson = "{\n  \"transmittalTotalCount\" : 6,\n  \"transmittalTotal\" : 1.4658129805029452,\n  \"transmittalStatus\" : \"transmittalStatus\",\n  \"transmittalNumber\" : 0,\n  \"transmittalDate\" : \"2000-01-23\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Transmittal>(exampleJson)
            : default(Transmittal);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
