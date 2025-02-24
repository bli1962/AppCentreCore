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
    public class SwapRateController : ControllerBase
    {
        private readonly ISwapRate _repository;
        private readonly ILogger<SwapRateController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public SwapRateController(ISwapRate repository,
                                  ILogger<SwapRateController> logger,
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
        [Route("GetSwapRatesByDate/{dataDate}")]
        [HttpGet]
        public ActionResult<SwapRateViewModel> GetSwapRatesByDate(string dataDate)
        {
            try
            {
                if (dataDate == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Dates.");
                }

                var entry = _repository.GetSwapRatesByDate(dataDate);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Swap Rate of date : " + dataDate + " not found");
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
        [Route("GetSwapRateByDateCcyDuration/{dataDate}/{ccy}/{duration}/{unit}")]
        [HttpGet]
        public ActionResult<SwapRateViewModel> GetSwapRateByDateCcyDuration(string dataDate, string ccy, int duration, string unit)
        {
            try
            {
                if (dataDate == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Search Datas.");
                }

                var entry = _repository.GetSwapRateByDateCcyDuration(dataDate, ccy, duration, unit);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Swap Rate of date : " + dataDate + " not found");
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
        public ActionResult<int> AddSwapRate([FromBody] SwapRateViewModel swapRateViewModel)
        {
            try
            {
                //SwapRate swapRate = new SwapRate()
                //{
                //    DataDate = swapRateViewModel.DataDate,
                //    Ccy = (swapRateViewModel.Ccy).ToUpper(),
                //    Duration = swapRateViewModel.Duration,
                //    DurationUnit = (swapRateViewModel.DurationUnit).ToUpper(),
                //    BidRate = swapRateViewModel.BidRate,
                //    OfferRate = swapRateViewModel.OfferRate,
                //    ImportedBy = (swapRateViewModel.ImportedBy).ToUpper(),
                //    RecStatus = "N",            // swapRateViewModel.RecStatus,
                //    ImportedTime = DateTime.Now // swapRateViewModel.ImportedTime
                //};

                var swapRate = _mapper.Map<SwapRate>(swapRateViewModel);

                string entry;
                entry = _repository.AddSwapRate(swapRate);

                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                          "Swap rate " + swapRateViewModel.DataDate.ToString() + " failed be appended.");

                // HTTP/1.1 200 OK  
                if (entry == "OK")
                {
                    var result = StatusCode(StatusCodes.Status200OK, "Save successfully.");
                    return result.StatusCode;
                }
                else if (entry == "Found")
                {
                    var result = StatusCode(StatusCodes.Status422UnprocessableEntity,
                                    "Swap rate " + swapRateViewModel.DataDate.ToString()
                                        + " " + swapRateViewModel.Ccy.ToString()
                                        + " " + swapRateViewModel.Duration.ToString()
                                        + " " + swapRateViewModel.DurationUnit.ToString()
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
        public ActionResult<int> DeleteSwapRate(string dataDate, string ccy, int duration, string unit)
        {
            try
            {
                if (dataDate == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Search Datas.");
                }

                var entry = _repository.DeleteSwapRate(dataDate, ccy, duration, unit);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Swap Rate of date : " + dataDate + " not found");
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
        public ActionResult<int> UpdateSwapRate([FromBody] SwapRateViewModel swapRateViewModel)
        {
            //SwapRate swapRate = new SwapRate()
            //{
            //    DataDate = swapRateViewModel.DataDate,
            //    Ccy = swapRateViewModel.Ccy,
            //    Duration = swapRateViewModel.Duration,
            //    DurationUnit = swapRateViewModel.DurationUnit,
            //    BidRate = swapRateViewModel.BidRate,
            //    OfferRate = swapRateViewModel.OfferRate,
            //    ImportedBy = swapRateViewModel.ImportedBy,
            //    RecStatus = swapRateViewModel.RecStatus,
            //    ImportedTime = swapRateViewModel.ImportedTime
            //};
            var swapRate = _mapper.Map<SwapRate>(swapRateViewModel);

            string entry;
            entry = _repository.UpdateSwapRate(swapRate);


            if (entry == null)
                // HTTP/1.1 404 Not found  
                return StatusCode(StatusCodes.Status404NotFound,
                                    "Bis rate of date " + swapRateViewModel.DataDate.ToString() + " not found");
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
                               "Bis rate of date " + swapRateViewModel.DataDate.ToString() + " not found");
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
        [Route("CheckSwapRateImportedTime/{dataDate}")]
        [HttpGet]
        public ActionResult<SwapRate> CheckSwapRateImportedTime(DateTime dataDate)
        {
            try
            {
                //if (dataDate == null)
                //{
                //    // HTTP/1.1 400 Bad Request 
                //    return StatusCode(StatusCodes.Status400BadRequest, "Missing Run Date.");
                //}

                string SPConnection = _configuration.GetConnectionString("GUIDESP");
                var entry = _repository.CheckSwapRateImportedTime(SPConnection, dataDate);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Swap Rate of date : " + dataDate + " not found");
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
