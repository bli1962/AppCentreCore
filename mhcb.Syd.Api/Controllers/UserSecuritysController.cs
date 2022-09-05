using mhcb.Syd.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSecuritysController : ControllerBase
    {
        private readonly IUserSecurity _repository;
        private readonly ILogger<UsersController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public UserSecuritysController(IUserSecurity repository,
                            ILogger<UsersController> logger,
                            IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }

        //[BasicAuthentication]
        //[Authorize]
        [Route("GetAuthorization/{UserId}")]
        [HttpGet]
        public ActionResult<string> GetAuthorization(string UserId)
        {
            try
            {
                if (UserId == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "User Id.");
                }

                string entry = _repository.GetAuthorization(UserId);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    //return Ok(entry);
                    return entry;
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "GUIDE User ID  : " + UserId.ToString() + " not found");
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
        [Route("GetAuthorizations/{UserId}")]
        [HttpGet]
        public ActionResult<string> GetAuthorizations(string UserId)
        {
            try
            {
                if (UserId == null)
                {
                    // HTTP/1.1 400 Bad Request 
                    return StatusCode(StatusCodes.Status400BadRequest, "Missing User Id.");
                }

                var entry = _repository.GetAuthorizations(UserId);
                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                     "GUIDE User ID : " + UserId.ToString() + " not found");
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
