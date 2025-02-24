using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;
using Blazored.LocalStorage;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class GASHttpService : HttpBaseService, IGASService
    {
        public GASHttpService(HttpClient httpClient,
                                IHttpContextAccessor httpContext,
                                IJwtToken jwtToken,
                                ILocalStorageService localStorageService,
                                IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        public async Task<int> UpdateDCSStatus(InputGAS gasAttribute)
        {
            //string myAutication = _httpContext.HttpContext.Session.GetString("GuideAuthorizorCookies");
            //if ((myAutication != null) && myAutication.Contains("FX-Trans - Authorise"))
            //{            
            //}
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "FX-Trans - Authorise")
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            return await _httpClient.PutJsonAsync<int>("api/GAS", gasAttribute);
        }

        // *************************************************************************************
        // The following Http services has been replaced by Generic http service, because they
        // are not required  [Authorize(Roles = "xxxx")] in Web API
        // B. Li
        // *************************************************************************************

        //public async Task<IEnumerable<GASDebitView>> GetGASTransByDate(string optDate)
        //{
        //    return await _httpClient.GetJsonAsync<GASDebitView[]>($"api/GAS/GetGASTransByDate/{optDate}");
        //}


    }
}
