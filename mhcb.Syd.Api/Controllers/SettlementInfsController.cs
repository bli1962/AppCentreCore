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
using mhcb.Syd.DataAccess.Models.GUIDE;
using Microsoft.AspNetCore.Authorization;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettlementInfsController : ControllerBase
    {
        private readonly ISettlementInf _repository;
        private readonly ILogger<SettlementInfsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SettlementInfsController(ISettlementInf repository,
                                  ILogger<SettlementInfsController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }

        //[BasicAuthentication]
        //[Authorize]
        [Route("GetPendingSIF")]
        [HttpGet]
        public ActionResult<SettlementInfView> GetPendingTrans()
        {
            try
            {
                var entry = _repository.GetPendingTrans();

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Pending Settlement Information not found");
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
        [Route("GetSifInstructionsByStatus/{status}")]
        [HttpGet]
        public ActionResult<SettlementInfView> GetSifInstructionsByStatus(string status)
        {
            try
            {
                if (status == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Customer Abbreviation.");
                }

                var entry = _repository.GetSifInstructionsByStatus(status);

                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                    "Settlement Information of Customer abbreviation " + status.ToString() + " not found");
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
        [Route("GetSIFById/{Id}")]
        [HttpGet]
        public ActionResult<SettlementInfView> GetSettlementInfBySifId(int Id)
        {
            try
            {
                if (Id == 0)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing SIF Id.");
                }

                var entry = _repository.GetSettlementInfBySifId(Id);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                     "Settlement Information of ID :" + Id.ToString() + " not found");
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
        [Route("GetSIFByCustAbbr/{custAbbr}")]
        [HttpGet]
        public ActionResult<SettlementInfView> GetSettlementInfByCustAbbr(string custAbbr)
        {
            try
            {
                if (custAbbr == null )
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing Customer Abbreviation.");
                }

                var entry = _repository.GetSettlementInfByCustAbbr(custAbbr);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                    "Settlement Information of Customer abbreviation " + custAbbr.ToString() + " not found");
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
        [Route("GetSIFByCustAbbrCcyCDRecKind/{custAbbr}/{ccyCD}/{recordKind}")]
        [HttpGet]
        public ActionResult<SettlementInfView> GetSettlementInfByDetails(string custAbbr, string ccyCD, string recordKind)
        {
            try
            {
                if (ccyCD == null || custAbbr == null || recordKind  == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing CCY or Customer Abbreviation or Record Kind.");
                }

                var entry = _repository.GetSettlementInfByDetails(custAbbr, ccyCD, recordKind);

                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                   "Settlement Information of Customer : " + custAbbr.ToString() + " not found");
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
        [Route("GetSIFByStatus/{status}")]
        [HttpGet]
        public ActionResult<SettlementInf> GetSettlementInfsByStatus(string status = "All")
        {
            try
            {
                var entry = _repository.GetSettlementInfsByStatus(status);

                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                   "Settlement Information with status : " + status.ToString() + " not found");
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
        [HttpDelete]
        public ActionResult DeleteSettlementInf(int id)
        {
            if (id == 0)
            {
                // HTTP/1.1 400 Bad Request 
                return StatusCode(StatusCodes.Status400BadRequest, "Missing SIF Id.");
            }

            var entry = _repository.DeleteSettlementInf(id);

            if (entry == "OK")
            {
                // HTTP/1.1 200 OK  
                 return StatusCode(StatusCodes.Status200OK, "Settlement SIF with Id = " + id.ToString() + " is deleted");
            }
            else if (entry == "NotFound")
            {
                // HTTP/1.1 404 Not found  
                return StatusCode(StatusCodes.Status404NotFound,
                            "Settlement SIF with Id = " + id.ToString() + " not found");
            }
            else
            {
                // HTTP/1.1 500	Internal Server Error
                return StatusCode(StatusCodes.Status500InternalServerError, entry);
            }
        }

        //[BasicAuthentication]
        //[Authorize]
        [Route("")]
        [HttpPut]
        public ActionResult<int> Put([FromBody] SIFStatus status)
        {
            try
            {
                var entry = _repository.UpdateStatus(status);
                if (entry == null)
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                        "Settlement INF with Id " + status.SifId.ToString() + " not found");
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
                                    "Settlement INF with Id " + status.SifId.ToString() + " not found");
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
