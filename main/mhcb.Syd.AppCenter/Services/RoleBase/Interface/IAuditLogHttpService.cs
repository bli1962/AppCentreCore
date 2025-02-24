using System.Collections.Generic;
using System.Threading.Tasks;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IAuditLogHttpService
    {
        Task<IEnumerable<AuditLog>> GetAuditLogByDate(string optDate);
        Task<IEnumerable<AuditLog>> GetAuditLogByDates(string dateFrom, string dateTo);
        //Task<bool> InsertAuditLog(AuditLog audit_Log);
    }
}
