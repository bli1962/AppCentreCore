using System;
using MSMQ.Messaging;
using mhcb.Syd.Models;
using mhcb.Syd.Business.Repository.RATES;
using Microsoft.Extensions.Logging;

namespace mhcb.Syd.Business.Repository.Message
{
	public class MessageQueueBase
	{
		//private readonly IConfiguration _configuration;
		private readonly ILogger<RatesMessageRepository> _logger;
		public MessageQueueBase(ILogger<RatesMessageRepository> logger)
		{ 
			this._logger = logger;
		}

		public bool SendIndividualMessage(MessageDTO messageDto, string[] strArrMessages)
		{
			bool blnSuccessSendMessage = true;

			for (int i = 0; i <= strArrMessages.Length - 1; i++)
			{
				try
				{
					messageDto.appSpecificValue = 0;

					_logger.LogDebug(String.Format("Begin of sending message {0} to Queue {1}.", strArrMessages, messageDto.SentTo));

					blnSuccessSendMessage = blnSuccessSendMessage & SendingMessageToQueue(messageDto, strArrMessages[i]);

					_logger.LogDebug(String.Format("End of sending message  {0} to Queue {1}.", strArrMessages, messageDto.SentTo));
				}
				catch (Exception ex)
				{
					_logger.LogError(String.Format("Failed to send message {0} to Queue {1}. Error Message: {2}",
														strArrMessages,
														messageDto.SentTo,
														ex.ToString()));
					SendMessageFailed(messageDto);
					blnSuccessSendMessage = false;
				}
			}
			return blnSuccessSendMessage;
		}

