using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using mhcb.Syd.DataAccess.Models.LOAN;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TrancheCovenantTypeController : ControllerBase
	{
		private readonly ITrancheCovenantType _repository;
		private readonly ILogger<TrancheCovenantTypeController> _logger;
		private readonly IWebHostEnvironment _webHostEnvironment;

		public TrancheCovenantTypeController(ITrancheCovenantType repository,
								  ILogger<TrancheCovenantTypeController> logger,
								  IWebHostEnvironment environment)
		{
			this._repository = repository;
			this._logger = logger;
			this._webHostEnvironment = environment;
		}

		//[Authorize]
		[Route("GetTrancheType")]
		[HttpGet]
		public ActionResult<TrancheType> LoadTrancheType()
		{
			try
			{
				var entry = _repository.LoadTrancheType();

				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									  "Tranche Type not found");
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
		[Route("GetCovenantConditionGroup")]
		[HttpGet]
		public ActionResult<CovenantConditionGroup> LoadCovenantConditionGroup()
		{
			try
			{
				var entry = _repository.LoadCovenantConditionGroup();

				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									  "Tranche Type not found");
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
		[Route("GetCovenantConditionByGroup/{conditionGroupDesc}")]
		[HttpGet]
		public ActionResult<CovenantConditionViewModel> LoadCovenantConditionByGroup(string conditionGroupDesc)
		{
			try
			{
				var entry = _repository.LoadCovenantConditionByGroup(conditionGroupDesc);
				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									  "Covenant condition not found");
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
		[Route("GetCovenantReceiptTiming")]
		[HttpGet]
		public ActionResult<CovenantReceiptTiming> LoadCovenantReceiptTiming()
		{
			try
			{
				var entry = _repository.LoadCovenantReceiptTiming();
				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									  "Covenant receipt timing not found");
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
		[Route("AddTrancheType")]
		[HttpPost]
		public ActionResult<int> Post([FromBody] InputTrancheType inputTrancheType)
		{
			try
			{
				var entry = _repository.AddTrancheType(inputTrancheType);

				if (entry == null)
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									   "Tranche type : " + inputTrancheType.TrancheTypeDesc + " failed be added.");
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
								   "Tranche type :" + inputTrancheType.TrancheTypeDesc + " failed be added.");
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


		//[Authorize]
		[Route("AddCovenantCondition")]
		[HttpPost]
		public ActionResult<int> Post([FromBody] InputCovenantCondition inputCovenantCondition)
		{
			try
			{
				var entry = _repository.AddCovenantCondition(inputCovenantCondition);

				if (entry == null)
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									   "Covenant condition : " + inputCovenantCondition.conditionDesc + " failed be added.");
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
								   "Covenant condition :" + inputCovenantCondition.conditionDesc + " failed be added.");
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

		//AddCovenantReceiptTiming(InputCovenantReceiptTiming inputCovenantReceiptTiming)

		[Route("AddCovenantReceiptTiming")]
		[HttpPost]
		public ActionResult<int> Post([FromBody] InputCovenantReceiptTiming inputCovenantReceiptTiming)
		{
			try
			{
				var entry = _repository.AddCovenantReceiptTiming(inputCovenantReceiptTiming);

				if (entry == null)
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									   "Covenant Receipt Timing : " + inputCovenantReceiptTiming.Interval 
									   + " " + inputCovenantReceiptTiming.DatePart + " failed be added.");
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
									"Covenant Receipt Timing : " + inputCovenantReceiptTiming.Interval
									   + " " + inputCovenantReceiptTiming.DatePart + " failed be added.");
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
