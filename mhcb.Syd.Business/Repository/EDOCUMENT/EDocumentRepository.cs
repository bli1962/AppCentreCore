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
        private readonly EDocumentDbContext appDbContext;
        private readonly GUIDEDbContext appDbContextGuide;
        public EDocumentRepository(EDocumentDbContext appDbContext, GUIDEDbContext appDbContext2)
        {
            this.appDbContext = appDbContext;
            this.appDbContextGuide = appDbContext2;
        }
  
        public IEnumerable<eDocumentView> GetPendingTrans(string eDocType, string optDate)
		{
			if (optDate == null) return new List<eDocumentView>();

            //using EDocumentDbContext appDbContext  = new();
            DateTime date = DateTime.Parse(optDate);

            List<eDocumentView> entry;
            //appDbContext.Configuration.LazyLoadingEnabled = false;
            // Or: appDbContext.Configuration.ProxyCreationEnabled = false;
            switch (eDocType)
            {
                case "CurrentAndSavingsStatement":
                    entry = (from g in appDbContext.GBaseDocuments
                             join s in appDbContext.Statements on g.Id equals s.GBaseDocumentId
                             where g.ReportType.Contains(eDocType)
                                   && EF.Functions.DateDiffDay(g.DateProcessed, date) == 0
                             select new eDocumentView()
                             {
                                 Id = g.Id,
                                 ReportType = g.ReportType,
                                 ReportFileName = g.ReportFileName,
                                 Processed = g.Processed ? "Y" : "N",

                                 DateProcessed = g.DateProcessed.ToString().Substring(0, 10),
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
                case "MoneyMarketLoanConfirmation":
                case "MoneyMarketDepositConfirmation":
                    entry = (from g in appDbContext.GBaseDocuments
                             join s in appDbContext.MoneyMarketConfirmations on g.Id equals s.GBaseDocumentId
                             where g.ReportType.Contains(eDocType)
                                    && EF.Functions.DateDiffDay(g.DateProcessed, date) == 0
                             select new eDocumentView()
                             {
                                 Id = g.Id,
                                 ReportType = g.ReportType,
                                 ReportFileName = g.ReportFileName,
                                 Processed = g.Processed ? "Y" : "N",
                                 DateProcessed = g.DateProcessed.ToString().Substring(0, 10),
                                 Errored = g.Errored ? "Y" : "N",
                                 ErrorMessage = g.ErrorMessage ?? "",

                                 CompanyName = s.CompanyName,
                                 AccountNo = s.ReferenceNumber,
                                 //ReferenceNumber = 'n/a',
                                 AccountType = "n/a"
                             })
                          .ToList();

                    break;
                case "ForeignExchangeConfirmation":
                    entry = (from g in appDbContext.GBaseDocuments
                             join s in appDbContext.ForeignExchangeConfirmations on g.Id equals s.GBaseDocumentId
                             where g.ReportType.Contains(eDocType)
                                   && EF.Functions.DateDiffDay(g.DateProcessed, date) == 0
                             select new eDocumentView()
                             {
                                 Id = g.Id,
                                 ReportType = g.ReportType,
                                 ReportFileName = g.ReportFileName,
                                 Processed = g.Processed ? "Y" : "N",
                                 DateProcessed = g.DateProcessed.ToString().Substring(0, 10),
                                 Errored = g.Errored ? "Y" : "N",
                                 ErrorMessage = g.ErrorMessage ?? "",

                                 CompanyName = s.CompanyName,
                                 AccountNo = s.ReferenceNumber,
                                 //ReferenceNumber = 'n/a',
                                 AccountType = "n/a"
                             })
                             .ToList();
                    break;

                default:
                    entry = null;
                    break;
            }
            return entry;
        }

		public string UpdateStatus(EDocumentAttribute status)
		{
			try
			{
                //using EDocumentDbContext appDbContext  = new();
                var entry = appDbContext.GBaseDocuments
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

                    appDbContext.SaveChanges();

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
