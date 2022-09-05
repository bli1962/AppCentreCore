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
using mhcb.Syd.DataAccess.Models.GUIDE;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FXDeliverysController : ControllerBase
    {
        private readonly IFXDelivery _repository;
        private readonly ILogger<FXDeliverysController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;

        public FXDeliverysController(IFXDelivery repository,
                                  ILogger<FXDeliverysController> logger,
                                  IWebHostEnvironment environment,
                                  IConfiguration configuration)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
            this._configuration = configuration;
        }


        //[BasicAuthentication]
        //[Authorize]
        [Route("GetPendingFxDelivery")]
        [HttpGet]
        public ActionResult<FXDeliveryView> GetPendingTrans()
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
                                      "Pending FX Settlements not found");
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
        [Route("GetFxDeliveryByDates/{dateFrom}/{dateTo}")]
        [HttpGet]
        public ActionResult<FxDeliveryView> GetFxDeliveryByDates(string dateFrom, string dateTo)
        {
            try
            {
                if (dateFrom == null || dateTo == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Start Date or End Date.");
                }

                var entry = _repository.GetFxDeliveryByDates(dateFrom, dateTo);

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
                        return StatusCode(StatusCodes.Status404NotFound,
                         "FX Transactions between contract date " + dateFrom.ToString() + " and " + dateTo.ToString() + " not found");
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
        [Route("GetFxDeliveryCorpByDate/{deliveryDate}")]
        [HttpGet]
        public ActionResult<FXDeliveryView> GetFxDeliveryCorpByDate(string deliveryDate)
        {
            try
            {
                if (deliveryDate == null )
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Delivery Date.");
                }

                string SPConnection = _configuration.GetConnectionString("GUIDESP");
                var entry = _repository.GetFxDeliveryCorpByDate(deliveryDate, SPConnection);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    if (deliveryDate != null)
                    {
                        // HTTP/1.1 404 Not found  
                        return StatusCode(StatusCodes.Status404NotFound,
                            "FX Settlement details on " + deliveryDate.ToString() + " not found");
                    }
                    else
                    {
                        // HTTP/1.1 404 Not found  
                        return StatusCode(StatusCodes.Status404NotFound,
                            "FX Settlement not found");
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
        [Route("GetFxDeliveryCorpSummaryByDate/{deliverySummryDate}")]
        [HttpGet]
        public ActionResult<FxDeliveryCorpSummaryView> GetFxDeliveryCorpSummaryByDate(string deliverySummryDate)
        {
            try
            {
                if (deliverySummryDate == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Delivery Date.");
                }

                string SPConnection = _configuration.GetConnectionString("GUIDESP");
                var entry = _repository.GetFxDeliveryCorpSummaryByDate(deliverySummryDate, SPConnection);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    if (deliverySummryDate != null)
                    {
                        return StatusCode(StatusCodes.Status404NotFound,
                             "FX Settlement details Summary on " + deliverySummryDate.ToString() + " not found");
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status404NotFound,
                                 "FX Settlement details Summary  not found");
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
        [Route("GetFxDeliveryByRefNo/{refNo}")]
        [HttpGet]
        public ActionResult<FxSettlementInf> GetFxDeliveryByRefNo(string refNo)
        {
            try
            {
                if (refNo == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing GBASE Reference No.");
                }

                var entry = _repository.GetFxDeliveryByRefNo(refNo);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                "FX Settlement of Ref No : " + refNo.ToString() + " not found");
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
                                         "FX Settlement of Ref No : " + status.RefNo.ToString() + " not found");
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
                                    "FX Settlement of Ref No : " + status.RefNo.ToString() + " not found");
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
