using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositsRateController : ControllerBase
    {
        private readonly IDepositsRate _repository;
        private readonly ILogger<DepositsRateController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public DepositsRateController(IDepositsRate repository,
                                  ILogger<DepositsRateController> logger,
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
        [Route("GetDepositsRatesByDate/{dataDate}")]
        [HttpGet]
        public ActionResult<DepositsRateViewModel> GetDepositsRatesByDate(string dataDate)
        {
            try
            {
                if (dataDate == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Dates.");
                }

                var entry = _repository.GetDepositsRatesByDate(dataDate);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Deposits Rate of date : " + dataDate + " not found");
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
        [Route("GetDepositsRateByDateCcyPeriod/{dataDate}/{ccy}/{period}")]
        [HttpGet]
        public ActionResult<DepositsRateViewModel> GetDepositsRateByDateCcyPeriod(string dataDate, string ccy, string period)
        {
            try
            {
                if (dataDate == null || ccy =="" || period =="")
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Search Datas.");
                }

                var entry = _repository.GetDepositsRateByDateCcyPeriod(dataDate, ccy, period);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Deposits Rate of date : " + dataDate + " not found");
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
        public ActionResult<int> AddDepositsRate([FromBody] DepositsRateViewModel depositsRateViewModel)
        {
            try
            {
                //DepositsRate depositsRate = new DepositsRate()
                //{
                //    DataDate = depositsRateViewModel.DataDate,
                //    Ccy = (depositsRateViewModel.Ccy).ToUpper(),
                //    Period = (depositsRateViewModel.Period).ToUpper(),
                //    Bid = depositsRateViewModel.Bid,
                //    Offer = depositsRateViewModel.Offer,
                //    Rate = depositsRateViewModel.Rate,
                //    ImportedBy = (depositsRateViewModel.ImportedBy).ToUpper(),
                //    RecStatus = "N",             //depositsRateViewModel.RecStatus,
                //    ImportedTime = DateTime.Now  // depositsRateViewModel.ImportedTime
                //};

                var depositsRate = _mapper.Map<DepositsRate>(depositsRateViewModel);

                string entry;
                entry = _repository.AddDepositsRate(depositsRate);

                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                          "Deposits rate " + depositsRate.DataDate.ToString() + " failed be appended.");

                // HTTP/1.1 200 OK  
                if (entry == "OK")
                {
                    var result = StatusCode(StatusCodes.Status200OK, "Save successfully.");
                    return result.StatusCode;
                }
                else if (entry == "Found")
                {
                    var result = StatusCode(StatusCodes.Status422UnprocessableEntity,
                                    "Deposits rate " + depositsRate.DataDate.ToString()
                                        + " " + depositsRate.Ccy.ToString()
                                        + " " + depositsRate.Period.ToString()
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
		[Route("{dataDate}/{ccy}/{period}")]
        [HttpDelete]
        public ActionResult<int> DeleteDepositsRate(string dataDate, string ccy, string period)
        {
            try
            {
                if (dataDate == null || ccy == "" || period == "")
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Search Datas.");
                }

                var entry = _repository.DeleteDepositsRate(dataDate, ccy, period);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Deposits Rate of date : " + dataDate + " not found");
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
        public ActionResult<int> UpdateDepositsRate([FromBody] DepositsRateViewModel depositsRateViewModel)
        {
            //DepositsRate depositsRate = new DepositsRate()
            //{
            //    DataDate = depositsRateViewModel.DataDate,
            //    Ccy = depositsRateViewModel.Ccy,
            //    Period = depositsRateViewModel.Period,
            //    Bid = depositsRateViewModel.Bid,
            //    Offer = depositsRateViewModel.Offer,
            //    Rate = depositsRateViewModel.Rate,
            //    ImportedBy = depositsRateViewModel.ImportedBy,
            //    RecStatus = depositsRateViewModel.RecStatus,
            //    ImportedTime = depositsRateViewModel.ImportedTime
            //};
            var depositsRate = _mapper.Map<DepositsRate>(depositsRateViewModel);

            string entry;
            entry = _repository.UpdateDepositsRate(depositsRate);


            if (entry == null)
                // HTTP/1.1 404 Not found  
                return StatusCode(StatusCodes.Status404NotFound,
                                    "Deposits rate of date " + depositsRateViewModel.DataDate.ToString() + " not found");
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
                               "Bis rate of date " + depositsRateViewModel.DataDate.ToString() + " not found");
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
        [Route("CheckDepostRateImportedTime/{dataDate}")]
        [HttpGet]
        public ActionResult<DepositsRate> CheckDepostRateImportedTime(DateTime dataDate)
        {
            try
            {
                //if (dataDate == null)
                //{
                //    // HTTP/1.1 400 Bad Request 
                //    return StatusCode(StatusCodes.Status400BadRequest, "Missing Run Date.");
                //}

                string SPConnection = _configuration.GetConnectionString("GUIDESP");
                var entry = _repository.CheckDepostRateImportedTime(SPConnection, dataDate);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Deposits Rate of date : " + dataDate + " not found");
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
