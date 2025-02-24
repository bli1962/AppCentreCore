using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerMastersController : ControllerBase
    {
        private readonly ICustomerMaster _repository;
        private readonly ILogger<CustomerMastersController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;

        public CustomerMastersController(ICustomerMaster repository,
                                  ILogger<CustomerMastersController> logger,
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
        [Route("GetCustomerMasterByCustAbbr/{custAbbr}/{branchNo}")]
        [HttpGet]
        public ActionResult<CustomerMaster> LoadCustomerMasterByCustAbbr(string custAbbr, string branchNo)
        {
            try
            {
                if (custAbbr == null || branchNo == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Customer Abbreviation or Branch no.");
                }

                var entry = _repository.LoadCustomerMasterByCustAbbr(custAbbr, branchNo);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                    "Customer name of " + custAbbr.ToString() + " not found");
                }
            }
            catch (Exception)
            {
                // HTTP/1.1 500 server error  
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from the database");
            }
        }


        [Route("LoadDistirbutionPassword/{custName}/{branchNo}")]
        [HttpGet]
        public ActionResult<CustDistirbutionInfo> LoadDistirbutionPassword(string custName, string branchNo)
        {
            try
            {
                if (custName == null || branchNo == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing customer details or Branch no.");
                }

                string sharedKey = _configuration["SharedKey"];
                var entry = _repository.LoadDistirbutionPasswordByCustName(custName, branchNo, sharedKey);

                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                    "Customer name of " + custName.ToString() + " not found");
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
