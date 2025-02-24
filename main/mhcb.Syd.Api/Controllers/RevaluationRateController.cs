using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.Extensions.Configuration;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevaluationRateController : ControllerBase
    {
        private readonly IRevaluationRate _repository;
        private readonly ILogger<RevaluationRateController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public RevaluationRateController(IRevaluationRate repository,
                                  ILogger<RevaluationRateController> logger,
                                  IMapper mapper,
                                  IWebHostEnvironment environment,
                                   IConfiguration configuration)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
            this._mapper = mapper;
            this._configuration = configuration;
        }

        //[Authorize]
        [Route("GetRevaluationRatesByDate/{dataDate}")]
        [HttpGet]
        public ActionResult<RevaluationRateViewModel> GetRevaluationRatesByDate(string dataDate)
        {
            try
            {
                if (dataDate == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Dates.");
                }

                var entry = _repository.GetRevaluationRatesByDate(dataDate);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Revaluation of date : " + dataDate + " not found");
                }
            }
            catch (Exception)
            {
                // HTTP/1.1 500 server error  
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from the database");
            }
        }


        //[Authorize]
        [Route("GetRevaluationRateByDateCcyDay/{dataDate}/{ccy}/{day}")]
        [HttpGet]
        public ActionResult<RevaluationRateViewModel> GetRevaluationRateByDateCcyDay(string dataDate, string ccy, int day)
        {
            try
            {
                if (dataDate == null || ccy == "")
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Search Datas.");
                }

                var entry = _repository.GetRevaluationRateByDateCcyDay(dataDate, ccy, day);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Revaluation of date : " + dataDate + " not found");
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
		[Authorize(Roles = "FX_RATE_Authorise")]
		[Route("")]
        [HttpPost]
        public ActionResult<int> AddRevaluationRate([FromBody] RevaluationRateViewModel revaluationRateViewModel)
        {
            try
            {
                //RevaluationRate revaluationRate = new RevaluationRate()
                //{
                //    DataDate = revaluationRateViewModel.DataDate,
                //    Ccy = (revaluationRateViewModel.Ccy).ToUpper(),
                //    Days = revaluationRateViewModel.Days,
                //    Rate = revaluationRateViewModel.Rate,
                //    ImportedBy = (revaluationRateViewModel.ImportedBy).ToUpper(),
                //    RecStatus = "N",            // revaluationRateViewModel.RecStatus,
                //    ImportedTime = DateTime.Now // revaluationRateViewModel.ImportedTime
                //};

                var revaluationRate = _mapper.Map<RevaluationRate>(revaluationRateViewModel);

                string entry;
                entry = _repository.AddRevaluationRate(revaluationRate);

                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                          "Revaluation rate " + revaluationRateViewModel.DataDate.ToString() + " failed be appended.");

                // HTTP/1.1 200 OK  
                if (entry == "OK")
                {
                    var result = StatusCode(StatusCodes.Status200OK, "Save successfully.");
                    return result.StatusCode;
                }
                else if (entry == "Found")
                {
                    var result = StatusCode(StatusCodes.Status422UnprocessableEntity,
                                    "Revaluation rate " + revaluationRateViewModel.DataDate.ToString()
                                        + " " + revaluationRateViewModel.Ccy.ToString()
                                        + " " + revaluationRateViewModel.Days.ToString()
                                        + " has already been Added.");
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


		[Authorize(Roles = "FX_RATE_Authorise")]
		[Route("{dataDate}/{ccy}/{day}")]
        [HttpDelete]
        public ActionResult<int> DeleteRevaluationRate(string dataDate, string ccy, int day)
        {
            try
            {
                if (dataDate == null || ccy == "")
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Search Datas.");
                }

                var entry = _repository.DeleteRevaluationRate(dataDate, ccy, day);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Revaluation of date : " + dataDate + " not found");
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
		[Authorize(Roles = "FX_RATE_Authorise")]
		[Route("")]
        [HttpPut]
        public ActionResult<int> UpdateRevaluationRate([FromBody] RevaluationRateViewModel revaluationRateViewModel)
        {
            //RevaluationRate revaluationRate = new RevaluationRate()
            //{
            //    DataDate = revaluationRateViewModel.DataDate,
            //    Ccy = revaluationRateViewModel.Ccy,
            //    Days = revaluationRateViewModel.Days,
            //    Rate = revaluationRateViewModel.Rate,
            //    ImportedBy = revaluationRateViewModel.ImportedBy,
            //    RecStatus = revaluationRateViewModel.RecStatus,
            //    ImportedTime = revaluationRateViewModel.ImportedTime
            //};
            var revaluationRate = _mapper.Map<RevaluationRate>(revaluationRateViewModel);

            string entry;
            entry = _repository.UpdateRevaluationRate(revaluationRate);


            if (entry == null)
                // HTTP/1.1 404 Not found  
                return StatusCode(StatusCodes.Status404NotFound,
                                    "Bis rate of date " + revaluationRateViewModel.DataDate.ToString() + " not found");
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
                               "Bis rate of date " + revaluationRateViewModel.DataDate.ToString() + " not found");
                return result.StatusCode;
            }
            else
            {
                var result = StatusCode(StatusCodes.Status400BadRequest, "Bad request.");
                return result.StatusCode;
            }
        }


        //NDF project
        //[Authorize]
        [Route("CheckRevaluationRateImportedTime/{dataDate}")]
        [HttpGet]
        public ActionResult<RevaluationRate> CheckRevaluationRateImportedTime(DateTime dataDate)
        {
            try
            {
                //if (dataDate == null)
                //{
                //    // HTTP/1.1 400 Bad Request 
                //    return StatusCode(StatusCodes.Status400BadRequest, "Missing Run Date.");
                //}

                string SPConnection = _configuration.GetConnectionString("GUIDESP");
                var entry = _repository.CheckRevaluationRateImportedTime(SPConnection, dataDate);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Revaluation of date : " + dataDate + " not found");
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
