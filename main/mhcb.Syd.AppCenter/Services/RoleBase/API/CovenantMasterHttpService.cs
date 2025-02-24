using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Blazored.LocalStorage;
using Microsoft.Extensions.Configuration;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class CovenantMasterHttpService : HttpBaseService, ICovenantMasterHttpService
    {
        public CovenantMasterHttpService(HttpClient httpClient,
                                        IHttpContextAccessor httpContext,
                                        IJwtToken jwtToken,
                                        ILocalStorageService localStorageService,
                                        IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }


        //public async Task<IEnumerable<CovenantMasterRecordView>> GetCovenantMasterRecord()
        //{
        //    return await _httpClient.GetJsonAsync<CovenantMasterRecordView[]>($"api/CovenantMasters/GetCovenantMasterRecord");
        //}

        //public async Task<IEnumerable<CovenantRatioView>> GetCovenantRatio(string covenantType, string dateType, string dateFrom, string dateTo)
        //{
        //    return await _httpClient.GetJsonAsync<CovenantRatioView[]>($"api/CovenantMasters/GetCovenantRatio/{covenantType}/{dateType}/{dateFrom}/{dateTo}");
        //}
    }
}
