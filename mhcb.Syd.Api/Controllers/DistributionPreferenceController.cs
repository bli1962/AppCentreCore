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
    public class DistributionController : ControllerBase
    {
        private readonly IDistributionPreference _repository;
        private readonly ILogger<FacilityTypeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DistributionController(IDistributionPreference repository,
                                  ILogger<FacilityTypeController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }

        //[BasicAuthentication]
        //[Authorize]
        [Route("GetDistributionPreference")]
        [HttpGet]
        public ActionResult<DistributionPreferenceView> GetDistributionPreference()
        {
            try
            {
                var entry = _repository.GetDistributionPreference();

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

    }
}
