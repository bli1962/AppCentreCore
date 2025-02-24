using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RatesMessageController : ControllerBase
	{
		private readonly IRatesMessage _repository;
		private readonly ILogger<RatesMessageController> _logger;
		private readonly IWebHostEnvironment _webHostEnvironment;
		private readonly IMapper _mapper;
		private readonly IConfiguration _configuration;

		public RatesMessageController(IRatesMessage repository,
								  ILogger<RatesMessageController> logger,
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


		//NDF project
		[Authorize(Roles = "FX_RATE_Authorise")]
		[Route("")]
		[HttpPost]
		public ActionResult<int> SendMessageToQueue([FromBody] MessageDTO messageDto)
		{
			try
			{
				//if (!(messageDto.SentTo is QueueTypes))
				//{
				//	// HTTP/1.1 400 Bad Request 
				//	_logger.LogWarning("Incorrect Input Message Queue Type {0}.", messageDto.SentTo);
				//	return StatusCode(StatusCodes.Status400BadRequest, "Incorrect Message Queue.");
				//}
                if (!Enum.IsDefined(typeof(QueueTypes), messageDto.SentTo))
                {
                    // HTTP/1.1 400 Bad Request 
                    _logger.LogWarning("Incorrect Input Message Queue Type {0}.", messageDto.SentTo);
                    return StatusCode(StatusCodes.Status400BadRequest, "Incorrect Message Queue.");
                }

                string entry;
                entry = _repository.PrepareMessagesToQueue(messageDto);

                if (entry == null)
				{
                    // HTTP/1.1 404 Not found  
                    _logger.LogWarning("Failed to Create GIP Message of Rate {0} Upload.", messageDto.SentTo);
                    var result= StatusCode(StatusCodes.Status404NotFound, "Failed to Send Message to Rate Queue " + messageDto.SentTo);
                    return result.StatusCode;
                }

                if (entry == "OK")
                {
                    _logger.LogInformation("Successfully Create GIP Message of Rate {0} Upload.", messageDto.SentTo);
                    var result = StatusCode(StatusCodes.Status200OK, "Successfully Create GIP Message of Rate " + messageDto.SentTo +" Uploading.");
                    return result.StatusCode;
                }
                else if (entry == "Not Found")
                {
                    _logger.LogWarning("No GIP Message Created of Rate {0} Upload.", messageDto.SentTo);
                    var result = StatusCode(StatusCodes.Status404NotFound,
                                    "No GIP Message Created of Rate " + messageDto.SentTo);
                    return result.StatusCode;
                }
                else if (entry == "Failed")
                {
                    _logger.LogWarning("Failed to Create GIP Message of Rate {0} Upload.", messageDto.SentTo);
                    var result = StatusCode(StatusCodes.Status422UnprocessableEntity,
                                    "Failed to Create GIP Message of Rate " + messageDto.SentTo + " Upload.");
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
				_logger.LogWarning("Failed to Create GIP Message of Rate {0} Upload, Due to Database Issue", messageDto.SentTo);
				return StatusCode(StatusCodes.Status500InternalServerError,
								   "Failed to Send Message to Rate Queue due to Database issue.");
			}
		}
	}
}
