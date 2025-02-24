using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributionController : ControllerBase
    {
        private readonly IDistribution _repository;
        private readonly ILogger<FacilityTypeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;

        public DistributionController(IDistribution repository,                                
                                  ILogger<FacilityTypeController> logger,
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
        [Route("GetDistributionPreference/{AppName}")]
        [HttpGet]
        public ActionResult<DistributionPreferenceView> GetDistributionPreference(string AppName)
        {
            try
            {
                var entry = _repository.GetDistributionPreference(AppName);

                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Distribution Preference not found");
                }
            }
            catch (Exception)
            {
                // HTTP/1.1 500 server error  
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from the database");
            }
        }


        [Authorize]
        [Route("GetDistributionPassword/{abbreviation}/{branch}")]
        [HttpGet]
        public ActionResult<DistributionPasswordView> GetDistributionPassword(string abbreviation, string branch)
        {
            string sharedKey = _configuration["SharedKey"];
            try
            {
                var entry = _repository.GetDistributionPassword(abbreviation, branch, sharedKey);

                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Distribution Preference not found");
                }
            }
            catch (Exception)
            {
                // HTTP/1.1 500 server error  
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from the database");
            }
        }


        [Authorize]
        [Route("GetElcsConfirmation/{eDocType}/{dateAdded}")]
        [HttpGet]
        public ActionResult<DistributionView> GetElcsConfirmation(string dateAdded)
        {       
            try
            {
                var entry = _repository.GetElcsConfirmation(dateAdded);

                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Distribution Preference not found");
                }
            }
            catch (Exception)
            {
                // HTTP/1.1 500 server error  
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from the database");
            }
        }


        [Authorize]
        [Route("")]
        [HttpPut]
        public ActionResult<int> Put([FromBody] InputEDistribution eDistAttribute)
        {
            try
            {
                var entry = _repository.UpdateStatus(eDistAttribute);
                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                       "ELCS Confirmation ID: " + eDistAttribute.Id + " not found ");
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
                                 "ELCS Confirmation ID: " + eDistAttribute.Id + " not found ");
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
