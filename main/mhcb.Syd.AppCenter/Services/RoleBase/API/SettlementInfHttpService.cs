using System.Threading.Tasks;
using mhcb.Syd.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Headers;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Blazored.LocalStorage;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class SettlementInfHttpService : HttpBaseService, ISettlementInfHttpService
    {
        public SettlementInfHttpService(HttpClient httpClient,
                                        IHttpContextAccessor httpContext,
                                        IJwtToken jwtToken,
                                        ILocalStorageService localStorageService,
                                        IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        public async Task<int> UpdateStatus(InputSIF status)
        {
            //string myAutication = _httpContext.HttpContext.Session.GetString("GuideAuthorizorCookies");
            //if ((myAutication != null) && myAutication.Contains("SIF - Authorise"))
            //{             
            //}
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "SIF - Authorise")
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            return await _httpClient.PutJsonAsync<int>("api/SettlementInfs", status);
        }

        //public async Task<int> InsertSettlementInf(SettlementInf settlement_inf)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<int> DeleteSettlementInf(int id)
        //{
        //    throw new NotImplementedException();
        //}


        // *************************************************************************************
        // The following Http services has been replaced by Generic http service, because they
        // are not required  [Authorize(Roles = "xxxx")] in Web API
        // B. Li
        // *************************************************************************************


        //public async Task<IEnumerable<SettlementInfView>> GetPendingSIF()
        //{
        //    return await _httpClient.GetJsonAsync<SettlementInfView[]>($"api/SettlementInfs/GetPendingSIF");
        //}

        //public async Task<IEnumerable<SettlementInfView>> GetSifInstructionsByStatus(string status)
        //{
        //    return await _httpClient.GetJsonAsync<SettlementInfView[]>($"api/SettlementInfs/GetSifInstructionsByStatus/{status}");
        //}
        //public async Task<IEnumerable<SettlementInfView>> GetSIFById(int Id)
        //{
        //    return await _httpClient.GetJsonAsync<SettlementInfView[]>($"api/SettlementInfs/GetSIFById/{Id}");
        //}

        //public async Task<IEnumerable<SettlementInfView>> GetSIFByCustAbbr(string custAbbr)
        //{
        //    return await _httpClient.GetJsonAsync<SettlementInfView[]>($"api/SettlementInfs/GetSIFByCustAbbr/{custAbbr}");
        //}

        //public async Task<IEnumerable<SettlementInfView>> GetSIFByCustAbbrCcyCDRecKind(string custAbbr, string ccyCD, string recordKind)
        //{
        //    return await _httpClient.GetJsonAsync<SettlementInfView[]>($"api/SettlementInfs/GetSIFByCustAbbrCcyCDRecKind/{custAbbr}/{ccyCD}/{recordKind}");
        //}

        //public async Task<IEnumerable<SettlementInf>> GetSIFByStatus(string status)
        //{
        //    return await _httpClient.GetJsonAsync<SettlementInf[]>($"api/SettlementInfs/GetSIFByStatus/{status}");
        //}


    }
}
