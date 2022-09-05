using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface IAuditLogService
    {     
        Task<IEnumerable<AuditLog>> GetAuditLogByDate(string optDate);
        Task<IEnumerable<AuditLog>> GetAuditLogByDates(string dateFrom, string dateTo);
        Task<bool> InsertAuditLog(AuditLog audit_Log);
    }
}
