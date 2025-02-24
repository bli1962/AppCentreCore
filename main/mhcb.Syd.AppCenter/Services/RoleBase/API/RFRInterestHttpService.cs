using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Http;
using Blazored.LocalStorage;
using Microsoft.Extensions.Configuration;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class RFRInterestHttpService : HttpBaseService, IRFRInterestHttpService
    {
        public RFRInterestHttpService(HttpClient httpClient,
                                        IHttpContextAccessor httpContext,
                                        IJwtToken jwtToken,
                                        ILocalStorageService localStorageService,
                                        IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        public async Task<IEnumerable<RFRInterestLoanView>> GetRFRInterestForLoanByReportDate(string reportDate, string custAbbr)
        {
            return await _httpClient.GetJsonAsync<RFRInterestLoanView[]>($"api/RFRInterests/GetRFRLoanInterest/{reportDate}/{custAbbr}");
        }

        public async Task<IEnumerable<RFRInterestSwapView>> GetRFRInterestForSwapByReportDate(string reportDate, string custAbbr)
        {
            return await _httpClient.GetJsonAsync<RFRInterestSwapView[]>($"api/RFRInterests/GetRFRSwapInterest/{reportDate}/{custAbbr}");
        }
    }
}
