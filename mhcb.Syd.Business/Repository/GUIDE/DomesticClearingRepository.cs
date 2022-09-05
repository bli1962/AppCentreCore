using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Business.Repository
{
    public class DomesticClearingRepository : IDomesticClearing
    {
        private readonly GUIDEDbContext appDbContext;
        public DomesticClearingRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<DomesticClearingPayment> GetDomesticClearingPaymentByDate(string optDate, string dateType)
        {
            DateTime date = DateTime.Parse(optDate);

            // List<SettlementInf> entry;
            List<DomesticClearingPayment> entry = new List<DomesticClearingPayment>();
            entry = appDbContext.DomesticClearingPayments
                    .Where(e =>
                           (EF.Functions.DateDiffDay(e.ValueDate, date) == 0 && dateType == "ValueDate") ||
                           (EF.Functions.DateDiffDay(e.ProcessDate, date) == 0 && dateType == "ProcessedDate") ||
                           (EF.Functions.DateDiffDay(e.UpdatedWhen, date) == 0 && dateType == "UpdatedDate") ||
                           (EF.Functions.DateDiffDay(e.CreatedWhen, date) == 0 && dateType == "CreatedDate") 
                     )
                    .OrderByDescending(e => e.PaymentId)
                    .ToList();  
            return entry;
        }

        public string UpdateStatus(DomesticClearingAttribute status)
        {
            var entry = appDbContext.DomesticClearingPayments
                              .Where(e => e.PaymentId == status.PaymentId)
                              .FirstOrDefault();

            var entryLogs = appDbContext.DomesticClearingPaymentLogs
                              .Where(e => e.PaymentId == status.PaymentId)
                              .FirstOrDefault();

            if (entry != null)
            {
                var preStatus = entry.StatusId;
                //var REF_NO = swiftPayment.GbaseRefNo.ToString();

                AuditLog auditLog = new()
                {
                    UserId = status.AuthorizeBy,
                    AuditDate = DateTime.Now,

                    RefNo = entry.PaymentId.ToString(),
                    TransNo = "",
                    AuditDesc = status.Comment,
                    AppName = "DomesticClearing",
                    TableName = "DomesticClearing_Payment",
                    OriginalValue = preStatus.ToString(),
                    NewValue = status.StatusId.ToString(),
                };

                DomesticClearingPaymentLog DCPaymentlogs = new()
                {
                    //PaymentLogId  =
                    PaymentId = entry.PaymentId,
                    Type = "Manual Operation",
                    Description = status.Comment,
                    UpdatedWhen = DateTime.Now,
                    UpdatedWho = status.AuthorizeBy
                };

                appDbContext.DomesticClearingPaymentLogs.Add(DCPaymentlogs);
                entry.StatusId = status.StatusId;
                appDbContext.AuditLogs.Add(auditLog);

                appDbContext.SaveChanges();
                return "OK";
            }
            else
            {
                return "NotFound";
            }

        }
    }
}

