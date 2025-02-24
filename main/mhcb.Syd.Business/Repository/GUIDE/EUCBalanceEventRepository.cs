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

        public IEnumerable<MxEucBalanceEventView> GetEUCBalanceEventByCustAbbr(string custAbbr, string optDate)
		{
            //using GUIDEDbContext appDbContext  = new();
            DateTime date = DateTime.Parse(optDate);

            var entry = (from b in appDbContext.MxEucBalanceEvents
                         where b.CustomerAbbreviation.Contains(custAbbr)
                               && EF.Functions.DateDiffDay(b.StatusUpdateTime, date) == 0
                         orderby b.Id descending
                         select new MxEucBalanceEventView()
                         {
                             Id = b.Id,
                             EventId = b.EventId,
                             BatchNo = b.BatchNo,
                             GbaseReferenceNo = b.GbaseReferenceNo,
                             CustomerAbbreviation = b.CustomerAbbreviation,
                             Category = b.Category,
                             EventType = b.EventType,
                             //ClosingDate = b.ClosingDate,
                             //TradeDate = b.TradeDate,
                             //EffectiveDate = b.EffectiveDate,
                             ClosingDate = b.ClosingDate.Substring(0, 2) + '/' + b.ClosingDate.Substring(2, 2) + '/' + b.TimeSent.Year.ToString().Substring(0, 2) + b.ClosingDate.Substring(4, 2),
                             TradeDate = b.TradeDate.Substring(0, 2) + '/' + b.TradeDate.Substring(2, 2) + '/' + b.TimeSent.Year.ToString().Substring(0, 2) + b.TradeDate.Substring(4, 2),
                             EffectiveDate = b.EffectiveDate.Substring(0, 2) + '/' + b.EffectiveDate.Substring(2, 2) + '/' + b.TimeSent.Year.ToString().Substring(0, 2) + b.EffectiveDate.Substring(4, 2),

                             TimeSent = b.TimeSent,
                             Status = b.Status,
                             StatusUpdateTime = b.StatusUpdateTime,
                         })
                         .ToList();
            return entry;
        }

		public IEnumerable<MxEucBalanceEventView> GetEUCBalanceEventByRefno(string refNo, string optDate)
		{
            //using GUIDEDbContext appDbContext  = new();
            DateTime date = DateTime.Parse(optDate);

            var entry = (from b in appDbContext.MxEucBalanceEvents
                         where b.GbaseReferenceNo.Contains(refNo)
                               && EF.Functions.DateDiffDay(b.StatusUpdateTime, date) == 0
                         orderby b.Id descending
                         select new MxEucBalanceEventView()
                         {
                             Id = b.Id,
                             EventId = b.EventId,
                             BatchNo = b.BatchNo,
                             GbaseReferenceNo = b.GbaseReferenceNo,
                             CustomerAbbreviation = b.CustomerAbbreviation,
                             Category = b.Category,
                             EventType = b.EventType,
                             //ClosingDate = b.ClosingDate,
                             //TradeDate = b.TradeDate,
                             //EffectiveDate = b.EffectiveDate,
                             ClosingDate = b.ClosingDate.Substring(0, 2) + '/' + b.ClosingDate.Substring(2, 2) + '/' + b.TimeSent.Year.ToString().Substring(0, 2) + b.ClosingDate.Substring(4, 2),
                             TradeDate = b.TradeDate.Substring(0, 2) + '/' + b.TradeDate.Substring(2, 2) + '/' + b.TimeSent.Year.ToString().Substring(0, 2) + b.TradeDate.Substring(4, 2),
                             EffectiveDate = b.EffectiveDate.Substring(0, 2) + '/' + b.EffectiveDate.Substring(2, 2) + '/' + b.TimeSent.Year.ToString().Substring(0, 2) + b.EffectiveDate.Substring(4, 2),

                             TimeSent = b.TimeSent,
                             Status = b.Status,
                             StatusUpdateTime = b.StatusUpdateTime,
                         })
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
                         orderby b.Id descending
                         select new MxEucBalanceEventView()
                         {
                             Id = b.Id,
                             EventId = b.EventId,
                             BatchNo = b.BatchNo,
                             GbaseReferenceNo = b.GbaseReferenceNo,
                             CustomerAbbreviation = b.CustomerAbbreviation,
                             Category = b.Category,
                             EventType = b.EventType,

                             ClosingDate = b.ClosingDate == "" ? "" : b.ClosingDate.Substring(0, 2) + '/' + b.ClosingDate.Substring(2, 2) + '/' + b.TimeSent.Year.ToString().Substring(0, 2) + b.ClosingDate.Substring(4, 2),
                             TradeDate = b.TradeDate.Substring(0, 2) + '/' + b.TradeDate.Substring(2, 2) + '/' + b.TimeSent.Year.ToString().Substring(0, 2) + b.TradeDate.Substring(4, 2),
                             EffectiveDate = b.EffectiveDate.Substring(0, 2) + '/' + b.EffectiveDate.Substring(2, 2) + '/' + b.TimeSent.Year.ToString().Substring(0, 2) + b.EffectiveDate.Substring(4, 2),

                             TimeSent = b.TimeSent,
                             Status = b.Status,
                             StatusUpdateTime = b.StatusUpdateTime,
                         })
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
                         orderby me.MessageId descending
                         select new MxInboundEventLogView()
                         {
                             MessageId = me.MessageId,
                             SendingSystem = (
                                            me.SendingSystem == "GBaseRefNo" ? "GID Upload" :
                                            me.SendingSystem == "GuideCustomer" ? "Upload Cusomter to Murex" :
                                            me.SendingSystem == "EucBalances" ? "Euc Balance" : "Unknown"
                                        ),
                             Category = me.Category,
                             EventType = (
                                            me.EventType == "UpdateReference" ? "Update GID in Murex" :
                                            me.EventType == "Insert" ? "Insert Cusomter to Murex" :
                                            me.EventType == "Update" ? "Update Cusomter in Murex" :
                                            me.EventType == "Insertion" ? "Insert Euc Balance to Murex" : "Unknown"
                                        ),
                             StatusName = ms.StatusName,
                             //mb.GBaseReferenceNo,
                             //mb.CustomerAbbreviation,
                             //mb.BatchNo,
                             LogId = ml.LogId,
                             Logger = ml.Logger,
                             Description = ml.Description,
                             Status = ml.Status,
                         }).OrderBy(x => x.MessageId).OrderBy(y => y.LogId)
                        .ToList();
            return entry;
        }

        public IEnumerable<MxEucBalanceView> GetEucBalanceEvents(string optDate)
        {
            //using GUIDEDbContext appDbContext  = new();
            DateTime currentYear = DateTime.Now;
            DateTime date = DateTime.Parse(optDate);

            IEnumerable<MxEucBalanceView> entry = null;
            try
            {
                entry = (from me in appDbContext.MxInboundEvents
                         join balances in appDbContext.MxEucBalanceEvents on me.MessageId equals balances.EventId into c1
                         from mb in c1.DefaultIfEmpty()
                         join ms in appDbContext.MxInboundMessageStatuses on me.StatusId equals ms.StatusId
                        where EF.Functions.DateDiffDay(me.Timestamp, date) == 0
                             && me.SendingSystem.ToLower() == "EucBalances"
                        select new MxEucBalanceView()
                        {
                            MessageId = me.MessageId,
                            SendingSystem = me.SendingSystem,
                            Category = me.Category,
                            EventType = me.EventType,

                            EventStatus = ms.StatusName,

                            GBaseReferenceNo = mb.GbaseReferenceNo,
                            CustomerAbbreviation = mb.CustomerAbbreviation,
                            BranchNo = mb.BranchNo,
                            Currency = mb.Currency,
                            NominalAmount = (decimal)mb.NominalAmount,
                            TradeDate = mb.TradeDate,
                            EffectiveDate = mb.EffectiveDate,
                            BalanceStatus = mb.Status,
                            BatchNo = mb.BatchNo
                        }).OrderBy(x => x.MessageId)
                       .ToList();
            }
            catch (Exception e)
            {
                var message = e.InnerException.ToString();
            }
            finally
            {            
            }        
            return entry;
        }

        public string UpdateStatus(InputEucBalance status)
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
