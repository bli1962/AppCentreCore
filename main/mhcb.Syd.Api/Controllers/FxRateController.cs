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
    public class FxRateController : ControllerBase
    {
        private readonly IFxRate _repository;
        private readonly ILogger<FxRateController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public FxRateController(IFxRate repository,
                                  ILogger<FxRateController> logger,
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
        [Route("GetFxRatesByDate/{dataDate}")]
        [HttpGet]
        public ActionResult<FxRateViewModel> GetFxRatesByDate(string dataDate)
        {
            try
            {
                if (dataDate == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Dates.");
                }

                var entry = _repository.GetFxRatesByDate(dataDate);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Fx Rate of date : " + dataDate + " not found");
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
        [Route("GetFxRateByDateCcy/{dataDate}/{ccy}")]
        [HttpGet]
        public ActionResult<FxRateViewModel> GetFxRateByDateCcy(string dataDate, string ccy)
        {
            try
            {
                if (dataDate == null || ccy == "")
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Search Datas.");
                }

                var entry = _repository.GetFxRateByDateCcy(dataDate, ccy);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Fx Rate of date : " + dataDate + " not found");
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
        public ActionResult<int> AddFxRate([FromBody] FxRateViewModel fxRateViewModel)
        {
            try
            {
                //FxRate fxRate = new FxRate()
                //{
                //    DataDate = fxRateViewModel.DataDate,
                //    Ccy = (fxRateViewModel.Ccy).ToUpper(),
                //    Bid = fxRateViewModel.Bid,
                //    Offer = fxRateViewModel.Offer,
                //    Rate = fxRateViewModel.Rate,
                //    ImportedBy = (fxRateViewModel.ImportedBy).ToUpper(),
                //    RecStatus = "N",            // fxRateViewModel.RecStatus,
                //    ImportedTime = DateTime.Now // fxRateViewModel.ImportedTime
                //};

                var fxRate = _mapper.Map<FxRate>(fxRateViewModel);

                string entry;
                entry = _repository.AddFxRate(fxRate);

                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                          "Fx rate " + fxRateViewModel.DataDate.ToString() + " failed be appended.");

                // HTTP/1.1 200 OK  
                if (entry == "OK")
                {
                    var result = StatusCode(StatusCodes.Status200OK, "Save successfully.");
                    return result.StatusCode;
                }
                else if (entry == "Found")
                {
                    var result = StatusCode(StatusCodes.Status422UnprocessableEntity,
                                    "Fx rate " + fxRateViewModel.DataDate.ToString()
                                        + " " + fxRateViewModel.Ccy.ToString()
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
		[Route("{dataDate}/{ccy}")]
        [HttpDelete]
        public ActionResult<int> DeleteFxRate(string dataDate, string ccy)
        {
            try
            {
                if (dataDate == null || ccy == "")
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Search Datas.");
                }

                var entry = _repository.DeleteFxRate(dataDate, ccy);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Fx Rate of date : " + dataDate + " not found");
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
        public ActionResult<int> UpdateFxRate([FromBody] FxRateViewModel fxRateViewModel)
        {
            //FxRate fxRate = new FxRate()
            //{
            //    DataDate = fxRateViewModel.DataDate,
            //    Ccy = fxRateViewModel.Ccy,
            //    Bid = fxRateViewModel.Bid,
            //    Offer = fxRateViewModel.Offer,
            //    Rate = fxRateViewModel.Rate,
            //    ImportedBy = fxRateViewModel.ImportedBy,
            //    RecStatus = fxRateViewModel.RecStatus,
            //    ImportedTime = fxRateViewModel.ImportedTime
            //};
            var fxRate = _mapper.Map<FxRate>(fxRateViewModel);

            string entry;
            entry = _repository.UpdateFxRate(fxRate);


            if (entry == null)
                // HTTP/1.1 404 Not found  
                return StatusCode(StatusCodes.Status404NotFound,
                                    "FX rate of date " + fxRateViewModel.DataDate.ToString() + " not found");
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
                               "FX rate of date " + fxRateViewModel.DataDate.ToString() + " not found");
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
        [Route("CheckDailyFXRateImportedTime/{dataDate}")]
        [HttpGet]
        public ActionResult<FxRate> CheckDailyFXRateImportedTime(DateTime dataDate)
        {
            try
            {
                //if (dataDate == null)
                //{
                //    // HTTP/1.1 400 Bad Request 
                //    return StatusCode(StatusCodes.Status400BadRequest, "Missing Run Date.");
                //}

                string SPConnection = _configuration.GetConnectionString("GUIDESP");
                var entry = _repository.CheckDailyFXRateImportedTime(SPConnection, dataDate);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Fx Rate of date : " + dataDate + " not found");
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
