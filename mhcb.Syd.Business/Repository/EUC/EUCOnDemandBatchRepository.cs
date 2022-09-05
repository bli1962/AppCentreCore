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
	public class EUCOnDemandBatchRepository : IEUCOnDemandBatch
	{
        private readonly EUCDbArchiveDbContext appDbContext;
        private readonly GUIDEDbContext appDbContextGuide;
        public EUCOnDemandBatchRepository(EUCDbArchiveDbContext appDbContext, GUIDEDbContext appDbContext2)
        {
            this.appDbContext = appDbContext;
            this.appDbContextGuide = appDbContext2;
        }

        public IEnumerable<OnDemandBatchView> GetOnDemandBatchNoByDate(string createdDate)
		{
            //using EUCDbArchiveDbContext appDbContext  = new();
            DateTime date = DateTime.Parse(createdDate);

            var entry = (from b in appDbContext.OnDemandBatches
                         where EF.Functions.DateDiffDay(b.CreatedWhen, date) == 0
                         select new OnDemandBatchView()
                         {
                             BatchId = b.BatchId,
                             BatchNo = b.BatchNo,

                             Started = (b.Started == true ? "Yes" : "No"),
                             Completed = (b.Completed == true ? "Yes" : "No"),
                             Errored = (b.Errored == true ? "Yes" : "No"),
                             IsRec = (b.IsRec == true ? "Yes" : "No"),

                             WhoRequested = b.WhoRequested,
                             CreatedWhen = b.CreatedWhen.ToShortDateString(),
                             //CreatedWhen = (DbFunctions.TruncateTime().ToString()).Substring(0, 19),
                             UpdatedWhen = b.UpdatedWhen.ToShortDateString()                                
                         })
                         .ToList();
            return entry;
        }

		public IEnumerable<OnDemandBatchLogView> GetOnDemandBatchLogByBatchNo(string strBatchId)
		{
            //using EUCDbArchiveDbContext appDbContext  = new();
            int intBatchId = Int16.Parse(strBatchId);

            var entry = (from b in appDbContext.OnDemandBatchLogs
                         where b.BatchId == intBatchId
                         select new OnDemandBatchLogView()
                         {
                             LogId = b.LogId,
                             BatchId = b.BatchId,
                             Level = b.Level,
                             Message = b.Message,
                             CreatedWhen = b.When.ToShortDateString()
                         })
                         .ToList();
            return entry;
        }

		public string UpdateStatus(OnDemandBatchAttribute status)
		{
			try
			{
                //using EUCDbArchiveDbContext appDbContext  = new();
                DateTime date = DateTime.Today;

                var entry = appDbContext.OnDemandBatches.FirstOrDefault(
                                e => e.BatchNo == status.BatchNo
                                && e.Completed == true
                                && EF.Functions.DateDiffDay(e.CreatedWhen, date) == 0
                                );

                if (entry != null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,
                        RefNo = status.BatchNo.ToString(),
                        TransNo = "",
                        AuditDesc = "Set Batch to Completed",
                        AppName = "EUCDbArchive",
                        TableName = "OnDemand_Batch",
                        OriginalValue = (entry.Completed == true ? "Yes" : "No"),
                        NewValue = "Yes",
                    };

                    entry.Completed = true;
                    appDbContext.SaveChanges();

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

	}
}
