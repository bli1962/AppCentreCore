using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace mhcb.Syd.Business.Repository.Message
{
    public class RatesMessageRepository : MessageQueueBase, IRatesMessage
    {
        private readonly GUIDEDbContext _appDbContext;
        private readonly IConfiguration _configuration;
        private readonly ILogger<RatesMessageRepository> _logger;

        private readonly string _mqServerName;
        private readonly string _mqName;

        private readonly string _modeQueue;
        private readonly string _modeAll;
        private readonly string _mqPath;

        public RatesMessageRepository(ILogger<RatesMessageRepository> logger,
                                    IConfiguration configuration,
                                    GUIDEDbContext appDbContext) : base(logger)
        {
            this._logger = logger;
            this._appDbContext = appDbContext;
            this._configuration = configuration;

            _mqServerName = _configuration["MSMQ:queueServerName"];
            _mqName = _configuration["MSMQ:RatesUploadQueue"];
            _modeAll = _configuration["MSMQ:AllUploadMode"];
            _modeQueue = _configuration["MSMQ:RatesUploadMode"];

            _mqPath = GetQueuePath(_mqServerName, _mqName);
        }

        public string GetQueuePath(string queueServerName, string queueName)
        {
            if ((queueServerName != "."))
            {
                string[] str = queueName.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                if (str.Length == 1)
                {
                    return queueServerName + "\\" + queueName;
                }
                return queueServerName + "\\" + str[1];
            }
            else
            {
                return queueServerName + "\\Private$\\" + queueName;
            }
        }

        public bool AllowToSend(string queueName)
        {
            //log.DebugFormat("AllowToSend: QueueName={0}", queueName);
            try
            {
                if (_modeAll == "1")
                {
                    return true;
                }
                return (_modeQueue == "1");
            }
            catch 
            {
                return false;
            }
        }

        // ** Reference in Web config file
        //<add key="QueueServerName" value="MIZBAPT01" />
        //<add key="CustomerQueue" value="CustomerQueue" />
        //<add key="BIFQueue" value="BIFQueue" />
        //<add key="SIFQueue" value="SSIQueue" />
        //<add key="FXTransactionQueue" value="FXTransQueue" />
        //<add key="RatesUploadQueue" value="RatesUpload" />
        //<add key="UsersQueue" value="User" />
        public string PrepareMessagesToQueue(MessageDTO messageDto)
        {
            string strMessage = string.Empty;

            messageDto.QueueServerName = _mqServerName;
            messageDto.QueueName = _mqName;
            messageDto.QueuePath = _mqPath;

            try
            {
                switch (messageDto.SentTo)
                {
                    case QueueTypes.SAP:  //(int)GIPMSMQ.SAP:
                                          //if (AllowToSend(messageDto.QueueName))
                                          //{
                                          //	strMessage = string.Format("${0}", messageDto.IDs);
                                          //}
                        break;
                    case QueueTypes.SIF: // (int)GIPMSMQ.SIF:
                                         //if (AllowToSend(messageDto.QueueName))
                                         //{
                                         //	strMessage = new MessageComposer().GetSettlementMessage(messageDto);
                                         //}
                        break;
                    case QueueTypes.BIF:  // (int)GIPMSMQ.BIF:
                                          //if (AllowToSend(messageDto.QueueName))
                                          //{
                                          //	strMessage = new MessageComposer().GetBankInfMessage(messageDto);
                                          //}
                        break;
                    case QueueTypes.FXTransaction:   //(int)GIPMSMQ.FXTransaction:
                                            //if (AllowToSend(messageDto.QueueName))
                                            //{
                                            //	strMessage = new MessageComposer().GetFxTransactionMessage(messageDto);
                                            //}
                        break;
                    case QueueTypes.FXDelivery:      //(int)GIPMSMQ.FXDelivery:
                                        //if (AllowToSend(messageDto.QueueName))
                                        //{
                                        //	strMessage = new MessageComposer().GetFxSettlementInfMessage(messageDto);
                                        //}
                        break;
                    case QueueTypes.FX_RATE:             //(int)GIPMSMQ.RatesSpot:
                    case QueueTypes.REVALUATION_RATE:    //(int)GIPMSMQ.RatesRevaluation:
                    case QueueTypes.SWAP_RATE:           //(int)GIPMSMQ.RatesSwap:
                    case QueueTypes.DEPOSITS_RATE:       //(int)GIPMSMQ.RatesFunding:
                    case QueueTypes.BIS_RATE:            // (int)GIPMSMQ.RatesBIS:
                        if (AllowToSend(messageDto.QueueName))
                        {
                            //strMessage = new MessageComposer().GetRatesMessage(messageDto);
                            strMessage = GetRatesMessageV3(messageDto);
                        }
                        break;
                    default:
                        strMessage = ""; break;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(String.Format("Failed to prepare message to Queue {0}. Error Message: {1}",
                    messageDto.SentTo, ex.ToString()));
                return ex.ToString();
            }

            if (string.IsNullOrEmpty(strMessage))
            {
                _logger.LogWarning(String.Format("Failed to prepare message to Queue {0}. Error Message: {1}",
                    messageDto.SentTo, "Empty Message found."));
                return "Not Found";
            }
            else
            {
                string[] arrMessages = strMessage.Split(new[] { '~' });
                _logger.LogInformation("Rates {0} Messages Have Been Generated now - {1}", messageDto.SentTo, arrMessages.ToList());

                bool blnSuccessSent = SendIndividualMessage(messageDto, arrMessages);
                return blnSuccessSent ? "OK" : "Failed";
            }
        }


        #region Rates
        // Created by B.Li
        // It was done via Stored procedure - dbo.USP_GUIDE_RATES_UPLOAD_MESSAGE
        public string GetRatesMessage(MessageDTO messageDto)
        {
            string strRatesMsg = "";

            int intHave751InitialInput = 0;
            int intHave784InitialInput = 0;

            string strRatesType = "";
            string strMessageRatesType = "";

            //Int32 intSentTo = messageDto.SentTo;
            QueueTypes intSentTo = messageDto.SentTo;
            DateTime dtTodayDate = messageDto.SysToday;

            if (intSentTo == QueueTypes.FX_RATE)
            {
                strRatesType = "FX_RATE";
                strMessageRatesType = "FX";
            }
            else if (intSentTo == QueueTypes.REVALUATION_RATE)
            {
                strRatesType = "REVALUATION_RATE";
                strMessageRatesType = "REVALUATION";
            }
            else if (intSentTo == QueueTypes.SWAP_RATE)
            {
                strRatesType = "SWAP_RATE";
                strMessageRatesType = "SWAP";
            }
            else if (intSentTo == QueueTypes.DEPOSITS_RATE)
            {
                strRatesType = "DEPOSITS_RATE";
                strMessageRatesType = "DEPOSITS";
            }
            else if (intSentTo == QueueTypes.BIS_RATE)
            {
                strRatesType = "BIS_RATE";
                strMessageRatesType = "BIS";

                var query1 = (from a in _appDbContext.RatesGbaseUploadCtls
                                .Where(x => x.RateType == strRatesType)
                                .Where(x => EF.Functions.DateDiffMonth(x.OprDate, dtTodayDate) == 0)
                              select a).FirstOrDefault();

                if (query1 != null)
                {
                    dtTodayDate = query1.OprDate;
                }
            }

            //log.DebugFormat(string.Format("GetRatesMessage: Rate Type={0}", strRatesType));
            //guideContext.Database.Log = s => log.DebugFormat("EF6 SQL Logging ={0}", s);

            var RateUpload = (from a in _appDbContext.RatesGbaseUploadCtls
                                  .Where(x => x.RateType == strRatesType)
                                  .Where(x => EF.Functions.DateDiffDay(x.OprDate, dtTodayDate) == 0)
                              select a).ToList();

            // looping by ccy of uploadControls
            foreach (RatesGbaseUploadCtl _rateUpload in RateUpload)
            {
                string strOprDate = _rateUpload.OprDate.ToString("dd-MMM-yyyy");
                string strCcy = _rateUpload.Ccy;
                string strUploadBy = _rateUpload.UploadedBy ?? "";

                string strAcuTransStatus = _rateUpload.AcuTransStatus;
                string strBuTransStatus = _rateUpload.BuStatus;

                var _rateCriteria = (from b in _appDbContext.RatesGbaseUploadCriteria
                                        .Where(x => x.RateType == strRatesType)
                                        .Where(x => x.Ccy == strCcy)
                                     select b).FirstOrDefault();

                //--Flag value defination
                //--ACU_XXX for 751
                //--BU_XXX for 784

                // To create the corresponding GIP if it is defined in Criteria table
                if (_rateCriteria != null)
                {
                    string strHaveAcu = _rateCriteria.AcuFlag ?? "";
                    string strHaveBu = _rateCriteria.BuFlag ?? "";

                    string strOperationKind = "";
                    string strBranchNo751 = "";
                    string strBranchNo784 = "";

                    if (strHaveAcu == "Y")
                    {
                        strOperationKind = strAcuTransStatus == "Y" ? "M" : "I";

                        // over write OperationKind for FX rate and Bis_rate
                        if (intSentTo == QueueTypes.FX_RATE) strOperationKind = "I";         // ITS ALWAYS INITIAL INPUT FOR FX
                        if (intSentTo == QueueTypes.BIS_RATE) strOperationKind = "M";        // ITS ALWAYS MODif (Y INPUT FOR BIS

                        strBranchNo751 = strOperationKind + "|" + strUploadBy + "|" + "751" + "|";
                    }

                    if (strHaveBu == "Y")
                    {
                        strOperationKind = strBuTransStatus == "Y" ? "M" : "I";

                        // over write OperationKind for FX rate and Bis_rate
                        if (intSentTo == QueueTypes.FX_RATE) strOperationKind = "I";         // ITS ALWAYS INITIAL INPUT FOR FX
                        if (intSentTo == QueueTypes.BIS_RATE) strOperationKind = "M";        // ITS ALWAYS MODif (Y INPUT FOR BIS

                        strBranchNo784 = strOperationKind + "|" + strUploadBy + "|" + "784" + "|";
                    }

                    // Compose Message 
                    if (strBranchNo751 != "" && strOperationKind == "I" && intSentTo == QueueTypes.REVALUATION_RATE)  //"REVALUATION_RATE";					
                    {
                        if (intHave751InitialInput == 0)  // FOR INITIAL INPUT OF REVALUATION RATES, WE ONLY NEED TO S}
                        {
                            // 1 MESSAGE TO REPRESENT ALL CURRENCY INSTEAD OF S}ING A MESSAGE FOR EACH CURRENCY
                            if (strRatesMsg != "") strRatesMsg += "~";

                            strRatesMsg += strMessageRatesType + "|";
                            strRatesMsg += strOprDate + "|";
                            strRatesMsg += "ALL" + "|";
                            strRatesMsg += strBranchNo751;

                            intHave751InitialInput = 1;// IT TO 1 SO THAT WE DO NOT DO THIS BLOCK OF CODE FOR 751 AGAIN
                        }
                    }
                    else if (strBranchNo751 != "" && strOperationKind == "M" && intSentTo == QueueTypes.BIS_RATE)    // "BIS_RATE";					
                    {
                        if (intHave751InitialInput == 0) // FOR INITIAL INPUT OF REVALUATION RATES, WE ONLY NEED TO S}
                        {
                            // 1 MESSAGE TO REPRESENT ALL CURRENCY INSTEAD OF S}ING A MESSAGE FOR EACH CURRENCY
                            if (strRatesMsg != "") strRatesMsg += "~";

                            strRatesMsg += strMessageRatesType + "|";
                            strRatesMsg += strOprDate + "|";
                            strRatesMsg += "ALL" + "|";
                            strRatesMsg += strBranchNo751;

                            intHave751InitialInput = 1; // IT TO 1 SO THAT WE DO NOT DO THIS BLOCK OF CODE FOR 751 AGAIN
                        }
                    }
                    else if (strBranchNo751 != "")
                    {
                        if (strRatesMsg != "") strRatesMsg += "~";

                        strRatesMsg += strMessageRatesType + "|";
                        strRatesMsg += strOprDate + "|";
                        strRatesMsg += strCcy + "|";
                        strRatesMsg += strBranchNo751;
                    }


                    // WE WILL ONLY DO THIS if ( ITS 784 AND IT ISS REVALUATION RATES
                    if (strBranchNo784 != "" && strOperationKind == "I" && intSentTo == QueueTypes.REVALUATION_RATE)  //"REVALUATION_RATE";
                    {
                        if (intHave784InitialInput == 0) // FOR INITIAL INPUT OF REVALUATION RATES, WE ONLY NEED TO S}
                        {
                            // 1 MESSAGE TO REPRESENT ALL CURRENCY INSTEAD OF S}ING A MESSAGE FOR EACH CURRENCY
                            if (strRatesMsg != "") strRatesMsg += "~";

                            strRatesMsg += strMessageRatesType + "|";
                            strRatesMsg += strOprDate + "|";
                            strRatesMsg += "ALL" + "|";
                            strRatesMsg += strBranchNo784;

                            intHave784InitialInput = 1;// IT TO 1 SO THAT WE DO NOT DO THIS BLOCK OF CODE FOR 784  AGAIN
                        }
                    }


                    // WE WILL ONLY DO THIS if ( ITS 784 AND IT IS BIS RATES
                    if (strBranchNo784 != "" && strOperationKind == "M" && intSentTo == QueueTypes.BIS_RATE)
                    {
                        if (intHave784InitialInput == 0) // FOR INITIAL INPUT OF REVALUATION RATES, WE ONLY NEED TO S}
                        {                  // 1 MESSAGE TO REPRESENT ALL CURRENCY INSTEAD OF S}ING A MESSAGE FOR EACH CURRENCY
                            if (strRatesMsg != "") strRatesMsg += "~";

                            strRatesMsg += strMessageRatesType + "|";
                            strRatesMsg += strOprDate + "|";
                            strRatesMsg += "ALL" + "|";
                            strRatesMsg += strBranchNo784;

                            intHave784InitialInput = 1; // IT TO 1 SO THAT WE DO NOT DO THIS BLOCK OF CODE FOR 784  AGAIN
                        }
                    }
                    else if (strBranchNo784 != "")
                    {
                        if (strRatesMsg != "") strRatesMsg += "~";

                        strRatesMsg += strMessageRatesType + "|";
                        strRatesMsg += strOprDate + "|";
                        strRatesMsg += strCcy + "|";
                        strRatesMsg += strBranchNo784;
                    }
                }
            }

            //log.DebugFormat(string.Format("GetRatesMessage: GIP Messages ={0}", strRatesMsg));
            return strRatesMsg;
        }


        public string GetRatesMessageV2(MessageDTO messageDto)
        {
            string strRatesMsg751 = "";
            string strRatesMsg784 = "";

            int intHave751InitialInput = 0;
            int intHave784InitialInput = 0;

            string strRatesType = "";
            string strMessageRatesType = "";

            //Int32 intSentTo = messageDto.SentTo;
            QueueTypes intSentTo = messageDto.SentTo;
            DateTime dtTodayDate = messageDto.SysToday;

            if (intSentTo == QueueTypes.FX_RATE)
            {
                strRatesType = "FX_RATE";
                strMessageRatesType = "FX";
            }
            else if (intSentTo == QueueTypes.REVALUATION_RATE)
            {
                strRatesType = "REVALUATION_RATE";
                strMessageRatesType = "REVALUATION";
            }
            else if (intSentTo == QueueTypes.SWAP_RATE)
            {
                strRatesType = "SWAP_RATE";
                strMessageRatesType = "SWAP";
            }
            else if (intSentTo == QueueTypes.DEPOSITS_RATE)
            {
                strRatesType = "DEPOSITS_RATE";
                strMessageRatesType = "DEPOSITS";
            }
            else if (intSentTo == QueueTypes.BIS_RATE)
            {
                strRatesType = "BIS_RATE";
                strMessageRatesType = "BIS";

                var query1 = (from a in _appDbContext.RatesGbaseUploadCtls
                                .Where(x => x.RateType == strRatesType)
                                .Where(x => EF.Functions.DateDiffMonth(x.OprDate, dtTodayDate) == 0)
                              select a).FirstOrDefault();

                if (query1 != null)
                {
                    dtTodayDate = query1.OprDate;
                }
            }

            //log.DebugFormat(string.Format("GetRatesMessage: Rate Type={0}", strRatesType));
            //guideContext.Database.Log = s => log.DebugFormat("EF6 SQL Logging ={0}", s);

            var rateCriteria751 = (from b in _appDbContext.RatesGbaseUploadCriteria
                                   join c in _appDbContext.RatesGbaseUploadCtls
                                   on new { b.RateType, b.Ccy } equals new { c.RateType, c.Ccy }
                                   where (c.RateType == strRatesType)
                                         && (EF.Functions.DateDiffDay(c.OprDate, dtTodayDate) == 0)
                                         && (b.AcuFlag == "Y")
                                   select new
                                   {
                                       b.RateType,
                                       b.CriteriaType,
                                       b.AcuFlag,
                                       b.BuFlag,

                                       c.OprDate,
                                       c.UploadedBy,
                                       c.Ccy,
                                       c.AcuTransStatus,
                                       c.BuTransStatus,
                                   })
                                .ToList();

            var rateCriteria748 = (from b in _appDbContext.RatesGbaseUploadCriteria
                                   join c in _appDbContext.RatesGbaseUploadCtls
                                   on new { b.RateType, b.Ccy } equals new { c.RateType, c.Ccy }
                                   where (c.RateType == strRatesType)
                                         && (EF.Functions.DateDiffDay(c.OprDate, dtTodayDate) == 0)
                                         && (b.BuFlag == "Y")
                                   select new
                                   {
                                       b.RateType,
                                       b.CriteriaType,
                                       b.AcuFlag,
                                       b.BuFlag,

                                       c.OprDate,
                                       c.UploadedBy,
                                       c.Ccy,
                                       c.AcuTransStatus,
                                       c.BuTransStatus,
                                   })
                                .ToList();

            //SELECT TOP(1000) b.[RATE_TYPE]
            //      ,b.[CCY]
            //      ,b.[CRITERIA_TYPE]
            //      ,b.[ACU_FLAG]
            //      ,b.[BU_FLAG]
            //	  ,c.OPR_DATE
            //	  ,c.UPLOADED_BY
            //	  ,c.[ACU_TRANS_STATUS]
            //      ,c.[BU_TRANS_STATUS]
            //  FROM[GUIDE].[dbo].[RATES_GBASE_UPLOAD_CRITERIA] b
            //  Inner join[GUIDE].[dbo].[RATES_GBASE_UPLOAD_CTL] c
            //  on b.CCY = c.CCY and b.RATE_TYPE = c.RATE_TYPE
            //  where b.RATE_TYPE = 'FX_RATE'
            //  and DateDiff(DAY, c.OPR_DATE, '2020-05-19 00:00:00.000') = 0


            // looping by ccy type
            foreach (var _rateCriteria in rateCriteria751)
            {
                string strOprDate = _rateCriteria.OprDate.ToString("dd-MMM-yyyy");
                string strCcy = _rateCriteria.Ccy;
                string strUploadBy = _rateCriteria.UploadedBy ?? "";
                string strAcuTransStatus = _rateCriteria.AcuTransStatus;
                //string strBuTransStatus = _rateCriteria.BuTransStatus;

                //--Flag value defination
                //--ACU_XXX for 751
                //--BU_XXX for 784

                //string strHaveAcu = _rateCriteria.AcuFlag ?? "";
                //string strHaveBu = _rateCriteria.BuFlag ?? "";

                string strOperationKind = "";
                string strMessageSuffix751 = "";
                //string strBranchNo784 = "";

                //if (strHaveAcu == "Y")
                //{
                strOperationKind = strAcuTransStatus == "Y" ? "M" : "I";

                // Overwrite OperationKind for FX rate and Bis_rate
                if (intSentTo == QueueTypes.FX_RATE) strOperationKind = "I";         // ITS ALWAYS INITIAL INPUT FOR FX
                if (intSentTo == QueueTypes.BIS_RATE) strOperationKind = "M";        // ITS ALWAYS MODif (Y INPUT FOR BIS

                strMessageSuffix751 = strOperationKind + "|" + strUploadBy + "|" + "751" + "|";
                //}


                // Compose Message 
                // WE WILL ONLY DO THIS if ( IT'S 751 AND IT IS REVALUATION RATES)
                if (strMessageSuffix751 != "" && strOperationKind == "I" && intSentTo == QueueTypes.REVALUATION_RATE)  //"REVALUATION_RATE";					
                {
                    if (intHave751InitialInput == 0)  // FOR INITIAL INPUT OF REVALUATION RATES, WE ONLY NEED TO S}
                    {
                        // 1 MESSAGE TO REPRESENT ALL CURRENCY INSTEAD OF S}ING A MESSAGE FOR EACH CURRENCY
                        if (strRatesMsg751 != "") strRatesMsg751 += "~";

                        strRatesMsg751 += strMessageRatesType + "|";
                        strRatesMsg751 += strOprDate + "|";
                        strRatesMsg751 += "ALL" + "|";
                        strRatesMsg751 += strMessageSuffix751;

                        intHave751InitialInput = 1;// IT TO 1 SO THAT WE DO NOT DO THIS BLOCK OF CODE FOR 751 AGAIN
                    }
                }
                // WE WILL ONLY DO THIS if ( ITS 751 AND IT IS BIS RATES
                else if (strMessageSuffix751 != "" && strOperationKind == "M" && intSentTo == QueueTypes.BIS_RATE)    // "BIS_RATE";					
                {
                    if (intHave751InitialInput == 0) // FOR INITIAL INPUT OF REVALUATION RATES, WE ONLY NEED TO S}
                    {
                        // 1 MESSAGE TO REPRESENT ALL CURRENCY INSTEAD OF S}ING A MESSAGE FOR EACH CURRENCY
                        if (strRatesMsg751 != "") strRatesMsg751 += "~";

                        strRatesMsg751 += strMessageRatesType + "|";
                        strRatesMsg751 += strOprDate + "|";
                        strRatesMsg751 += "ALL" + "|";
                        strRatesMsg751 += strMessageSuffix751;

                        intHave751InitialInput = 1; // IT TO 1 SO THAT WE DO NOT DO THIS BLOCK OF CODE FOR 751 AGAIN
                    }
                }
                else if (strMessageSuffix751 != "")
                {
                    if (strRatesMsg751 != "") strRatesMsg751 += "~";

                    strRatesMsg751 += strMessageRatesType + "|";
                    strRatesMsg751 += strOprDate + "|";
                    strRatesMsg751 += strCcy + "|";
                    strRatesMsg751 += strMessageSuffix751;
                }
            }

            foreach (var _rateCriteria in rateCriteria748)
            {
                string strOprDate = _rateCriteria.OprDate.ToString("dd-MMM-yyyy");
                string strCcy = _rateCriteria.Ccy;
                string strUploadBy = _rateCriteria.UploadedBy ?? "";
                //string strAcuTransStatus = _rateCriteria.AcuTransStatus;
                string strBuTransStatus = _rateCriteria.BuTransStatus;

                //--Flag value defination
                //--ACU_XXX for 751
                //--BU_XXX for 784

                //string strHaveAcu = _rateCriteria.AcuFlag ?? "";
                //string strHaveBu = _rateCriteria.BuFlag ?? "";

                string strOperationKind = "";
                //string strBranchNo751 = "";
                string strMessageSuffix784 = "";

                //if (strHaveBu == "Y")
                //{
                strOperationKind = strBuTransStatus == "Y" ? "M" : "I";

                // over write OperationKind for FX rate and Bis_rate
                if (intSentTo == QueueTypes.FX_RATE) strOperationKind = "I";         // ITS ALWAYS INITIAL INPUT FOR FX
                if (intSentTo == QueueTypes.BIS_RATE) strOperationKind = "M";        // ITS ALWAYS MODif (Y INPUT FOR BIS

                strMessageSuffix784 = strOperationKind + "|" + strUploadBy + "|" + "784" + "|";
                //}


                // WE WILL ONLY DO THIS if ( ITS 784 AND IT ISS REVALUATION RATES
                if (strMessageSuffix784 != "" && strOperationKind == "I" && intSentTo == QueueTypes.REVALUATION_RATE)  //"REVALUATION_RATE";
                {
                    if (intHave784InitialInput == 0) // FOR INITIAL INPUT OF REVALUATION RATES, WE ONLY NEED TO S}
                    {
                        // 1 MESSAGE TO REPRESENT ALL CURRENCY INSTEAD OF S}ING A MESSAGE FOR EACH CURRENCY
                        if (strRatesMsg784 != "") strRatesMsg784 += "~";

                        strRatesMsg784 += strMessageRatesType + "|";
                        strRatesMsg784 += strOprDate + "|";
                        strRatesMsg784 += "ALL" + "|";
                        strRatesMsg784 += strMessageSuffix784;

                        intHave784InitialInput = 1;// IT TO 1 SO THAT WE DO NOT DO THIS BLOCK OF CODE FOR 784  AGAIN
                    }
                }

                // WE WILL ONLY DO THIS if ( ITS 784 AND IT IS BIS RATES
                if (strMessageSuffix784 != "" && strOperationKind == "M" && intSentTo == QueueTypes.BIS_RATE)
                {
                    if (intHave784InitialInput == 0) // FOR INITIAL INPUT OF REVALUATION RATES, WE ONLY NEED TO S}
                    {                  // 1 MESSAGE TO REPRESENT ALL CURRENCY INSTEAD OF S}ING A MESSAGE FOR EACH CURRENCY
                        if (strRatesMsg784 != "") strRatesMsg784 += "~";

                        strRatesMsg784 += strMessageRatesType + "|";
                        strRatesMsg784 += strOprDate + "|";
                        strRatesMsg784 += "ALL" + "|";
                        strRatesMsg784 += strMessageSuffix784;

                        intHave784InitialInput = 1; // IT TO 1 SO THAT WE DO NOT DO THIS BLOCK OF CODE FOR 784  AGAIN
                    }
                }
                else if (strMessageSuffix784 != "")
                {
                    if (strRatesMsg784 != "") strRatesMsg784 += "~";

                    strRatesMsg784 += strMessageRatesType + "|";
                    strRatesMsg784 += strOprDate + "|";
                    strRatesMsg784 += strCcy + "|";
                    strRatesMsg784 += strMessageSuffix784;
                }
            }

            //log.DebugFormat(string.Format("GetRatesMessage: GIP Messages ={0}", strRatesMsg));
            if (strRatesMsg751 != "")
                strRatesMsg751 += "~" + strRatesMsg784;
            else
                strRatesMsg751 = strRatesMsg784;

            return strRatesMsg751;
        }


        public string GetRatesMessageV3(MessageDTO messageDto)
        {
            string strRatesMsg751 = "";
            string strRatesMsg784 = "";

            int intHave751InitialInput = 0;
            int intHave784InitialInput = 0;

            string strRatesType = "";
            string strMessageRatesType = "";

            //Int32 intSentTo = messageDto.SentTo;
            QueueTypes intSentTo = messageDto.SentTo;
            DateTime dtTodayDate = messageDto.SysToday;

            if (intSentTo == QueueTypes.FX_RATE)
            {
                strRatesType = "FX_RATE";
                strMessageRatesType = "FX";
            }
            else if (intSentTo == QueueTypes.REVALUATION_RATE)
            {
                strRatesType = "REVALUATION_RATE";
                strMessageRatesType = "REVALUATION";
            }
            else if (intSentTo == QueueTypes.SWAP_RATE)
            {
                strRatesType = "SWAP_RATE";
                strMessageRatesType = "SWAP";
            }
            else if (intSentTo == QueueTypes.DEPOSITS_RATE)
            {
                strRatesType = "DEPOSITS_RATE";
                strMessageRatesType = "DEPOSITS";
            }
            else if (intSentTo == QueueTypes.BIS_RATE)
            {
                strRatesType = "BIS_RATE";
                strMessageRatesType = "BIS";

                //B.li : use control tabel date for upload date
                var query1 = (from a in _appDbContext.RatesGbaseUploadCtls
                                .Where(x => x.RateType == strRatesType)
                                .Where(x => EF.Functions.DateDiffMonth(x.OprDate, dtTodayDate) == 0)
                              select a).FirstOrDefault();

                if (query1 != null)
                {
                    dtTodayDate = query1.OprDate;
                }
            }

            //log.DebugFormat(string.Format("GetRatesMessage: Rate Type={0}", strRatesType));
            //guideContext.Database.Log = s => log.DebugFormat("EF6 SQL Logging ={0}", s);

            var rateCriteria751 = (from b in _appDbContext.RatesGbaseUploadCriteria
                                   join c in _appDbContext.RatesGbaseUploadCtls
                                   on new { b.RateType, b.Ccy } equals new { c.RateType, c.Ccy }
                                   where (c.RateType == strRatesType)
                                         && (EF.Functions.DateDiffDay(c.OprDate, dtTodayDate) == 0)
                                         && (b.AcuFlag == "Y")
                                   select new
                                   {
                                       b.RateType,
                                       b.CriteriaType,
                                       //b.AcuFlag,
                                       //b.BuFlag,

                                       c.OprDate,
                                       c.UploadedBy,
                                       c.Ccy,
                                       c.AcuTransStatus,
                                       c.BuTransStatus,
                                       OperationKind = (
                                            c.RateType == "FX_RATE" ? "I" :
                                            c.RateType == "BIS_RATE" ? "M" :
                                            c.AcuTransStatus == "Y" ? "M" : "I"
                                       )
                                   })
                                .ToList();

            var rateCriteria784 = (from b in _appDbContext.RatesGbaseUploadCriteria
                                   join c in _appDbContext.RatesGbaseUploadCtls
                                   on new { b.RateType, b.Ccy } equals new { c.RateType, c.Ccy }
                                   where (c.RateType == strRatesType)
                                         && (EF.Functions.DateDiffDay(c.OprDate, dtTodayDate) == 0)
                                         && (b.BuFlag == "Y")
                                   select new
                                   {
                                       b.RateType,
                                       b.CriteriaType,
                                       //b.AcuFlag,
                                       //b.BuFlag,

                                       c.OprDate,
                                       c.UploadedBy,
                                       c.Ccy,
                                       c.AcuTransStatus,
                                       c.BuTransStatus,
                                       OperationKind = (
                                            c.RateType == "FX_RATE" ? "I" :
                                            c.RateType == "BIS_RATE" ? "M" :
                                            c.BuTransStatus == "Y" ? "M" : "I"
                                        ),
                                   })
                                .ToList();

            //SELECT TOP(1000) b.[RATE_TYPE]
            //		,b.[CCY]
            //		,b.[CRITERIA_TYPE]
            //		--,b.[ACU_FLAG]
            //		--,b.[BU_FLAG]
            //		,c.OPR_DATE
            //		,c.UPLOADED_BY
            //		,c.[ACU_TRANS_STATUS]
            //		,c.[BU_TRANS_STATUS]
            //		,case 
            //			when c.RATE_TYPE = 'FX_RATE' then 
            //				'I'
            //			when c.RATE_TYPE = 'BIS_RATE' then 
            //				'M'
            //			when c.[ACU_TRANS_STATUS] = 'Y' then 
            //				'M' 
            //		else 
            //			'I'  
            //		end as OperationKind
            //FROM[GUIDE].[dbo].[RATES_GBASE_UPLOAD_CRITERIA] b
            //Inner join[GUIDE].[dbo].[RATES_GBASE_UPLOAD_CTL] c
            //on b.CCY = c.CCY and b.RATE_TYPE = c.RATE_TYPE
            //where b.RATE_TYPE = 'FX_Rate'
            //		and DateDiff(DAY, c.OPR_DATE, '2018-11-30 00:00:00.000') = 0
            //		and b.ACU_FLAG = 'Y'		

            // looping by ccy type
            foreach (var _rateCriteria in rateCriteria751)
            {
                string strOprDate = _rateCriteria.OprDate.ToString("dd-MMM-yyyy");
                string strCcy = _rateCriteria.Ccy;
                string strUploadBy = _rateCriteria.UploadedBy ?? "";

                //string strAcuTransStatus = _rateCriteria.AcuTransStatus;
                //string strBuTransStatus = _rateCriteria.BuTransStatus;

                //--Flag value defination
                //--ACU_XXX for 751
                //--BU_XXX for 784

                //string strHaveAcu = _rateCriteria.AcuFlag ?? "";
                //string strHaveBu = _rateCriteria.BuFlag ?? "";

                string strOperationKind = "";
                string strMessageSuffix751 = "";
                //string strBranchNo784 = "";

                //if (strHaveAcu == "Y")
                //{
                //strOperationKind = strAcuTransStatus == "Y" ? "M" : "I";
                strOperationKind = _rateCriteria.OperationKind;

                // Overwrite OperationKind for FX rate and Bis_rate
                //if (intSentTo == 6) strOperationKind = "I";         // ITS ALWAYS INITIAL INPUT FOR FX
                //if (intSentTo == 10) strOperationKind = "M";        // ITS ALWAYS MODif (Y INPUT FOR BIS

                strMessageSuffix751 = strOperationKind + "|" + strUploadBy + "|" + "751" + "|";
                //}


                // Compose Message 
                // WE WILL ONLY DO THIS if ( IT'S 751 AND IT IS REVALUATION RATES)
                if (strMessageSuffix751 != "" && strOperationKind == "I" && intSentTo == QueueTypes.REVALUATION_RATE)  //"REVALUATION_RATE";					
                {
                    if (intHave751InitialInput == 0)  // FOR INITIAL INPUT OF REVALUATION RATES, WE ONLY NEED TO S}
                    {
                        // 1 MESSAGE TO REPRESENT ALL CURRENCY INSTEAD OF S}ING A MESSAGE FOR EACH CURRENCY
                        if (strRatesMsg751 != "") strRatesMsg751 += "~";

                        strRatesMsg751 += strMessageRatesType + "|";
                        strRatesMsg751 += strOprDate + "|";
                        strRatesMsg751 += "ALL" + "|";
                        strRatesMsg751 += strMessageSuffix751;

                        intHave751InitialInput = 1;  // SET flag TO 1 SO THAT WE DO NOT DO THIS BLOCK OF CODE FOR 751 AGAIN
                    }
                }
                // WE WILL ONLY DO THIS if ( ITS 751 AND IT IS BIS RATES
                else if (strMessageSuffix751 != "" && strOperationKind == "M" && intSentTo == QueueTypes.BIS_RATE)    // "BIS_RATE";					
                {
                    if (intHave751InitialInput == 0) // FOR INITIAL INPUT OF REVALUATION RATES, WE ONLY NEED TO S}
                    {
                        // 1 MESSAGE TO REPRESENT ALL CURRENCY INSTEAD OF S}ING A MESSAGE FOR EACH CURRENCY
                        if (strRatesMsg751 != "") strRatesMsg751 += "~";

                        strRatesMsg751 += strMessageRatesType + "|";
                        strRatesMsg751 += strOprDate + "|";
                        strRatesMsg751 += "ALL" + "|";
                        strRatesMsg751 += strMessageSuffix751;

                        intHave751InitialInput = 1; // SET flag TO 1 SO THAT WE DO NOT DO THIS BLOCK OF CODE FOR 751 AGAIN
					}
                }
                else if (strMessageSuffix751 != "")
                {
                    if (strRatesMsg751 != "") strRatesMsg751 += "~";

                    strRatesMsg751 += strMessageRatesType + "|";
                    strRatesMsg751 += strOprDate + "|";
                    strRatesMsg751 += strCcy + "|";
                    strRatesMsg751 += strMessageSuffix751;
                }
            }


            foreach (var _rateCriteria in rateCriteria784)
            {
                string strOprDate = _rateCriteria.OprDate.ToString("dd-MMM-yyyy");
                string strCcy = _rateCriteria.Ccy;
                string strUploadBy = _rateCriteria.UploadedBy ?? "";

                //string strAcuTransStatus = _rateCriteria.AcuTransStatus;
                //string strBuTransStatus = _rateCriteria.BuTransStatus;

                //--Flag value defination
                //--ACU_XXX for 751
                //--BU_XXX for 784

                //string strHaveAcu = _rateCriteria.AcuFlag ?? "";
                //string strHaveBu = _rateCriteria.BuFlag ?? "";

                string strOperationKind = "";
                //string strBranchNo751 = "";
                string strMessageSuffix784 = "";

                //if (strHaveBu == "Y")
                //{
                //strOperationKind = strBuTransStatus == "Y" ? "M" : "I";
                strOperationKind = _rateCriteria.OperationKind;

                // over write OperationKind for FX rate and Bis_rate
                //if (intSentTo == 6) strOperationKind = "I";         // ITS ALWAYS INITIAL INPUT FOR FX
                //if (intSentTo == 10) strOperationKind = "M";        // ITS ALWAYS MODif (Y INPUT FOR BIS

                strMessageSuffix784 = strOperationKind + "|" + strUploadBy + "|" + "784" + "|";
                //}


                // WE WILL ONLY DO THIS if ( ITS 784 AND IT ISS REVALUATION RATES
                if (strMessageSuffix784 != "" && strOperationKind == "I" && intSentTo == QueueTypes.REVALUATION_RATE)  //"REVALUATION_RATE";
                {
                    if (intHave784InitialInput == 0) // FOR INITIAL INPUT OF REVALUATION RATES, WE ONLY NEED TO S}
                    {
                        // 1 MESSAGE TO REPRESENT ALL CURRENCY INSTEAD OF S}ING A MESSAGE FOR EACH CURRENCY
                        if (strRatesMsg784 != "") strRatesMsg784 += "~";

                        strRatesMsg784 += strMessageRatesType + "|";
                        strRatesMsg784 += strOprDate + "|";
                        strRatesMsg784 += "ALL" + "|";
                        strRatesMsg784 += strMessageSuffix784;

                        intHave784InitialInput = 1; // SET flag TO 1 SO THAT WE DO NOT DO THIS BLOCK OF CODE FOR 784  AGAIN
					}
                }

                // WE WILL ONLY DO THIS if ( ITS 784 AND IT IS BIS RATES
                if (strMessageSuffix784 != "" && strOperationKind == "M" && intSentTo == QueueTypes.BIS_RATE)
                {
                    if (intHave784InitialInput == 0) // FOR INITIAL INPUT OF REVALUATION RATES, WE ONLY NEED TO S}
                    {                  // 1 MESSAGE TO REPRESENT ALL CURRENCY INSTEAD OF S}ING A MESSAGE FOR EACH CURRENCY
                        if (strRatesMsg784 != "") strRatesMsg784 += "~";

                        strRatesMsg784 += strMessageRatesType + "|";
                        strRatesMsg784 += strOprDate + "|";
                        strRatesMsg784 += "ALL" + "|";
                        strRatesMsg784 += strMessageSuffix784;

                        intHave784InitialInput = 1; // SET flag TO 1 SO THAT WE DO NOT DO THIS BLOCK OF CODE FOR 784  AGAIN
					}
                }
                else if (strMessageSuffix784 != "")
                {
                    if (strRatesMsg784 != "") strRatesMsg784 += "~";

                    strRatesMsg784 += strMessageRatesType + "|";
                    strRatesMsg784 += strOprDate + "|";
                    strRatesMsg784 += strCcy + "|";
                    strRatesMsg784 += strMessageSuffix784;
                }
            }

            //log.DebugFormat(string.Format("GetRatesMessage: GIP Messages ={0}", strRatesMsg));
            if (strRatesMsg751 != "")
            {
                if (strRatesMsg784 != "")
                    strRatesMsg751 += "~" + strRatesMsg784;
            }
            else
            {
                if (strRatesMsg784 != "")
                    strRatesMsg751 += strRatesMsg784;
            }
            return strRatesMsg751;
        }
        #endregion

    }
}
