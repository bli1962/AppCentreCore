using AutoMapper;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BisRateController : ControllerBase
    {
        private readonly IBisRate _repository;
        private readonly ILogger<BisRateController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public BisRateController(IBisRate repository,
                                  ILogger<BisRateController> logger,
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
        [Route("GetBisRatesByDate/{dataDate}")]
        [HttpGet]
        public ActionResult<BisRateViewModel> GetBisRatesByDate(string dataDate)
        {
            try
            {
                if (dataDate == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Dates.");
                }

                var entry = _repository.GetBisRatesByDate(dataDate);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Bis Rate of date : " + dataDate + " not found");
                }
            }
            catch (Exception)
            {
                // HTTP/1.1 500 server error  
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from the database");
            }
        }

        [Route("GetBisRatesByDateCcyDuration/{dataDate}/{ccy}/{duration}/{unit}")]
        [HttpGet]
        public ActionResult<BisRateViewModel> GetBisRatesByDateCcyDuration(string dataDate, string ccy, int duration, string unit)
        {
            try
            {
                if (dataDate == null || ccy =="" || duration== 0  || unit == "" )
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Search Datas.");
                }

                var entry = _repository.GetBisRatesByDateCcyDuration(dataDate, ccy, duration, unit);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Bis Rate of date : " + dataDate + " not found");
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
        public ActionResult<int> AddBisRate([FromBody] BisRateViewModel bisRateViewModel)
        {
            try
            {
                //BisRate bisRate = new BisRate()
                //{
                //    DataDate = bisRateViewModel.DataDate,
                //    Ccy = (bisRateViewModel.Ccy).ToUpper(),
                //    Duration = bisRateViewModel.Duration,
                //    DurationUnit = (bisRateViewModel.DurationUnit).ToUpper(),
                //    BaseRate = bisRateViewModel.BaseRate,
                //    ImportedBy = (bisRateViewModel.ImportedBy).ToUpper(),
                //    RecStatus = "N",            //bisRateViewModel.RecStatus,
                //    ImportedTime = DateTime.Now //bisRateViewModel.ImportedTime
                //};

                var bisRate = _mapper.Map<BisRate>(bisRateViewModel);

                string entry;
                entry = _repository.AddBisRate(bisRate);
             
                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                          "Bis rate " + bisRateViewModel.DataDate.ToString() + " failed be appended.");

                // HTTP/1.1 200 OK  
                if (entry == "OK")
                {
                    var result = StatusCode(StatusCodes.Status200OK, "Save successfully.");
                    return result.StatusCode;
                }
                else if (entry == "Found")
                {
                    var result = StatusCode(StatusCodes.Status422UnprocessableEntity,
                                    "Bis rate " + bisRateViewModel.DataDate.ToString()  
                                        + " " + bisRateViewModel.Ccy.ToString()
                                        + " " + bisRateViewModel.Duration.ToString()
                                        + " " + bisRateViewModel.DurationUnit.ToString()
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
		[Route("{dataDate}/{ccy}/{duration}/{unit}")]
        [HttpDelete]
        public ActionResult<int> DeleteBisRate(string dataDate, string ccy, int duration, string unit)
        {
            try
            {
                if (dataDate == null || ccy == "" || duration == 0 || unit == "")
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Search Datas.");
                }

                var entry = _repository.DeleteBisRate(dataDate, ccy, duration, unit);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Bis Rate of date : " + dataDate + " not found");
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
        public ActionResult<int> UpdateBisRate([FromBody] BisRateViewModel bisRateViewModel)
        {
            //BisRate bisRate = new BisRate()
            //{
            //    DataDate = bisRateViewModel.DataDate,
            //    Ccy = bisRateViewModel.Ccy,
            //    Duration = bisRateViewModel.Duration,
            //    DurationUnit = bisRateViewModel.DurationUnit,
            //    BaseRate = bisRateViewModel.BaseRate,
            //    ImportedBy = bisRateViewModel.ImportedBy,
            //    RecStatus = bisRateViewModel.RecStatus,
            //    ImportedTime = bisRateViewModel.ImportedTime
            //};
            var bisRate = _mapper.Map<BisRate>(bisRateViewModel);

            string entry;
            entry = _repository.UpdateBisRate(bisRate);


            if (entry == null)
                // HTTP/1.1 404 Not found  
                return StatusCode(StatusCodes.Status404NotFound,
                                    "Bis rate of date " + bisRateViewModel.DataDate.ToString() + " not found");
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
                               "Bis rate of date " + bisRateViewModel.DataDate.ToString() + " not found");
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
        [Route("CheckBisRateImportedTime/{dataDate}")]
        [HttpGet]
        public ActionResult<BisRate> CheckBisRateImportedTime(DateTime dataDate)
        {
            try
            {
                //if (dataDate == null)
                //{
                //    // HTTP/1.1 400 Bad Request 
                //    return StatusCode(StatusCodes.Status400BadRequest, "Missing Run Date.");
                //}

                string SPConnection = _configuration.GetConnectionString("GUIDESP");
                var entry = _repository.CheckBisRateImportedTime(SPConnection, dataDate);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Bis Rate of date : " + dataDate + " not found");
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
