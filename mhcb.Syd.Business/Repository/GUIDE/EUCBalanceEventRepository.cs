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
	public class EUCBalanceEventRepository : IEUCBalanceEvent
	{
        private readonly GUIDEDbContext appDbContext;
        public EUCBalanceEventRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<MxEucBalanceEvent> GetEUCBalanceEventByCustAbbr(string custAbbr, string optDate)
		{
            //using GUIDEDbContext appDbContext  = new();
            DateTime date = DateTime.Parse(optDate);

            var entry = appDbContext.MxEucBalanceEvents
                                .Where(e => e.CustomerAbbreviation.Contains(custAbbr)
                                        && EF.Functions.DateDiffDay(e.StatusUpdateTime, date) == 0)
                                .OrderByDescending(e => e.Id)
                                //.Take(50)
                                .ToList();
            return entry;
        }

		public IEnumerable<MxEucBalanceEvent> GetEUCBalanceEventByRefno(string refNo, string optDate)
		{
            //using GUIDEDbContext appDbContext  = new();
            DateTime date = DateTime.Parse(optDate);

            var entry = appDbContext.MxEucBalanceEvents
                                .Where(e => e.GbaseReferenceNo.Contains(refNo)
                                    && EF.Functions.DateDiffDay(e.StatusUpdateTime, date) == 0
                                    )
                                .OrderByDescending(e => e.Id)
                                //.Take(50)
                                .ToList();
            return entry;
        }

		public IEnumerable<MxInboundEventLogView> GetMxInboundEventLogBySender(string sender, string optDate)
		{
            //using GUIDEDbContext appDbContext  = new();
            DateTime currentYear = DateTime.Now;
            DateTime date = DateTime.Parse(optDate);

            var entry = (from me in appDbContext.MxInboundEvents
                         join ml in appDbContext.MxInboundEventLogs on me.MessageId.ToString() equals ml.EventId
                         join ms in appDbContext.MxInboundMessageStatuses on me.StatusId equals ms.StatusId
                         where EF.Functions.DateDiffYear(ml.Timestamp, currentYear) == 0
                            && EF.Functions.DateDiffDay(ml.Timestamp, date) == 0
                            && me.SendingSystem.ToLower() == sender.ToLower()
                         select new MxInboundEventLogView()
                         {
                             MessageId = me.MessageId,
                             SendingSystem = me.SendingSystem,
                             Category = me.Category,
                             EventType = me.EventType,
                             StatusName = ms.StatusName,
                             //mb.GBaseReferenceNo,
                             //mb.CustomerAbbreviation,
                             //mb.BatchNo,
                             LogId = ml.LogId,
                             Logger = ml.Logger,
                             Description = ml.Description,
                             Status = ml.Status,
                         }).OrderByDescending(x => x.MessageId).OrderByDescending(y => y.LogId)
                        //.Take(50)
                        .ToList();
            return entry;
        }

		public IEnumerable<MxEucBalanceEventView> GetPendingTrans(string UpdateDdate)
		{
            //using GUIDEDbContext appDbContext  = new();
            //DateTime date = DateTime.Today;
            DateTime date = DateTime.Parse(UpdateDdate);

            var entry = (from b in appDbContext.MxEucBalanceEvents
                         where b.EventType.ToLower() == "deletion".ToLower()
                               && b.Category.ToLower() == "CallDeposit".ToLower()
                               && EF.Functions.DateDiffDay(b.StatusUpdateTime, date) == 0
                         select new MxEucBalanceEventView()
                         {
                             Id = b.Id,
                             EventId = b.EventId,
                             BatchNo = b.BatchNo,
                             GBaseReferenceNo = b.GbaseReferenceNo,
                             CustomerAbbreviation = b.CustomerAbbreviation,
                             Category = b.Category,
                             EventType = b.EventType,
                             ClosingDate = b.ClosingDate,
                             TradeDate = b.TradeDate,
                             EffectiveDate = b.EffectiveDate,
                             TimeSent = b.TimeSent.ToShortDateString(),
                             Status = b.Status,
                             StatusUpdateTime = b.StatusUpdateTime.ToShortDateString(),
                         })
                         .ToList();
            return entry;
        }

		public string UpdateStatus(EucBalanceAttribute status)
		{
			try
			{
                //using GUIDEDbContext appDbContext  = new();
                DateTime date = DateTime.Today;

                var entry = appDbContext.MxEucBalanceEvents
                            .FirstOrDefault(e => e.GbaseReferenceNo.ToLower() == status.GBaseReferenceNo.ToLower() 
                                && e.EventType.ToLower() == "deletion".ToLower()
                                && e.Category.ToLower() == "CallDeposit".ToLower()
                                && EF.Functions.DateDiffDay(e.StatusUpdateTime, date) == 0);

                if (entry != null)
                {
                    string strClosedate = DateTime.Now.ToString("yyMMdd").ToString();  // for example "201230";

                    AuditLog auditLog = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,
                        RefNo = status.GBaseReferenceNo.ToString(),
                        TransNo = "",
                        AuditDesc = "Append to Closing Date",
                        AppName = "GUIDE",
                        TableName = "Mx EUC Balance",
                        OriginalValue = "",
                        NewValue = strClosedate,
                    };

                    entry.ClosingDate = strClosedate;
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
