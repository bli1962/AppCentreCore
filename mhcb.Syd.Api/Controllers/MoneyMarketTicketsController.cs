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

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyMarketTicketsController : ControllerBase
    {
        private readonly IMoneyMarketTicket _repository;
        private readonly ILogger<MoneyMarketTicketsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MoneyMarketTicketsController(IMoneyMarketTicket repository,
                                  ILogger<MoneyMarketTicketsController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }


        //[BasicAuthentication]
        //[Authorize]
        [Route("GetMMGID")]
        [HttpGet]
        public ActionResult<MoneyMarketTicketView> GetPendingTrans()
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
                                      "Pending MM Transactions not found");
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
        [Route("GetMMTransByDates/{dateFrom}/{dateTo}")]
        [HttpGet]
        public ActionResult<MoneyMarketTicketView> GetMoneyMarketTransactionByDates(string dateFrom, string dateTo)
        {
            try
            {
                if (dateFrom == null || dateTo == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Start Date or End Date.");
                }

                var entry = _repository.GetMoneyMarketTransactionByDates(dateFrom, dateTo);

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
                        // HTTP/1.1 404 Not found  
                        return StatusCode(StatusCodes.Status404NotFound,
                                         "MM Transactions between start dates : " + dateFrom.ToString() + " and " + dateFrom.ToString() + " not found");
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status404NotFound,
                                        "Pending MM Transactions not found");
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
        [Route("")]
        [HttpPut]
        public ActionResult<int> Put([FromBody] MMGIDStatus status)
        {
            try
            {
                var entry = _repository.UpdateStatus(status);
                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                        "GID of MM Transaction with Ticket " + status.TicketId.ToString() + " not found");
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
                                   "GID of MM Transaction with Ticket " + status.TicketId.ToString() + " not found");
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
