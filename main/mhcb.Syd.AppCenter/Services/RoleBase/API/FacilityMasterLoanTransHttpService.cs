using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Blazored.LocalStorage;
using Microsoft.Extensions.Configuration;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class FacilityMasterLoanTransHttpService : HttpBaseService, IFacilityMasterLoanTransHttpService
    {
        public FacilityMasterLoanTransHttpService(HttpClient httpClient,
                                                IHttpContextAccessor httpContext,
                                                IJwtToken jwtToken,
                                                ILocalStorageService localStorageService,
                                                IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        // *************************************************************************************
        // The following Http services has been replaced by Generic http service, because they
        // are not required  [Authorize(Roles = "xxxx")] in Web API
        // B. Li
        // *************************************************************************************

        //public async Task<IEnumerable<FacilityMasterLoanTransView>> GetLoanTransactionByCcyDates(string dateFrom, string dateTo)
        //{
        //    return await _httpClient.GetJsonAsync<FacilityMasterLoanTransView[]>($"api/FacilityMasterLoanTrans/GetLoanTransactionByDates/{dateFrom}/{dateTo}");
        //}

        //public async Task<IEnumerable<FacilityMasterLoanTransView>> GetLoanTransactionByDatesCcy(string dateFrom, string dateTo, string ccy)
        //{
        //    return await _httpClient.GetJsonAsync<FacilityMasterLoanTransView[]>($"api/FacilityMasterLoanTrans/GetLoanTransactionByDatesCcy/{dateFrom}/{dateTo}/{ccy}");
        //}
    }
}
