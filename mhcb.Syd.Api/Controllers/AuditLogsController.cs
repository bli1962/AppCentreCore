using System;
using System.Threading.Tasks;
using System.Net;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using Microsoft.AspNetCore.Authorization;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditLogsController : ControllerBase
    {
        private readonly IAuditLog _repository;
        private readonly ILogger<AuditLogsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AuditLogsController(IAuditLog repository,
                                  ILogger<AuditLogsController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }

        //[BasicAuthentication]
        //[Authorize]
        [Route("GetAuditLogByDate/{optDate}")]
        [HttpGet]
        public ActionResult<AuditLog> LoadAuditLogByDate(string optDate)
        {
            try
            {
                var entry = _repository.GetAuditLogByDate(optDate);
                if (entry != null )
                {
                    // HTTP/1.1 200 OK 
                    //return Ok(entry);
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "Audit Log of  : " + optDate.ToString() + " not found");
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
        [Route("GetAuditLogByDates/{dateFrom}/{dateTo}")]
        [HttpGet]
        public ActionResult<AuditLog> LoadAuditLogByDates(string dateFrom, string dateTo)
        {
            try
            {
                var entry = _repository.GetAuditLogByDates(dateFrom, dateTo);

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
                               "Audit Log of between " + dateFrom.ToString() + " and " + dateTo.ToString() + "not found");
                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status404NotFound,
                               "Audit Log not found");
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
