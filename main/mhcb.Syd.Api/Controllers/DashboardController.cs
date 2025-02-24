using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using mhcb.Syd.Interface.Dashboard;
using mhcb.Syd.Models.Dashboard;

namespace mhcb.Syd.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DashboardController : ControllerBase
	{
		private readonly IFXTransactionCount _repository1;
		private readonly IFXDeliveryCount _repository2;
		private readonly IBankInfCount _repository3;
		private readonly ISettlementInfCount _repository4;
		private readonly ICustomerCount _repository5;
		private readonly IMoneyMarketCount _repository6;
		private readonly IPaymentControlCount _repository7;
		private readonly IDocumentCount _repository8;
		private readonly IDistributionCount _repository9;
        private readonly IDomesticClearingCount _repository10;
        private readonly IFXConfirmationCount _repository11;

        private readonly ILogger<DashboardController> _logger;
		private readonly IWebHostEnvironment _webHostEnvironment;

		public DashboardController(IFXTransactionCount repository1,
								IFXDeliveryCount repository2,
								IBankInfCount repository3,
								ISettlementInfCount repository4,
								ICustomerCount repository5,
								IMoneyMarketCount repository6,
								IPaymentControlCount repository7,
								IDocumentCount repository8,
								IDistributionCount repository9,
                                IDomesticClearingCount repository10,
                                IFXConfirmationCount repository11,
                                ILogger<DashboardController> logger,
								IWebHostEnvironment environment)
		{
			this._repository1 = repository1;
			this._repository2 = repository2;
			this._repository3 = repository3;
			this._repository4 = repository4;
			this._repository5 = repository5;
			this._repository6 = repository6;
			this._repository7 = repository7;
			this._repository8 = repository8;
			this._repository9 = repository9;
            this._repository10 = repository10;
            this._repository11 = repository11;

            this._logger = logger;
			this._webHostEnvironment = environment;
		}

		//[Authorize]
		[Route("GetBIFCount/")]
		[HttpGet]
		public ActionResult<StatusCounterDTO> GetBIFCount()
		{
			try
			{
				var entry = _repository3.GetBIFStatusCount();

				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									  "No Information not found");
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
		[Route("GetSIFCount/")]
		[HttpGet]
		public ActionResult<StatusCounterDTO> GetSIFCount()
		{
			try
			{
				var entry = _repository4.GetSIFStatusCount();

				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									  "No Information not found");
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
		[Route("GetCustomerCount")]
		[HttpGet]
		public ActionResult<StatusCounterDTO> GetCustomerCount()
		{
			try
			{
				var entry = _repository5.GetCustomerStatusCount();

				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									  "No Information not found");
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
		[Route("GetFxTransactionCount/{date}")]
		[HttpGet]
		public ActionResult<StatusCounterSameDayDTO> GetFxTransactionCount(string date)
		{
			try
			{
				var entry = _repository1.GetFxTransactionStatusCount(date);

				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									  "No Information not found");
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
		[Route("GetFxDeliveryCount/{date}")]
		[HttpGet]
		public ActionResult<StatusCounterDTO> GetFxDeliveryCount(string date)
		{
			try
			{
				var entry = _repository2.GetFxDeliveriesStatusCount(date);

				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									  "No Information not found");
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
		[Route("GetMoneyMarketCount/{date}")]
		[HttpGet]
		public ActionResult<StatusCounterSameDayDTO> GetMoneyMarketCount(string date)
		{
			try
			{
				var entry = _repository6.GetMMTicketStatusCount(date);

				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									  "No Information not found");
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
		[Route("GetPaymentControlCount/{date}")]
		[HttpGet]
		public ActionResult<StatusCounterSameDayDTO> GetPaymentControlCount(string date)
		{
			try
			{
				var entry = _repository7.GetPaymentControlStatusCount(date);

				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									  "No Information not found");
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
		[Route("GetDocumentCount/{date}")]
		[HttpGet]
		public ActionResult<StatusCounterSameDayDTO> GetDocumentCount(string date)
		{
			try
			{
				var entry = _repository8.GetDocumentStatusCount(date);

				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									  "No Information not found");
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
        [Route("GetDistributionsCount/{date}")]
		[HttpGet]
		public ActionResult<StatusCounterDTO> GetDistributionsCount(string date)
		{
			try
			{
				var entry = _repository9.GetDistributionsStatusCount(date);

				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									  "No Information not found");
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
        [Route("GetDomesticClearingCount/{date}")]
		[HttpGet]
		public ActionResult<StatusCounterDTO> GetDomesticClearingCount(string date)
		{
			try
			{
				var entry = _repository10.GetDomesticClearingStatusCount(date);

				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  -
					return StatusCode(StatusCodes.Status404NotFound,
									  "No Information not found");
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
        [Route("GetFXConfirmationCount/{date}")]
        [HttpGet]
        public ActionResult<StatusCounterSameDayDTO> GetFXConfirmationCount(string date)
        {
            try
            {
                var entry = _repository11.CountFxConfirmationStatus(date);

                if (entry != null)
                {
                    // HTTP/1.1 200 OK 
                    return Ok(entry);
                }
                else
                {
                    // HTTP/1.1 404 Not found  
                    return StatusCode(StatusCodes.Status404NotFound,
                                      "No Information not found");
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
        [Route("CountFxUnconfirmatedStatus/{date}")]
		[HttpGet]
		public ActionResult<StatusCounterSameDayDTO> CountFxUnconfirmatedStatus(string date)
		{
			try
			{
				var entry = _repository11.CountFxUnconfirmatedStatus(date);

				if (entry != null)
				{
					// HTTP/1.1 200 OK 
					return Ok(entry);
				}
				else
				{
					// HTTP/1.1 404 Not found  
					return StatusCode(StatusCodes.Status404NotFound,
									  "No Information not found");
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
