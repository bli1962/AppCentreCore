using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Business.Repository
{
	public class EDocumentRepository : IEDocument
	{
        private readonly EDocumentDbContext appDbContextEDoc;
        private readonly GUIDEDbContext appDbContextGuide;
        public EDocumentRepository(EDocumentDbContext appDbContext, GUIDEDbContext appDbContext2)
        {
            this.appDbContextEDoc = appDbContext;
            this.appDbContextGuide = appDbContext2;
        }
  
        public IEnumerable<MMStatementView> GetMMStatement(string eDocType, string optDate)
		{
			if (optDate == null) return new List<MMStatementView>();

            //using EDocumentDbContext appDbContext  = new();
            DateTime date = DateTime.Parse(optDate);

            List<MMStatementView> entry;
            //appDbContext.Configuration.LazyLoadingEnabled = false;
            // Or: appDbContext.Configuration.ProxyCreationEnabled = false;
            switch (eDocType)
            {
                case "MoneyMarketDepositStatement":
                case "MoneyMarketLoanStatement":
                case "CurrentAndSavingsStatement":
                    entry = (from g in appDbContextEDoc.GBaseDocuments
                             join s in appDbContextEDoc.Statements on g.Id equals s.GBaseDocumentId
                             where g.ReportType.Contains(eDocType)
                                   && EF.Functions.DateDiffDay(g.DateProcessed, date) == 0
                             select new MMStatementView()
                             {
                                 Id = g.Id,
                                 ReportType = g.ReportType,
                                 ReportFileName = g.ReportFileName,
                                 Processed = g.Processed ? "Y" : "N",

                                 DateProcessed = (DateTime)g.DateProcessed,

                                 Errored = g.Errored ? "Y" : "N",
                                 ErrorMessage = g.ErrorMessage ?? "",

                                 CompanyName = s.CompanyName,
                                 AccountNo = s.AccountNo,
                                 //ReferenceNumber = 'n/a',
                                 AccountType = s.AccountType
                             })
                             .ToList();
                    break;
                //case "MoneyMarketDepositStatement":
                //      not available
                //case "MoneyMarketLoanStatement":
                //      not available
                //case "MoneyMarketLoanConfirmation":
                //case "MoneyMarketDepositConfirmation":
                //    entry = (from g in appDbContext.GBaseDocuments
                //             join s in appDbContext.MoneyMarketConfirmations on g.Id equals s.GBaseDocumentId
                //             where g.ReportType.Contains(eDocType)
                //                    && EF.Functions.DateDiffDay(g.DateProcessed, date) == 0
                //             select new MMStatementView()
                //             {
                //                 Id = g.Id,
                //                 ReportType = g.ReportType,
                //                 ReportFileName = g.ReportFileName,
                //                 Processed = g.Processed ? "Y" : "N",
                //                 DateProcessed = (DateTime)g.DateProcessed,

                //                 Errored = g.Errored ? "Y" : "N",
                //                 ErrorMessage = g.ErrorMessage ?? "",

                //                 CompanyName = s.CompanyName,
                //                 AccountNo = s.ReferenceNumber,
                //                 //ReferenceNumber = 'n/a',
                //                 AccountType = "n/a"
                //             })
                //          .ToList();

                //    break;
                //case "ForeignExchangeConfirmation":
                //    entry = (from g in appDbContext.GBaseDocuments
                //             join s in appDbContext.ForeignExchangeConfirmations on g.Id equals s.GBaseDocumentId
                //             where g.ReportType.Contains(eDocType)
                //                   && EF.Functions.DateDiffDay(g.DateProcessed, date) == 0
                //             select new MMStatementView()
                //             {
                //                 Id = g.Id,
                //                 ReportType = g.ReportType,
                //                 ReportFileName = g.ReportFileName,
                //                 Processed = g.Processed ? "Y" : "N",
                //                 DateProcessed = (DateTime)g.DateProcessed,
                //                 Errored = g.Errored ? "Y" : "N",
                //                 ErrorMessage = g.ErrorMessage ?? "",

                //                 CompanyName = s.CompanyName,
                //                 AccountNo = s.ReferenceNumber,
                //                 //ReferenceNumber = 'n/a',
                //                 AccountType = "n/a"
                //             })
                //             .ToList();
                //    break;

                default:
                    entry = null;
                    break;
            }
            return entry;
        }

        public IEnumerable<MMConfirmationView> GetMMConfirmation(string eDocType, string optDate)
        {
            if (optDate == null) return new List<MMConfirmationView>();

            //using EDocumentDbContext appDbContext  = new();
            DateTime date = DateTime.Parse(optDate);

            List<MMConfirmationView> entry;
            switch (eDocType)
            {              
                case "MoneyMarketLoanConfirmation":
                case "MoneyMarketDepositConfirmation":
                    entry = (from g in appDbContextEDoc.GBaseDocuments
                             join s in appDbContextEDoc.MoneyMarketConfirmations on g.Id equals s.GBaseDocumentId
                             where g.ReportType.Contains(eDocType)
                                    && EF.Functions.DateDiffDay(g.DateProcessed, date) == 0
                             select new MMConfirmationView()
                             {
                                 Id = g.Id,
                                 ReportType = g.ReportType,
                                 ReportFileName = g.ReportFileName,
                                 Processed = g.Processed ? "Y" : "N",
                                 DateProcessed = (DateTime)g.DateProcessed,

                                 Errored = g.Errored ? "Y" : "N",
                                 ErrorMessage = g.ErrorMessage ?? "",

                                 CompanyName = s.CompanyName,
                                 //AccountNo = s.AccountNo,
                                 //AccountType = s.AccountType

                                 ReferenceNumber = s.ReferenceNumber,
                                 ContractDate = s.ContractDate,
                                 ValueDate = s.ValueDate,
                                 DueDate = s.DueDate,
                                 IncreaseDecrease = s.IncreaseDecrease,
                                 ClosingBalance =s.ClosingBalance,
                                 Rate = s.Rate
                             })
                          .ToList();

                    break;
               
                default:
                    entry = null;
                    break;
            }
            return entry;
        }

        public IEnumerable<FXConfirmationView> GetFXConfirmation(string eDocType, string optDate)
        {
            if (optDate == null) return new List<FXConfirmationView>();

            //using EDocumentDbContext appDbContext  = new();
            DateTime date = DateTime.Parse(optDate);

            List<FXConfirmationView> entry;
            switch (eDocType)
            {
                case "ForeignExchangeConfirmation":
                    entry = (from g in appDbContextEDoc.GBaseDocuments
                             join s in appDbContextEDoc.ForeignExchangeConfirmations on g.Id equals s.GBaseDocumentId
                             where g.ReportType.Contains(eDocType)
                                   && EF.Functions.DateDiffDay(g.DateProcessed, date) == 0
                             select new FXConfirmationView()
                             {
                                 Id = g.Id,
                                 ReportType = g.ReportType,
                                 ReportFileName = g.ReportFileName,
                                 Processed = g.Processed ? "Y" : "N",
                                 DateProcessed = (DateTime)g.DateProcessed,
                                 Errored = g.Errored ? "Y" : "N",
                                 ErrorMessage = g.ErrorMessage ?? "",

                                 CompanyName = s.CompanyName,
                                 ReferenceNumber = s.ReferenceNumber,
                                 ContractDate = s.ContractDate,
                                 BuyAmount = s.OurPurchaseAmount,
                                 SellAmount = s.OurSaleAmount,
                                 OurPurchaseRate = s.OurPurchaseRate

                                 //AccountNo = s.ReferenceNumber,
                                 //AccountType = "n/a"
                             })
                             .ToList();
                    break;
                default:
                    entry = null;
                    break;
            }
            return entry;
        }
        
        public string UpdateStatus(InputEDocument status)
		{
			try
			{
                //using EDocumentDbContext appDbContext  = new();
                var entry = appDbContextEDoc.GBaseDocuments
                            .Where(x => x.Id == status.Id)
                            .FirstOrDefault();

                if (entry != null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,
                        RefNo = status.Id.ToString(),
                        TransNo = "",
                        AuditDesc = "Sent " + status.ReportType + " to reprint",
                        AppName = "eDocument",
                        TableName = "gBaseDocuments",
                        OriginalValue = entry.Processed.ToString(),
                        NewValue = "false",
                    };

                    entry.ErrorMessage = "RePrinted";
                    entry.Errored = false;
                    entry.Processed = false;

                    appDbContextEDoc.SaveChanges();

                    //AuditLogRepository.InsertAuditLog(auditLog);
                    appDbContextGuide.AuditLogs.Add(auditLog);
                    appDbContextGuide.SaveChanges();
                    return "OK";
                }
                else
                {
                    return "NotFound";
                }
            }
			catch (Exception ex)
			{
				return ex.ToString();
			}
		}

		//public static string updateStatus_notuse(EDocumentType eDocType)
		//{
		//    try
		//    {
		//        using (EDocumentDbContext appDbContext  = new())
		//        {
		//            gBaseDocument entry;
		//            int gBaseDocumentId;

		//            //appDbContext.Configuration.LazyLoadingEnabled = false;
		//            // Or: appDbContext.Configuration.ProxyCreationEnabled = false;
		//            switch (eDocType.ReportType)
		//            {
		//                case "CurrentAndSavingsStatement":
		//                    //entry = appDbContext.gBaseDocuments.Where(b => b.ReportType == eDocType.ReportType)
		//                    //			.Select(b => new
		//                    //			{
		//                    //				b,
		//                    //				Statements = b.Statements
		//                    //								.Where(p => p.AccountNo == eDocType.AccRefNo)
		//                    //			})
		//                    //			.AsEnumerable()
		//                    //			.Select(x => x.b)
		//                    //			.OrderByDescending(b => b.Id)
		//                    //			.FirstOrDefault();
		//                    gBaseDocumentId = appDbContext.Statements
		//                                  .Where(e => e.AccountNo.Contains(eDocType.AccRefNo))
		//                                  .OrderByDescending(e => e.gBaseDocumentId)
		//                                  .Select(e => e.gBaseDocumentId)
		//                                  .FirstOrDefault();

		//                    entry = appDbContext.gBaseDocuments
		//                                    .Where(e => e.ReportType == eDocType.ReportType
		//                                                && e.Id == gBaseDocumentId)
		//                                    .FirstOrDefault();

		//                    break;
		//                //case "MoneyMarketDepositStatement":
		//                //      not available
		//                //case "MoneyMarketLoanStatement":
		//                //      not available
		//                case "MoneyMarketLoanConfirmation":
		//                case "MoneyMarketDepositConfirmation":
		//                    gBaseDocumentId = appDbContext.MoneyMarketConfirmations
		//                                          .Where(e => e.ReferenceNumber.Contains(eDocType.AccRefNo))
		//                                          .OrderByDescending(e => e.gBaseDocumentId)
		//                                          .Select(e => e.gBaseDocumentId)
		//                                          .FirstOrDefault();
		//                    entry = appDbContext.gBaseDocuments
		//                                    .Where(e => e.ReportType == eDocType.ReportType
		//                                                && e.Id == gBaseDocumentId)
		//                                    .FirstOrDefault();

		//                    break;
		//                case "ForeignExchangeConfirmation":
		//                    gBaseDocumentId = appDbContext.ForeignExchangeConfirmations
		//                                      .Where(e => e.ReferenceNumber.Contains(eDocType.AccRefNo))
		//                                      .OrderByDescending(e => e.gBaseDocumentId)
		//                                      .Select(e => e.gBaseDocumentId)
		//                                      .FirstOrDefault();
		//                    entry = appDbContext.gBaseDocuments
		//                                    .Where(e => e.ReportType == eDocType.ReportType
		//                                                && e.Id == gBaseDocumentId)
		//                                    .FirstOrDefault();
		//                    break;

		//                default:
		//                    //break;
		//                    return null;
		//            }


		//            if (entry != null)
		//            {
		//                var processed = entry.Processed.ToString();

		//                AuditLog auditLog  = new()
		//                {
		//                    UserId = eDocType.AUTHORIZE_BY,
		//                    AuditDate = DateTime.Now,
		//                    RefNo = eDocType.AccRefNo,
		//                    TransNo = "",
		//                    AuditDesc = "Sent " + eDocType.ReportType + " to reprint",
		//                    AppName = "eDocument",
		//                    TableName = "gBaseDocuments",
		//                    OriginalValue = processed,
		//                    NewValue = "false",
		//                };


		//                entry.ErrorMessage = "RePrinted";
		//                entry.Errored = false;
		//                entry.Processed = false;

		//                appDbContext.SaveChanges();
		//                AuditLogRepository.InsertAuditLog(auditLog);
		//                return "OK";
		//            }
		//            else
		//            {
		//                return "NotFound";
		//            }
		//        }
		//    }
		//    catch (Exception ex)
		//    {
		//        return ex.ToString();
		//    }
		//}

	}
}
