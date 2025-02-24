
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using mhcb.Syd.DataAccess.Models.EUCDbArchive;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilityTypeController : ControllerBase
    {

        private readonly IFacilityTypeOverride _repository;
        private readonly ILogger<FacilityTypeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FacilityTypeController(IFacilityTypeOverride repository,
                                  ILogger<FacilityTypeController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }


        //[BasicAuthentication]
        [Authorize]
        [Route("GetFacilityTypeOverride")]
        [HttpGet]
        public ActionResult<FacilityTypeOverride> GetFacilityTypeOverride()
        {
            try
            {
                var entry = _repository.GetFacilityTypeOverride();

                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound, "Credit Facility Type not found");
                }
            }
            catch (Exception)
            {
                // HTTP/1.1 500 server error  
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }


        //[BasicAuthentication]
        [Authorize]
        [Route("")]
        [HttpPost]
        public ActionResult<int> Post([FromBody] InputFacilityType status)
        {
            try
            {
                var entry = _repository.InsertFacilityType(status);

                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                          "Credit Facility Type " + status.RefNo.ToString() + " failed be appended.");
                // HTTP/1.1 200 OK  
                if (entry == "OK")
                {
                    var result = StatusCode(StatusCodes.Status200OK, "Save successfully.");
                    return result.StatusCode;
                }
                else if (entry == "Found")
                {
                    // HTTP/1.1 422 Un processable Entity:  
                    var result = StatusCode(StatusCodes.Status422UnprocessableEntity,
                                    "Credit Facility Type " + status.RefNo.ToString() + " has already been Added.");
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
