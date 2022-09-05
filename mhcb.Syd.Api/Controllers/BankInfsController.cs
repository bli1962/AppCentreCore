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

// In order to return Json format, do this
//services.AddMvc().AddJsonOptions(options =>
//{
//		options.JsonSerializerOptions.WriteIndented = true;
//});

// In order to return Json format for individul method, do this
//var json = JsonSerializer.Serialize<IEnumerable<Employee>>(employees);
//return context.Response.WriteAsync(json);

//if you plan to use the same controller for both views and web APIs, then only derive it from Controller class
//BadRequest	Returns 400 status code.
//Ok			Returns 200 status code along with the result object.
//NotFound		Returns 404 status code.
//PhysicalFile	Returns a file.

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankInfsController : ControllerBase
    {
        private readonly IBankInf _repository;
        private readonly ILogger<BankInfsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BankInfsController(IBankInf repository,
                                ILogger<BankInfsController> logger,
                                IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }


        //[BasicAuthentication]
        //[Authorize]
        [Route("GetPendingBIF")]
        [HttpGet]
        public ActionResult<BankInfView> GetPendingBIF()
        {
            try
            {
                var entry = _repository.GetPendingTrans();

                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Pending Bank Information not found");
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
        [Route("GetFullBankInfByStatus/{status}")]
        [HttpGet]
        public ActionResult<BankInfView> GetFullBankInfByStatus(string status)
        {         
            try
            {
                var entry = _repository.GetFullBankInfByStatus(status);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Pending Bank Information not found");
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
        [Route("GetBIFBySwiftID/{swiftId}")]
        [HttpGet()]
        public ActionResult<BankInfView> GetBankInfBySwiftID(string swiftId)
        {
            try
            {
                if (swiftId == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Swift ID.");
                }

                var entry = _repository.GetBankInfBySwiftID(swiftId);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                        "Bank Information of Swift ID : " + swiftId.ToString() + " not found");
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
        [Route("GetBIFByCustName/{custName}/{branchNo}")]
        [HttpGet()]
        public ActionResult<BankInfView> GetBankInfByDetails(string custName, string branchNo)
        {
            try
            {
                if (custName == null || branchNo == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing customer name or branch no.");
                }

                var entry = _repository.GetBankInfByDetails(custName, branchNo);
                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                       "Bank Information of Customer : " + custName.ToString() + " not found");
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
        [Route("GetBIFByStatus/{status}")]
        [HttpGet()]
        public ActionResult<BankInfView> GetBankInfsByStatus(string status = "All")
        {
            try
            {
                var entry = _repository.GetBankInfsByStatus(status);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Bank Information of Status : " + status.ToString() + " not found");
                    //return NotFound("Bank Information of Status : " + status.ToString() + " not found");
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
        public ActionResult<int> Put([FromBody] BankInfStatus status)
        {
            try
            {
                var entry = _repository.UpdateStatus(status);
                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                        "Bank Information of Swift ID " + status.SwiftId.ToString() + " not found");
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
                                    "Bank Information of Swift ID " + status.SwiftId.ToString() + " could not be set finalize.");
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
                var result = StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error retrieving data from the database");
                return result.StatusCode; 
            }
        }
    }
}
