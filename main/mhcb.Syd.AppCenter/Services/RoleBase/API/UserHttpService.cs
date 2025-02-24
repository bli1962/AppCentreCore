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
    public class UserHttpService : HttpBaseService, IUserHttpService
    {
        public UserHttpService(HttpClient httpClient,
                                IHttpContextAccessor httpContext,
                                IJwtToken jwtToken,
                                ILocalStorageService localStorageService,
                                IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        public async Task<IEnumerable<UserView>> LoadGuidePasswordByUserId(string userId)
        {
            return await _httpClient.GetJsonAsync<UserView[]>($"api/Users/GetGuidePasswordByUserId/{userId}");
        }

        public async Task<int> UpdateStatus(InputGuideUser userAttr)
        {
            return await _httpClient.PutJsonAsync<int>("api/Users", userAttr);
        }

        // *************************************************************************************
        // The following Http services has been replaced by Generic http service, because they
        // are not required  [Authorize(Roles = "xxxx")] in Web API
        // B. Li
        // *************************************************************************************

        //public async Task<IEnumerable<UserView>> GetUserByStatus(string status)
        //{
        //    return await _httpClient.GetJsonAsync<UserView[]>($"api/Users/GetUserByStatus/{status}");
        //}

        //public async Task<IEnumerable<UserView>> GetUserById(string userId)
        //{
        //    return await _httpClient.GetJsonAsync<UserView[]>($"api/Users/GetUserById/{userId}");
        //}

        // used by Razor page 
        // class ForgotGuidePasswordModel : PageModel


    }
}
