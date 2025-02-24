using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Blazored.LocalStorage;
using Microsoft.Extensions.Configuration;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class CustomerMasterHttpService : HttpBaseService, ICustomerMasterHttpService
    {
        public CustomerMasterHttpService(HttpClient httpClient,
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

        //public async Task<IEnumerable<CustomerMaster>> LoadCustomerMasterByCustAbbr(string custAbbr, string branchNo)
        //{
        //    //throw new NotImplementedException();
        //    return await _httpClient.GetJsonAsync<CustomerMaster[]>($"api/CustomerMasters/GetCustomerMasterByCustAbbr/{custAbbr}/{branchNo}");
        //}

        //public async Task<IEnumerable<CustDistirbutionInfo>> LoadDistirbutionPassword(string custName, string branchNo)
        //{
        //    return await _httpClient.GetJsonAsync<CustDistirbutionInfo[]>($"api/CustomerMasters/LoadDistirbutionPassword/{custName}/{branchNo}");
        //}
    }
}