		public Boolean SendingMessageToQueue(MessageDTO messageDto, string stMessage)
		{
			if (string.IsNullOrEmpty(messageDto.QueuePath))
			{
				_logger.LogError(String.Format("Failed to send message {0} to Queue {1}. Error Message: {2}",
										  stMessage, messageDto.SentTo, "Message Queue Path value is empty."));
				return false;
			}

			if (!MessageQueue.Exists(messageDto.QueuePath))
			{
				MessageQueue.ClearConnectionCache();
				if (!MessageQueue.Exists(messageDto.QueuePath))
				{
					_logger.LogError(String.Format("Failed to send message {0} to Queue {1}. Error Message: {2}",
											stMessage, messageDto.SentTo, "Message Queue Path is not exist."));
					return false;
				}
			}

			try
			{
				using (var oMessage = new MSMQ.Messaging.Message())
				{
					oMessage.Formatter = new ActiveXMessageFormatter();

					if (messageDto.appSpecificValue.HasValue)
					{
						oMessage.AppSpecific = messageDto.appSpecificValue.Value;
					}

					oMessage.Body = stMessage;		// messageDto.MsgBody;
					oMessage.Label = stMessage;		// messageDto.MsgLabel;
					oMessage.Priority = MessagePriority.Normal;

					using (var oMessageQueue = new MessageQueue(messageDto.QueuePath))
					{
						oMessageQueue.Send(oMessage);
						oMessageQueue.Close();
					}
					_logger.LogInformation(String.Format("Successfully send message {0} to Queue {1}.", stMessage, messageDto.SentTo));

					return true;
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(String.Format("Failed to send message {0} to Queue {1}. Error Message: {2}",
										stMessage,messageDto.SentTo, ex.ToString()));
				return false;
			}
		}

		
		public bool SendMessageFailed(MessageDTO messageDto)
		{
			Boolean blnRtn = false;
			try
			{
				//var ratesSearchDto = new RatesSearchCriteriaDTO();
				var ratesUploadCtrl = new RatesUploadCtrl
				{
					BranchNo = messageDto.BranchNo,
					OperatedDate = DateTime.Today,
					InputStatus = messageDto.Status
				};

				switch (messageDto.SentTo)
				{
					//case (int)GIPMSMQ.SIF:
					//	var criteriaDTO1 = new SIFSearchCriterialDTO
					//	{
					//		SIFIds = new List<string>(messageDto.IDs.Split(',')),
					//		Status = messageDto.Status,
					//		UserID = messageDto.UserId
					//	};
					//	blnRtn = new SETTLEMENT_INF_BusSev().UpdateSifStatus(criteriaDTO1);
					//	break;
					//case (int)GIPMSMQ.BIF:
					//	var criteriaDTO2 = new BIFSearchCriterialDTO
					//	{
					//		SwiftIDs = new List<string>(messageDto.IDs.Split(',')),
					//		BranchNo = messageDto.BranchNo,
					//		Status = messageDto.Status,
					//		UserID = messageDto.UserId
					//	};
					//	blnRtn = new BANK_INF_BusSev().UpdateBankInfStatus(criteriaDTO2);
					//	break;
					//case (int)GIPMSMQ.FXTransaction:
					//	{
					//		var criteriaDto = new FXTransactionCriteriaDTO
					//		{
					//			REF_NOs = new List<string>(messageDto.IDs.Split(',')),
					//			Status = messageDto.Status,
					//			UserId = messageDto.UserId
					//		};
					//		blnRtn = new ForeignExchangeBusSev().UpdateFxTransactionStatus(criteriaDto);
					//	}
					//	break;
					//case (int)GIPMSMQ.FXDelivery:
					//	{
					//		var criteriaDto = new FXTransactionCriteriaDTO
					//		{
					//			REF_NOs = new List<string>(messageDto.IDs.Split(',')),
					//			Status = messageDto.Status,
					//			UserId = messageDto.UserId
					//		};

					//		blnRtn = new ForeignExchangeBusSev().UpdateFxSettlementInfStatus(criteriaDto);
					//	}
					//	break;
					//case (int)GIPMSMQ.SAP:
					//	blnRtn = true;
					//	break;
					case QueueTypes.FX_RATE:                //(int)GIPMSMQ.RatesSpot:
						//var ratesSearchDto1 = new RatesSearchCriteriaDTO
						//{
						//	BranchNo = messageDto.BranchNo,
						//	RateType = "FX_RATE",
						//	OperatedDate = DateTime.Today,
						//	InputStatus = messageDto.Status
						//};
						ratesUploadCtrl.RateType = RateTypes.FX_RATE;	// "FX_RATE";
						blnRtn = new RatesGbaseUploadCtlRepository().UpdateRatesGbaseUploadCtlStatus(ratesUploadCtrl);
						break;
					case QueueTypes.REVALUATION_RATE:   //(int)GIPMSMQ.RatesRevaluation:
						//var ratesSearchDto2 = new RatesSearchCriteriaDTO
						//{
						//	BranchNo = messageDto.BranchNo,
						//	RateType = "REVALUATION_RATE",
						//	OperatedDate = DateTime.Today,
						//	InputStatus = messageDto.Status
						//};
						ratesUploadCtrl.RateType = RateTypes.REVALUATION_RATE;    //"REVALUATION_RATE";
						blnRtn = new RatesGbaseUploadCtlRepository().UpdateRatesGbaseUploadCtlStatus(ratesUploadCtrl);
						break;
					case QueueTypes.SWAP_RATE:			//(int)GIPMSMQ.RatesSwap:
						//var ratesSearchDto3 = new RatesSearchCriteriaDTO
						//{
						//	BranchNo = messageDto.BranchNo,
						//	RateType = "SWAP_RATE",
						//	OperatedDate = DateTime.Today,
						//	InputStatus = messageDto.Status
						//};
						ratesUploadCtrl.RateType = RateTypes.SWAP_RATE;    //"SWAP_RATE";
						blnRtn = new RatesGbaseUploadCtlRepository().UpdateRatesGbaseUploadCtlStatus(ratesUploadCtrl);
						break;
					case QueueTypes.DEPOSITS_RATE:		//(int)GIPMSMQ.RatesFunding:
						//var ratesSearchDto4 = new RatesSearchCriteriaDTO
						//{
						//	BranchNo = messageDto.BranchNo,
						//	RateType = "DEPOSITS_RATE",
						//	OperatedDate = DateTime.Today,
						//	InputStatus = messageDto.Status
						//};
						ratesUploadCtrl.RateType = RateTypes.DEPOSITS_RATE;    //"DEPOSITS_RATE";
						blnRtn = new RatesGbaseUploadCtlRepository().UpdateRatesGbaseUploadCtlStatus(ratesUploadCtrl);
						break;
					case QueueTypes.BIS_RATE:			//(int)GIPMSMQ.RatesBIS:
						//var ratesSearchDto5 = new RatesSearchCriteriaDTO()
						//{
						//	BranchNo = messageDto.BranchNo,
						//	RateType = "BIS_RATE",
						//	OperatedDate = DateTime.Today,
						//	InputStatus = messageDto.Status
						//};
						ratesUploadCtrl.RateType = RateTypes.BIS_RATE;    //"BIS_RATE";
						blnRtn = new RatesGbaseUploadCtlRepository().UpdateRatesGbaseUploadCtlStatus(ratesUploadCtrl);
						break;
					default:
						break;
				}
				return blnRtn;
			}
			catch (Exception)
			{
				return false;
			}
		}

		//public string FormatMsg(string name, string ids, string err)
		//{
		//	string result = "Class/Method:" + "\r\n";
		//	result += name + "\r\n" + "\r\n";
		//	result += "Message:" + "\r\n";
		//	result += ids + "\r\n" + "\r\n";
		//	result += "Error Message:" + "\r\n";
		//	result += err;
		//	return result;
		//}

		//public string FormatMsg(string name, string ids)
		//{
		//	const string err = "";
		//	string result = "Class/Method:" + "\r\n";
		//	result += name + "\r\n" + "\r\n";
		//	result += "Message:" + "\r\n";
		//	result += ids + "\r\n" + "\r\n";
		//	result += "Error Message:" + "\r\n";
		//	result += err;
		//	return result;
		//}

	}
}



