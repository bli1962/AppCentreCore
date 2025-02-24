using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FXTransactionsController : ControllerBase
    {
        private readonly IFXTransaction _repository;
        private readonly ILogger<FXTransactionsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;

        public FXTransactionsController(IFXTransaction repository,
                                  ILogger<FXTransactionsController> logger,
                                  IWebHostEnvironment environment,
                                  IConfiguration configuration)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
            this._configuration = configuration;
        }

        //[BasicAuthentication]
        [Authorize]
        [Route("GetPendingFxTrans")]
        [HttpGet]
        public ActionResult<FXTransactionView> GetPendingTrans()
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
        [Route("GetFullFXTransactionByDates/{dateFrom}/{dateTo}/{dateType}")]
        [HttpGet]
        public ActionResult<FxTransactionCompleteView> GetFullFXTransactionByDates(string dateFrom, string dateTo, string dateType)
        {
            try
            {
                if (dateFrom == null || dateTo == null )
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Start Date or End Date or Customer Abbreviation.");
                }

                var entry = _repository.GetFullFXTransactionByDates(dateFrom, dateTo, dateType);

                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    if (dateFrom != null && dateTo != null)
                    {
                        return StatusCode(StatusCodes.Status404NotFound, "FX Transactions between start dates : " + dateFrom.ToString() + " and " + dateTo.ToString() + " not found");

                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status404NotFound, "FX Transactions not found");
                    }
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
        [Route("GetFxTransByDatesCustAbbr/{dateFrom}/{dateTo}/{dateType}/{custName}")]
        [HttpGet]
        public ActionResult<FXTransactionView> GetFXTransactionByDatesCustAbbr(string dateFrom, string dateTo, string dateType, string custName)
        {
            try
            {
                if (dateFrom == null || dateTo == null || custName == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Start Date or End Date or Customer Abbreviation.");
                }

                var entry = _repository.GetFXTransactionByDatesCustAbbr(dateFrom, dateTo, dateType, custName);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    if (dateFrom != null && dateTo != null)
                    {
                        return StatusCode(StatusCodes.Status404NotFound, "FX Transactions between start dates : " + dateFrom.ToString() + " and " + dateTo.ToString() + " not found");

                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status404NotFound, "FX Transactions not found");
                    }
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
        [Route("GetFxTransByRefNo/{refNo}")]
        [HttpGet]
        public ActionResult GetFxTransByRefNo(string refNo)
        {
            try
            {
                if (refNo == null )
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Reference No.");
                }

                var entry = _repository.GetFxTransByRefNo(refNo);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "FX Transaction of Ref No :" + refNo.ToString() + " not found");
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
        public ActionResult<int> Put([FromBody] InputFXTrans status)
        {
            try
            {
                var entry = _repository.UpdateStatus(status);

                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                        "FX Transaction with Ref Noe " + status.RefNo.ToString() + " not found");
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
                                    "FX Transaction with Ref Noe " + status.RefNo.ToString() + " not found");
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


        //[BasicAuthentication]
        [Authorize]
        [Route("CheckFxTransactionQueues/{rundate}")]
        [HttpGet]
        public ActionResult<int> CheckFxTransactionQueues(DateTime rundate)
        {
            //if return 1, there is a pending transactions
            //if return 2, there is a pending delivery
            //if return 0, no pending trans/delivery
            try
            {
                //if (rundate == null)
                //{
                //    // HTTP/1.1 400 Bad Request 
                //    return StatusCode(StatusCodes.Status400BadRequest, "Missing Run Date.");
                //}

                string SPConnection = _configuration.GetConnectionString("GUIDESP");
                var entry = _repository.CheckFxTransactionQueues(SPConnection, rundate);

                if (entry == -1) // from error catch
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "FX Transaction on date :" + rundate.ToString() + " not found");
                }
                else
                {
                    return Ok(entry);
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
