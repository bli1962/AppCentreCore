using System;
using System.Threading.Tasks;
using System.Net;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mhcb.Syd.Business.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Authorization;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FXTransactionsController : ControllerBase
    {
        private readonly IFXTransaction _repository;
        private readonly ILogger<FXTransactionsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FXTransactionsController(IFXTransaction repository,
                                  ILogger<FXTransactionsController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }

        //[BasicAuthentication]
        //[Authorize]
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
        //[Authorize]
        [Route("GetFullFXTransactionByDates/{dateFrom}/{dateTo}/{dateType}")]
        [HttpGet]
        public ActionResult<FxTransaction> GetFullFXTransactionByDates(string dateFrom, string dateTo, string dateType)
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
        //[Authorize]
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
        //[Authorize]
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
        //[Authorize]
        [Route("")]
        [HttpPut]
        public ActionResult<int> Put([FromBody] FXTranStatus status)
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

    }
}
