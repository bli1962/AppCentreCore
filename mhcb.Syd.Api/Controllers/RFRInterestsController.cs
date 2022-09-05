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
using Microsoft.Extensions.Configuration;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RFRInterestsController : ControllerBase
    {
        private readonly IRFRInterest _repository;
        private readonly ILogger<RFRInterestsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;

        public RFRInterestsController(IRFRInterest repository,
                                  ILogger<RFRInterestsController> logger,
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
        [Route("GetRFRLoanInterest/{reportDate}/{custAbbr}")]
        [HttpGet]
        public ActionResult<RFRInterestLoanView> GetRfrInterestForLoanByReportDate(string reportDate, string custAbbr)
        {
            try
            {
                if (reportDate == null || custAbbr == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Report Date or Customer Abbreviation.");
                }

                string SPConnection = _configuration.GetConnectionString("GUIDESP");
                var entry = _repository.GetRFRInterestForLoanByReportDate(reportDate, custAbbr, SPConnection);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    if (reportDate != null)
                    {
                        // HTTP/1.1 404 Not found  
                        return StatusCode(StatusCodes.Status404NotFound,
                            "Loan Transactions on Report Date:" + reportDate.ToString() + " not found");
                    }
                    else
                    {
                        // HTTP/1.1 404 Not found  
                        return StatusCode(StatusCodes.Status404NotFound,
                            "Loan Transactions on not found");
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
        [Route("GetRFRSwapInterest/{reportDate}/{custAbbr}")]
        [HttpGet]
        public ActionResult<RFRInterestSwapView> GetRfrInterestForSwapByReportDate(string reportDate, string custAbbr)
        {
            try
            {
                if (reportDate == null || custAbbr == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Report Date or Customer Abbreviation.");
                }

                string SPConnection = _configuration.GetConnectionString("GUIDESP");
                var entry = _repository.GetRFRInterestForSwapByReportDate(reportDate, custAbbr, SPConnection);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    if (reportDate != null)
                    {
                        // HTTP/1.1 404 Not found  
                        return StatusCode(StatusCodes.Status404NotFound,
                           "Swap Loan Transactions on Report Date: " + reportDate.ToString() + " not found");
                    }
                    else
                    {
                        // HTTP/1.1 404 Not found  
                        return StatusCode(StatusCodes.Status404NotFound,
                             "Swap Loan Transactions on not found");
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

    }
}
