using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IAuditLog
	{
		//bool InsertAuditLog(AuditLog audit_Log);
		IEnumerable<AuditLog> GetAuditLogByDate(string optDate);
		IEnumerable<AuditLog> GetAuditLogByDates(string dateFrom, string dateTo);
    }
}