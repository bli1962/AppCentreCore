using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Business.Repository
{
	public class SpecialRateRepository : ISpecialRate
	{
        private readonly LOANDbContext appDbContext;
        private readonly GUIDEDbContext appDbContextGuide;
        public SpecialRateRepository(LOANDbContext appDbContext,
                                        GUIDEDbContext appDbContext2)
        {
            this.appDbContext = appDbContext;
            this.appDbContextGuide = appDbContext2;
        }
        public IEnumerable<ExchRateView> LoadSpcialRate()
		{
            //using LOANDbContext appDbContext  = new();
            string[] CCYs = { "AUD", "NZD", "SGD", "JPY", "EUR", "HKD", "GBP" };

            var entry = (from e in appDbContext.ExchRates
                         where CCYs.Contains(e.CcyCode)
                         orderby e.CcyCode
                         select new ExchRateView()
                         {
                             CCY_CODE = e.CcyCode,
                             DKB_SPECIAL_RATE_USD = e.DkbSpecialRateUsd
                         })
                        .ToList();
            return entry;
        }

		public string UpdateStatus(RateAttribute status)
		{
			try
			{
                //using LOANDbContext appDbContext  = new();
                var entry = appDbContext.ExchRates
                    .FirstOrDefault(e => e.CcyCode == status.CcyCode);

                if (entry != null)
                {
                    AuditLog auditLog = new()
                    {
                        UserId = status.AuthorizeBy,
                        AuditDate = DateTime.Now,
                        RefNo = entry.CcyCode,
                        TransNo = "",
                        AuditDesc = "Update Mizuho Special Rate",
                        AppName = "LOAN",
                        TableName = "EXCH_RATE",
                        OriginalValue = entry.DkbSpecialRateUsd.ToString(),
                        NewValue = status.Rate.ToString(),
                    };

                    entry.DkbSpecialRateUsd = status.Rate;
                    appDbContext.SaveChanges();

                    appDbContextGuide.AuditLogs.Add(auditLog);
                    appDbContextGuide.SaveChanges();
                    //AuditLogRepository.InsertAuditLog(auditLog);

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
