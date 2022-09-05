using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.AppCenter.Services.Interface;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace mhcb.Syd.AppCenter.Services.API
{
    public class AuditLogService : IAuditLogService
    {
        //Task<bool> InsertAuditLog(AuditLog audit_Log);
        //Task<IEnumerable<AuditLog>> LoadAuditLogByDate(string optDate);
        //Task<IEnumerable<AuditLog>> LoadAuditLogByDateRange(string strDateFrom, string strDateTo);
        private readonly HttpClient httpClient;
        public AuditLogService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<bool> InsertAuditLog(AuditLog audit_Log)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AuditLog>> GetAuditLogByDate(string optDate)
        {
            return await httpClient.GetJsonAsync<AuditLog[]>($"api/AuditLogs/GetAuditLogByDate/{optDate}");
        }

        public async Task<IEnumerable<AuditLog>> GetAuditLogByDates(string dateFrom, string dateTo)
        {
            //dateFrom = dateFrom.
            //dateTo = "2022-07-20";
            return await httpClient.GetJsonAsync<AuditLog[]>($"api/AuditLogs/GetAuditLogByDates/{dateFrom}/{dateTo}");
        }
    }
}
