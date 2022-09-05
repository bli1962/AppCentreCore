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
    public class AuditLogRepository : IAuditLog
    {
        private readonly GUIDEDbContext appDbContext;
        public AuditLogRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        //public static Boolean InsertAuditLog(AuditLog audit_Log)
        //{
        //	try
        //	{
        //        using GUIDEDbContext appDbContext = new();
        //        appDbContext.AuditLogs.Add(audit_Log);
        //        appDbContext.SaveChanges();
        //        return true;
        //    }
        //	catch 
        //	{
        //		return false;
        //	}
        //}

		public IEnumerable<AuditLog> GetAuditLogByDate(string optDate)
		{
            //using GUIDEDbContext appDbContext = new();
            DateTime date = DateTime.Parse(optDate);

            var entry = appDbContext.AuditLogs
                                .Where(e => EF.Functions.DateDiffDay(e.AuditDate, date) == 0 )
                                .OrderByDescending(e => e.AuditId)
                                //.Take(50)
                                .ToList();
            return entry;
        }

        public  IEnumerable<AuditLog> GetAuditLogByDates(string strDateFrom, string strDateTo)
        {
            if (!(strDateFrom != null && strDateTo != null)) return new List<AuditLog>();

            //using GUIDEDbContext appDbContext = new();
            DateTime dateFrom = DateTime.Parse(strDateFrom);
            DateTime dateTo = DateTime.Parse(strDateTo);

            var entry = appDbContext.AuditLogs
                                //.Where(e => DbFunctions.TruncateTime(e.AuditDate) >= DbFunctions.TruncateTime(dateFrom)
                                //         && DbFunctions.TruncateTime(e.AuditDate) <= DbFunctions.TruncateTime(dateTo))
                               .Where(e => (EF.Functions.DateDiffDay(e.AuditDate, dateFrom) <= 0)
                                         && (EF.Functions.DateDiffDay(e.AuditDate, dateTo) >= 0))
                                .OrderByDescending(e => e.AuditId)
                                //.Take(50)
                                .ToList();
            return entry;
        }

    }

}



