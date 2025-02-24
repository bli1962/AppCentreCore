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
    public class EUCBalanceEventHttpService : HttpBaseService, IEUCBalanceEventHttpService
    {
        public EUCBalanceEventHttpService(HttpClient httpClient,
                                            IHttpContextAccessor httpContext,
                                            IJwtToken jwtToken,
                                            ILocalStorageService localStorageService,
                                            IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        public async Task<int> UpdateStatus(InputEucBalance balanceAttribute)
        {
            //string myAutication = _httpContext.HttpContext.Session.GetString("GuideAuthorizorCookies");
            //if ((myAutication != null) && myAutication.Contains("Money Market Modify"))
            //{            
            //}
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "Money Market Modify")
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            return await _httpClient.PutJsonAsync<int>("api/EUCBalanceEvents", balanceAttribute);
        }

        // *************************************************************************************
        // The following Http services has been replaced by Generic http service, because they
        // are not required  [Authorize(Roles = "xxxx")] in Web API
        // B. Li
        // *************************************************************************************

        //public async Task<IEnumerable<MxEucBalanceEventView>> GetEUCBalanceEventByCustAbbr(string custAbbr, string optDate)
        //{
        //    return await _httpClient.GetJsonAsync<MxEucBalanceEventView[]>($"api/EUCBalanceEvents/GetEUCBalanceEventByCustAbbr/{custAbbr}/{optDate}");
        //}

        //public async Task<IEnumerable<MxEucBalanceEventView>> GetEUCBalanceEventByRefno(string refNo, string optDate)
        //{
        //    return await _httpClient.GetJsonAsync<MxEucBalanceEventView[]>($"api/EUCBalanceEvents/GetEUCBalanceEventByRefno/{refNo}/{optDate}");
        //}

        //public async Task<IEnumerable<MxInboundEventLogView>> GetMxInboundEventLogBySender(string sender, string optDate)
        //{
        //    return await _httpClient.GetJsonAsync<MxInboundEventLogView[]>($"api/EUCBalanceEvents/GetMxInboundEventLogBySender/{sender}/{optDate}");
        //}

        //public async Task<IEnumerable<MxEucBalanceEventView>> GetPendingEUCBalanceEvent(string UpdateDdate)
        //{
        //    return await _httpClient.GetJsonAsync<MxEucBalanceEventView[]>($"api/EUCBalanceEvents/GetPendingEUCBalanceEvent/{UpdateDdate}");
        //}

        //public async Task<IEnumerable<MxEucBalanceView>> GetEUCBalanceEvents(string optDate)
        //{
        //    return await _httpClient.GetJsonAsync<MxEucBalanceView[]>($"api/EUCBalanceEvents/GetEucBalanceEvents/{optDate}");
        //}


    }
}
