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
    public class FXTransactionExtsController : ControllerBase
    {
        private readonly IFXTransactionExt _repository;
        private readonly ILogger<FXTransactionExtsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FXTransactionExtsController(IFXTransactionExt repository,
                                  ILogger<FXTransactionExtsController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }

        //[BasicAuthentication]
        [Authorize]
        [Route("GetFXGID")]
        [HttpGet]
        public ActionResult<FXTransactionExtView> GetPendingTrans()
        {
            try
            {
                var entry = _repository.GetPendingTrans();

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Pending FX Transactions not found");
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
        [Authorize(Roles = "FX-Trans - Authorise,Administrator")]
        [Route("")]
        [HttpPut]
        public ActionResult<int> Put([FromBody] InputFXGID status)
        {
            try
            {
                var entry = _repository.UpdateStatus(status);
                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                       "GID of FX Transaction with Ref No " + status.RefNo.ToString() + " not found");
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
                                   "GID of FX Transaction with Ref No " + status.RefNo.ToString() + " not found");
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
