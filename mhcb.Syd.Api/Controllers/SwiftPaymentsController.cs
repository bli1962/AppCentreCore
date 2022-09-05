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
    public class SwiftPaymentsController : ControllerBase
    {
        private readonly IPaymentControl _repository;
        private readonly ILogger<SwiftPaymentsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SwiftPaymentsController(IPaymentControl repository,
                                  ILogger<SwiftPaymentsController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }


        //[BasicAuthentication]
        //[Authorize]
        [Route("GetSwiftPTransByDate/{optDate}/{dateType}")]
        [HttpGet]
        public ActionResult<SwiftPaymentView>GetSwiftPaymentByDate(string optDate, string dateType)
        {
            try
            {
                if (optDate == null || dateType == null )
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Date or Date Type.");
                }

                var entry = _repository.GetSwiftPaymentByDate(optDate, dateType);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    if (optDate != null)
                    {
                        return StatusCode(StatusCodes.Status404NotFound,
                           "SWIFT Payments of " + dateType + " on  the date: " + optDate + " not found");
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status404NotFound,
                           "SWIFT Payments of " + dateType + " not found");
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
        [Route("Delete")]
        [HttpDelete]
        public ActionResult<int> DeleteSwiftPayment(SwiftPaymentStatus status)
        {            
            try
            {
                var entry = _repository.DeleteSwiftPayment(status);

                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                        "SwiftPayment Id " + status.SwiftPaymentId.ToString() + " not found");
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
                                    "SwiftPayment Id " + status.SwiftPaymentId.ToString() + " not found");
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
