using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Business.Repository
{
	public class PaymentControlRepository : IPaymentControl
	{
        private readonly GUIDEDbContext appDbContext;
        public PaymentControlRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        //part I
        public IEnumerable<SwiftPaymentView> GetPaymentControlPaymentByDate(string strDateValue, string dateType)
		{
            //using GUIDEDbContext appDbContext  = new();
            if (strDateValue == null) return new List<SwiftPaymentView>();

            DateTime date = DateTime.Parse(strDateValue);

            var entry = (from pp in appDbContext.PaymentControlPayments
                             //join sp in appDbContext.PaymentControlSwiftPayments on pp.PaymentId equals sp.PaymentId
                         join st in appDbContext.PaymentControlStatuses on pp.StatusId equals st.StatusId
                         join fc in appDbContext.Fxfccies on pp.PaymentCurrencyCode equals fc.CcyCd

                         join ppf in appDbContext.PaymentControlProductReferences on pp.ProductReferenceId equals ppf.ProductReferenceId
                         join ppt in appDbContext.PaymentControlProducts on ppf.ProductId equals ppt.ProductId

                         where (dateType == "ReleasedDate") && (EF.Functions.DateDiffDay(pp.ReleaseDate, date)==0)
                         || (dateType == "ValueDate") && (EF.Functions.DateDiffDay(pp.ValueDate, date)==0)
                         orderby pp.PaymentId
                         select new SwiftPaymentView()
                         {
                             PaymentId = pp.PaymentId,
                             CustomerAbbreviation = pp.CustomerAbbreviation,
                             ValueDate = pp.ValueDate.ToString().Substring(0, 10),
                             ReleaseDate = pp.ReleaseDate.ToString().Substring(0, 10),
                             PaymentCurrencyCode = fc.Ccy,
                             Amount = pp.PaymentAmount,

                             //StatusId = pp.StatusId,
                             StatusDescription = st.Description,
                             GBaseRefNo = pp.GbaseRefNo,

                             Product = ppt.Code + " " + ppf.Code

                             //StatusId = sp.StatusId,
                             //GBaseRefNo = sp.GBaseRefNo,

                             //SwiftPaymentId = sp.SwiftPaymentId,
                             //Processed = sp.Processed,
                             //PaymentDate = sp.PaymentDate,
                             //Currency = sp.Currency,
                             //Amount = sp.Amount,
                             //SenderBank = sp.SenderBank,
                             //ReceiverBank = sp.ReceiverBank,
                             //CreatedWhen = sp.CreatedWhen,
                         })
                        .ToList();
            return entry;
        }

		public string UpdateStatus(SwiftPaymentStatus status)
		{
			try
			{
                //using GUIDEDbContext appDbContext  = new();
                var entry = appDbContext.PaymentControlPayments
                           .Where(e => e.PaymentId == status.PaymentId)
                           .FirstOrDefault();

                if (entry != null)
                {
                    var preStatus = entry.StatusId;

                    AuditLog auditLog = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,

                        RefNo = entry.GbaseRefNo.ToString(),
                        TransNo = status.PaymentId.ToString(),
                        AuditDesc = "Change PaymentControl Status",
                        AppName = "PaymentControl",
                        TableName = "PaymentControl_Payment",
                        OriginalValue = preStatus.ToString(),
                        NewValue = status.StatusId.ToString(),
                    };

                    entry.StatusId = status.StatusId;
                    appDbContext.AuditLogs.Add(auditLog);
                    //AuditLogRepository.InsertAuditLog(auditLog);

                    appDbContext.SaveChanges();
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

		//part II
		public IEnumerable<SwiftPaymentView> GetSwiftPaymentByDate(string strDateValue, string dateType)
		{
            //using GUIDEDbContext appDbContext  = new();
            if (strDateValue == null) return new List<SwiftPaymentView>();

            DateTime date = DateTime.Parse(strDateValue);

            var entry = (from pp in appDbContext.PaymentControlPayments
                         join sp in appDbContext.PaymentControlSwiftPayments on pp.PaymentId equals sp.PaymentId
                         join st in appDbContext.PaymentControlStatuses on sp.StatusId equals st.StatusId

                         where (dateType == "CreatedDate") && (EF.Functions.DateDiffDay(sp.CreatedWhen,date)==0)
                        || (dateType == "PaymentDate") && (EF.Functions.DateDiffDay(sp.PaymentDate,date)==0)
                        || (dateType == "ValueDate") && (EF.Functions.DateDiffDay(pp.ValueDate,date) ==0)

                         orderby pp.PaymentId, sp.SwiftPaymentId
                         select new SwiftPaymentView()
                         {
                             PaymentId = pp.PaymentId,
                             CustomerAbbreviation = pp.CustomerAbbreviation,
                             ValueDate = pp.ValueDate.ToString().Substring(0, 10),
                             ReleaseDate = pp.ReleaseDate.ToString().Substring(0, 10),
                             PaymentCurrencyCode = sp.Currency,

                             //StatusId = pp.StatusId,
                             //GBaseRefNo = pp.GBaseRefNo,
                             StatusId = sp.StatusId,
                             StatusDescription = st.Description,
                             GBaseRefNo = sp.GbaseRefNo,

                             SwiftPaymentId = sp.SwiftPaymentId,
                             Processed = sp.Processed,
                             PaymentDate = sp.PaymentDate.ToString().Substring(0, 10),
                             Currency = sp.Currency,
                             Amount = sp.Amount,
                             SenderBank = sp.SenderBank,
                             ReceiverBank = sp.ReceiverBank,
                             CreatedWhen = sp.CreatedWhen.ToString().Substring(0, 10),
                         })
                        .ToList();
            return entry;
        }

		public string DeleteSwiftPayment(SwiftPaymentStatus status)
		{
			try
			{
                //using GUIDEDbContext appDbContext  = new();
                var swiftPayment = appDbContext.PaymentControlSwiftPayments
                                  .Where(e => e.SwiftPaymentId == status.SwiftPaymentId)
                                  .FirstOrDefault();

                var entryLogs = appDbContext.PaymentControlSwiftPaymentLogs
                               .Where(e => e.SwiftPaymentId == status.SwiftPaymentId)
                               .ToList();

                var entryAcks = appDbContext.PaymentControlSwiftAcks
                    .Where(e => e.SwiftPaymentId == status.SwiftPaymentId)
                    .ToList();

                if (swiftPayment != null)
                {
                    var preStatus = swiftPayment.StatusId;
                    var REF_NO = swiftPayment.GbaseRefNo.ToString();

                    AuditLog auditLog = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,

                        RefNo = swiftPayment.GbaseRefNo.ToString(),
                        TransNo = status.SwiftPaymentId.ToString(),
                        AuditDesc = "Delete SwiftPayment Transaction",
                        AppName = "PaymentControl",
                        TableName = "PaymentControl_SwiftPayment",
                        OriginalValue = preStatus.ToString(),
                        NewValue = "n/a",
                    };

                    appDbContext.PaymentControlSwiftPaymentLogs.RemoveRange(entryLogs);
                    appDbContext.SaveChanges();

                    appDbContext.PaymentControlSwiftAcks.RemoveRange(entryAcks);
                    appDbContext.SaveChanges();

                    appDbContext.PaymentControlSwiftPayments.Remove(swiftPayment);

                    appDbContext.AuditLogs.Add(auditLog);

                    appDbContext.SaveChanges();
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

	}
}


