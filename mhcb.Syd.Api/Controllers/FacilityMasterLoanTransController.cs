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

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilityMasterLoanTransController : ControllerBase
    {
        private readonly IFacilityMasterLoanTrans _repository;
        private readonly ILogger<FacilityMasterLoanTransController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FacilityMasterLoanTransController(IFacilityMasterLoanTrans repository,
                                  ILogger<FacilityMasterLoanTransController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }


        //[BasicAuthentication]
        //[Authorize]
        [Route("GetLoanTransactionByDates/{dateFrom}/{dateTo}")]
        [HttpGet]
        public ActionResult<FacilityMasterLoanTransView> GetLoanTransactionByDates(string dateFrom, string dateTo)
        {
            try
            {
                if (dateFrom == null || dateTo == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Start Date or End Date.");
                }

                var entry = _repository.GetLoanTransactionByDates(dateFrom, dateTo);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Loan Transaction between start dates : " + dateFrom.ToString() + " and " + dateTo.ToString() + " not found");
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
        [Route("GetLoanTransactionByDatesCcy/{dateFrom}/{dateTo}/{ccy}")]
        [HttpGet]
        public ActionResult<FacilityMasterLoanTransView> GetLoanTransactionByDatesCcy(string dateFrom, string dateTo, string ccy)
        {
            try
            {
                if (dateFrom == null || dateTo == null || ccy == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Start Date or End Date or CCY.");
                }

                var entry = _repository.GetLoanTransactionByCcyDates(dateFrom, dateTo, ccy);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    if (dateFrom != null && dateTo != null)
                    {
                        return StatusCode(StatusCodes.Status404NotFound,
                                     "Loan Transaction between start dates : " + dateFrom.ToString() + " and " + dateTo.ToString() + " not found");
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status400BadRequest, entry);
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
