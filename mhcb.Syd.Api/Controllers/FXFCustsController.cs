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
    public class FXFCustsController : ControllerBase
    {
        private readonly IFXFCust _repository;
        private readonly ILogger<FXFCustsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FXFCustsController(IFXFCust repository,
                                  ILogger<FXFCustsController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }


        //[BasicAuthentication]
        //[Authorize]
        [Route("GetMMCustByAbbr/{abbreviation}")]
        [HttpGet]
        public ActionResult<FXFCustomerView> GetMMCustByAbbr(string abbreviation)
        {
            try
            {
                if (abbreviation == null )
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Customer Abbreviation or Branch no.");
                }

                var entry = _repository.LoadFXCustByCustAbbr(abbreviation);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                     "Customer of " + abbreviation.ToString() + " not found");
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
        public ActionResult<int> Put([FromBody] FXFCustAttribute custAttr)
        {
            try
            {
                var entry = _repository.UpdateStatus(custAttr);
                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Customer of abbreviation :" + custAttr.Abbreviation.ToString() + " not found to update");
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
                               "Customer of abbreviation :" + custAttr.Abbreviation.ToString() + " not found to update");
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
