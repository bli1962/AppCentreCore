using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomesticClearingsController : ControllerBase
    {
        private readonly IDomesticClearing _repository;
        private readonly ILogger<PaymentsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DomesticClearingsController(IDomesticClearing repository,
                                  ILogger<PaymentsController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }

        //[BasicAuthentication]
        //[Authorize]
        [Route("GetDCPaymentByDate/{dateValue}/{dateType}")]
        [HttpGet]
        public ActionResult<DomesticClearingPayment> GEtDomesticClearingPaymentByDate(string dateValue, string dateType)
        {
            try
            {
                if (dateValue == null || dateType == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Value Date or Date Type.");
                }

                var entry = _repository.GetDomesticClearingPaymentByDate(dateValue, dateType);

                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    if (dateValue != null)
                    {
                        return StatusCode(StatusCodes.Status404NotFound,
                           "DomesticClearing Payment of " + dateType + " on  the date: " + dateValue + " not found");
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status404NotFound,
                           "DomesticClearing Payment control of " + dateType + " not found");
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
        public ActionResult<int> Put([FromBody] DomesticClearingAttribute status)
        {
            try
            {
                var entry = _repository.UpdateStatus(status);
                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                        "Payment Id " + status.PaymentId.ToString() + " not found");
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
                                   "Payment Id " + status.PaymentId.ToString() + " not found");
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
