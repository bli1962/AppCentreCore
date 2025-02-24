using System.Collections.Generic;
using System.Threading.Tasks;
using mhcb.Syd.DataAccess.Models.GUIDE;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Blazored.LocalStorage;
using Microsoft.Extensions.Configuration;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class AuditLogHttpService : HttpBaseService, IAuditLogHttpService
    {
        public AuditLogHttpService(HttpClient httpClient,
                                    IHttpContextAccessor httpContext,
                                    IJwtToken jwtToken,
                                    ILocalStorageService localStorageService,
                                    IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        //public async Task<bool> InsertAuditLog(AuditLog audit_Log)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IEnumerable<AuditLog>> GetAuditLogByDate(string optDate)
        {
            return await _httpClient.GetJsonAsync<AuditLog[]>($"api/AuditLogs/GetAuditLogByDate/{optDate}");
        }

        public async Task<IEnumerable<AuditLog>> GetAuditLogByDates(string dateFrom, string dateTo)
        {
            //dateFrom = dateFrom.
            //dateTo = "2022-07-20";
            return await _httpClient.GetJsonAsync<AuditLog[]>($"api/AuditLogs/GetAuditLogByDates/{dateFrom}/{dateTo}");
        }
    }
}
