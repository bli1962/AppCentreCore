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
    public class EUCOnDemandBatchsController : ControllerBase
    {
        private readonly IEUCOnDemandBatch _repository;
        private readonly ILogger<EUCOnDemandBatchsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EUCOnDemandBatchsController(IEUCOnDemandBatch repository,
                                  ILogger<EUCOnDemandBatchsController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }


        //[BasicAuthentication]
        //[Authorize]
        [Route("GetOnDemandBatchNoByDate")]
        [HttpGet]
        public ActionResult<OnDemandBatchView> GetOnDemandBatchNoByDate()
        {
            try
            {
                //var dtfi = CultureInfo.CurrentCulture.DateTimeFormat;
                string createdDate = DateTime.Today.ToShortDateString();
                //createdDate = "09/06/2021";

                var entry = _repository.GetOnDemandBatchNoByDate(createdDate);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                           "Today EUC OnDemand Batch not found");
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
        [Route("GetOnDemandBatchLogByBatchNo/{batchId}")]
        [HttpGet]
        public ActionResult<OnDemandBatchView> GetOnDemandBatchLogByBatchNo(string batchId)
        {
            try
            {
                if (batchId == null )
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Batch ID.");
                }

                var entry = _repository.GetOnDemandBatchLogByBatchNo(batchId);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                           "EUC OnDemand Batch Log of " + batchId + " not found");
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
        [Route("")]
        [HttpPut]
        public ActionResult<int> Put([FromBody] OnDemandBatchAttribute onDemandBatchAttribute)
        {
            try
            {
                var entry = _repository.UpdateStatus(onDemandBatchAttribute);
                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                         "EUC OnDemand Batch of " + onDemandBatchAttribute.BatchNo.ToString() + " not found or to be updated.");
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
                                    "EUC OnDemand Batch of " + onDemandBatchAttribute.BatchNo.ToString() + " not found or to be updated.");
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
