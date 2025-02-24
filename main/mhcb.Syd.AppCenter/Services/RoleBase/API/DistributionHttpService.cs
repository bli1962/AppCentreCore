using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Http;
using Blazored.LocalStorage;
using Microsoft.Extensions.Configuration;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class DistributionHttpService : HttpBaseService, IDistributionService
    {
        public DistributionHttpService(HttpClient httpClient,
                                        IHttpContextAccessor httpContext,
                                        IJwtToken jwtToken,
                                        ILocalStorageService localStorageService,
                                        IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        public async Task<int> UpdateStatus(InputEDistribution status)
        {
            return await _httpClient.PutJsonAsync<int>("api/Distribution", status);

        }

        // *************************************************************************************
        // The following Http services has been replaced by Generic http service, because they
        // are not required  [Authorize(Roles = "xxxx")] in Web API
        // B. Li
        // *************************************************************************************

        //public async Task<IEnumerable<DistributionPreferenceView>> GetDistributionPreference(string AppName)
        //{
        //    //throw new NotImplementedException();
        //    return await _httpClient.GetJsonAsync<DistributionPreferenceView[]>($"api/Distribution/GetDistributionPreference/{AppName}");
        //}

        //public async Task<IEnumerable<DistributionPasswordView>> GetDistributionPassword(string abbreviation, string branch)
        //{
        //    return await _httpClient.GetJsonAsync<DistributionPasswordView[]>($"api/Distribution/GetDistributionPassword/{abbreviation}/{branch}");
        //}

        //public async Task<IEnumerable<DistributionView>> GetElcsConfirmation(string dateAdded)
        //{
        //	return await _httpClient.GetJsonAsync<DistributionView[]>($"api/Distribution/GetElcsConfirmation/{dateAdded}");
        //}
    }
}
