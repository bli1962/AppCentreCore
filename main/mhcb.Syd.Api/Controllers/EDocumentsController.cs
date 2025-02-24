﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EDocumentsController : ControllerBase
    {
        private readonly IEDocument _repository;
        private readonly ILogger<EDocumentsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EDocumentsController(IEDocument repository,
                                  ILogger<EDocumentsController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }

        //[BasicAuthentication]
        [Authorize]
        [Route("GetMMStatement/{eDocType}/{optDate}")]
        [HttpGet]
        public ActionResult<MMStatementView> GetMMStatement(string eDocType, string optDate)
        {
            try
            {
                if (eDocType == null || optDate == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Document Type or Dates.");
                }

                var entry = _repository.GetMMStatement(eDocType, optDate);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                    "eDocuments of : " + eDocType.ToString() + " on date of " + optDate + " not found");
                }
            }
            catch (Exception)
            {
                // HTTP/1.1 500 server error  
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from the database");
            }
        }

        [Authorize]
        [Route("GetMMConfirmation/{eDocType}/{optDate}")]
        [HttpGet]
        public ActionResult<MMConfirmationView> GetMMConfirmation(string eDocType, string optDate)
        {
            try
            {
                if (eDocType == null || optDate == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Document Type or Dates.");
                }

                var entry = _repository.GetMMConfirmation(eDocType, optDate);

                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                    "eDocuments of : " + eDocType.ToString() + " on date of " + optDate + " not found");
                }
            }
            catch (Exception)
            {
                // HTTP/1.1 500 server error  
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from the database");
            }
        }

        [Authorize]
        [Route("GetFXConfirmation/{eDocType}/{optDate}")]
        [HttpGet]
        public ActionResult<MMConfirmationView> GetFXConfirmation(string eDocType, string optDate)
        {
            try
            {
                if (eDocType == null || optDate == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Document Type or Dates.");
                }

                var entry = _repository.GetFXConfirmation(eDocType, optDate);

                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                    "eDocuments of : " + eDocType.ToString() + " on date of " + optDate + " not found");
                }
            }
            catch (Exception)
            {
                // HTTP/1.1 500 server error  
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from the database");
            }
        }

        //[BasicAuthentication]
        [Authorize]
        [Route("")]
        [HttpPut]
        public ActionResult<int> Put([FromBody] InputEDocument eDocAttribute)
        {
            try
            {
                var entry = _repository.UpdateStatus(eDocAttribute);
                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                       "eDocument of : " + eDocAttribute.ReportType.ToString() + " ID: " + eDocAttribute.Id + " not found ");
                // HTTP/1.1 200 OK                 
                if (entry == "OK")
                {
                    var result = StatusCode(StatusCodes.Status200OK, "Save successfully.");
                    return result.StatusCode;
                }
                else if (entry == "NotFound")
                {
                    // HTTP/1.1 404 Not found  
                    var result = StatusCode(StatusCodes.Status404NotFound,
                                 "eDocument of : " + eDocAttribute.ReportType.ToString() + " ID: " + eDocAttribute.Id + " not found ");
                    return result.StatusCode;
                }
                else
                {
                    var result = StatusCode(StatusCodes.Status400BadRequest, "Bad request.");
                    return result.StatusCode;
                }

            }
            catch (Exception)
            {
                // HTTP/1.1 500 server error  
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from the database");
            }
        }
    }
}
