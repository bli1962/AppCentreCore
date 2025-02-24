using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.Interface;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatesGbaseUploadCtlController : ControllerBase
    {
        private readonly IRatesGbaseUploadCtl _repository;
        private readonly ILogger<RatesGbaseUploadCtlController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;

        private readonly IFxRate _repositoryFX;
        private readonly IRevaluationRate _repositoryRevaluation;
        private readonly ISwapRate _repositorySwap;
        private readonly IDepositsRate _repositoryDeposits;
        private readonly IBisRate _repositoryBis;
        public RatesGbaseUploadCtlController(IRatesGbaseUploadCtl repository,
                                            IFxRate repositoryFX,
                                            IRevaluationRate repositoryRevaluation,
                                            ISwapRate repositorySwap,
                                            IDepositsRate repositoryDeposits,
                                            IBisRate repositoryBis,
                                            ILogger<RatesGbaseUploadCtlController> logger,
                                            IWebHostEnvironment environment,
                                            IConfiguration configuration)
        {
            this._repository = repository;
            this._repositoryFX = repositoryFX;
            this._repositoryRevaluation = repositoryRevaluation;
            this._repositorySwap = repositorySwap;
            this._repositoryDeposits = repositoryDeposits;
            this._repositoryBis = repositoryBis;
            this._logger = logger;
            this._webHostEnvironment = environment;
            this._configuration = configuration;
        }


        [Authorize]
        [Route("GetRateCtlByRateType/{dataDate}/{rateType}")]
        [HttpGet]
        public ActionResult<RatesGbaseUploadCtl> GetRateCtlByRateType(DateTime dataDate, RateTypes rateType)
        {
            try
            {
                string SPConnection = _configuration.GetConnectionString("GUIDESP");
                var entry = _repository.SelectRateCtlByRateType(SPConnection, dataDate, rateType);

                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      rateType + " Rate on date : " + dataDate + " not found");
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
        [Route("GetRatesAvailablityCounter/{dataDate}")]
        [HttpGet]
        public ActionResult<RatesAvailablityStatus> GetRatesAvailablityCounter(DateTime dataDate)
        {
            try
            {
                var entry1 = _repositoryFX.GetFxRatesByDateDistinct(dataDate.ToString("yyyy-MM-dd"));
                var entry2 = _repositoryRevaluation.GetRevaluationRatesByDateDistinct(dataDate.ToString("yyyy-MM-dd"));
                var entry3 = _repositorySwap.GetSwapRatesByDateDistinct(dataDate.ToString("yyyy-MM-dd"));
                var entry4 = _repositoryDeposits.GetDepositsRatesByDateDistinct(dataDate.ToString("yyyy-MM-dd"));
                var entry5 = _repositoryBis.GetBisRatesByDateDistinct(dataDate.ToString("yyyy-MM-dd"));

                if (entry1 != null)
                {
                    RatesAvailablityStatus ratesAvailablity = new RatesAvailablityStatus()
                    {
                        DataDate = dataDate,
                        FXRateCount = entry1 == null ? 0 : entry1.Count(),
                        RevaluationRateCount = entry2 == null ? 0 : entry2.Count(),
                        SwapRateCount = entry3 == null ? 0 : entry3.Count(),
                        DepositRateCount = entry4 == null ? 0 : entry4.Count(),
                        BitRateCount = entry5 == null ? 0 : entry5.Count(),

                    };

                    // HTTP/1.1 200 OK 
                    //ListRatesAvailablity.Add(ratesAvailablity);
                    return Ok(ratesAvailablity);
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


        [Authorize]
        [Route("")]
        [HttpPost]
        public ActionResult<Boolean> Create_GbaseRates_Upload_Ctrl([FromBody] RatesControlPostDTO ratesControlPostDTO)
        {
            try
            {
                string inputSP = "";
                if (ratesControlPostDTO.RateType.ToString() == "FX_RATE")
                {
                    inputSP = "USP_GUIDE_Create_FXRate_Ctrl";
                }
                if (ratesControlPostDTO.RateType.ToString() == "REVALUATION_RATE")
                {
                    inputSP = "USP_GUIDE_Create_RevaluationRate_Ctrl";
                }
                if (ratesControlPostDTO.RateType.ToString() == "SWAP_RATE")
                {
                    inputSP = "USP_GUIDE_Create_SwapRate_Ctrl";
                }
                if (ratesControlPostDTO.RateType.ToString() == "DEPOSITS_RATE")
                {
                    inputSP = "USP_GUIDE_Create_DepositRate_Ctrl";
                }
                if (ratesControlPostDTO.RateType.ToString() == "BIS_RATE")
                {
                    inputSP = "USP_GUIDE_Create_BisRate_Ctrl";
                }

                string SPConnection = _configuration.GetConnectionString("GUIDESP");
                var entry = _repository.Create_GbaseRates_Upload_Ctrl(SPConnection, inputSP, ratesControlPostDTO.RunDate, ratesControlPostDTO.Operator);

                if (entry)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound, "Rate on date : " + ratesControlPostDTO.RunDate + " not found");
                }
            }
            catch (Exception)
            {
                // HTTP/1.1 500 server error  
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from the database");
            }
        }


        //[Route("GetRatesAvailablityCounter/{dataDate}")]
        //[HttpGet]
        //public ActionResult<RatesAvailablityStatus> GetRatesAvailablityCounter(DateTime dataDate)
        //{
        //    List<RatesAvailablityStatus> ListRatesAvailablity = new List<RatesAvailablityStatus>();
        //    try
        //    {
        //        if (dataDate == null)
        //        {
        //            // HTTP/1.1 400 Bad Request 
        //            return StatusCode(StatusCodes.Status400BadRequest, "Missing Input Date.");
        //        }

        //        var entry1 = _repositoryFX.GetFxRatesByDate(dataDate.ToString("yyyy-MM-dd"));
        //        var entry2 = _repositoryRevaluation.GetRevaluationRatesByDate(dataDate.ToString("yyyy-MM-dd"));
        //        var entry3 = _repositorySwap.GetSwapRatesByDate(dataDate.ToString("yyyy-MM-dd"));
        //        var entry4 = _repositoryDeposits.GetDepositsRatesByDate(dataDate.ToString("yyyy-MM-dd"));
        //        var entry5 = _repositoryBis.GetBisRatesByDate(dataDate.ToString("yyyy-MM-dd"));

        //        if (entry1 != null)
        //        {
        //            RatesAvailablityStatus ratesAvailablity = new RatesAvailablityStatus()
        //            {
        //                DataDate = dataDate,
        //                FXRateCount = entry1 == null ? 0 : entry1.Count(),
        //                RevaluationRateCount = entry2 == null ? 0 : entry2.Count(),
        //                SwapRateCount = entry3 == null ? 0 : entry3.Count(),
        //                DepositRateCount = entry4 == null ? 0 : entry4.Count(),
        //                BitRateCount = entry5 == null ? 0 : entry5.Count(),

        //            };

        //            // HTTP/1.1 200 OK 
        //            ListRatesAvailablity.Add(ratesAvailablity);
        //            return Ok(ListRatesAvailablity);
        //        }
        //        else
        //        {
        //            // HTTP/1.1 404 Not found  
        //            return StatusCode(StatusCodes.Status404NotFound,
        //                              "Fx Rate of date : " + dataDate + " not found");
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        // HTTP/1.1 500 server error  
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                           "Error retrieving data from the database");
        //    }
        //}
    }
}
