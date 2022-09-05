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
    public class CovenantMastersController : ControllerBase
    {
        private readonly ICovenantMasterRecord _repository;
        private readonly ILogger<CovenantMastersController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CovenantMastersController(ICovenantMasterRecord repository,
                                  ILogger<CovenantMastersController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }

        //[BasicAuthentication]
        //[Authorize]
        [Route("GetCovenantMasterRecord")]
        [HttpGet]
        public ActionResult<CovenantMasterRecordView> GetCovenantMasterRecord()
        {
            try
            {
                var entry = _repository.GetCovenantMasterRecord();

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                            "Covenant Master Records not found");
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
        [Route("GetCovenantRatio/{covenantType}/{dateType}/{dateFrom}/{dateTo}")]
        [HttpGet]
        public ActionResult<CovenantRatioView> GetCovenantRatio(string covenantType, string dateType, string dateFrom, string dateTo)
        {
            try
            {
                if (covenantType == null )
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Covenant Type.");
                }

                var entry = _repository.GetCovenantRatio(covenantType, dateType, dateFrom, dateTo);
                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                            "Covenant Ratio Records of covenant type : " + covenantType.ToString() + " not found");
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
