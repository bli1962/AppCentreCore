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

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EUCBalanceEventsController : ControllerBase
    {
        private readonly IEUCBalanceEvent _repository;
        private readonly ILogger<EUCBalanceEventsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EUCBalanceEventsController(IEUCBalanceEvent repository,
                                  ILogger<EUCBalanceEventsController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }


        //[BasicAuthentication]
        //[Authorize]
        [Route("GetEUCBalanceEventByCustAbbr/{custAbbr}/{optDate}")]
        [HttpGet]
        public ActionResult<MxEucBalanceEvent> GetEUCBalanceEventByCustAbbr(string custAbbr, string optDate)
        {
            try
            {
                if (custAbbr == null || optDate == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Customer Abbreviation or Dates.");
                }

                var entry = _repository.GetEUCBalanceEventByCustAbbr(custAbbr, optDate);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                           "MxEUCBalance Event of Customer : " + custAbbr + " not found");
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
        [Route("GetEUCBalanceEventByRefno/{refNo}/{optDate}")]
        [HttpGet]
        public ActionResult<MxEucBalanceEvent> GetEUCBalanceEventByRefno(string refNo, string optDate)
        {
            try
            {
                if (refNo == null || optDate == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing GBASE Reference or Dates.");
                }

                var entry = _repository.GetEUCBalanceEventByRefno(refNo, optDate);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                          "MxEUCBalance Event of Ref No : " + refNo + " not found");
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
        [Route("GetMxInboundEventLogBySender/{sender}/{optDate}")]
        [HttpGet]
        public ActionResult<MxInboundEventLogView> GetMxInboundEventLogBySender(string sender, string optDate)
        {
            try
            {
                if (sender == null || optDate == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing System Sender or Dates.");
                }

                var entry = _repository.GetMxInboundEventLogBySender(sender, optDate);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                    "MxInbound Event Log of " + sender + " not found");
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
        [Route("GetPendingEUCBalanceEvent/{UpdateDdate}")]
        [HttpGet]
        public ActionResult<MxEucBalanceEventView> GetPendingTrans(string UpdateDdate)
        {
            try
            {
                var entry = _repository.GetPendingTrans(UpdateDdate);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                    "Pending EUC Balance Event not found");
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
        public ActionResult<int> Put([FromBody] EucBalanceAttribute balanceAttribute)
        {
            try
            {
                var entry = _repository.UpdateStatus(balanceAttribute);
                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                       "EUC Balance Event of " + balanceAttribute.GBaseReferenceNo.ToString() + " not found");
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
                                 "EUC Balance Event of " + balanceAttribute.GBaseReferenceNo.ToString() + " not found");
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
