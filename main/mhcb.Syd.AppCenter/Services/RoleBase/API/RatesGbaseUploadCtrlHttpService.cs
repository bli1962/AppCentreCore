using mhcb.Syd.Models;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Blazored.LocalStorage;
using Microsoft.Extensions.Configuration;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class RatesGbaseUploadCtrlHttpService :HttpBaseService, IRatesGbaseUploadCtrlHttpService
    {
        public RatesGbaseUploadCtrlHttpService(HttpClient httpClient,
                               IHttpContextAccessor httpContext,
                               IJwtToken jwtToken,
                               ILocalStorageService localStorageService,
                               IConfiguration configuration)
           : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        public async Task<bool> Create_GbaseRates_Upload_Ctrl(RatesControlPostDTO ratesControlPostDto)
        {
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "FX_RATE_Authorise"),
                    //new Claim(ClaimTypes.Role, "Manager")
                    //new Claim(ClaimTypes.Role, loginUser.Username),
                    //c1, c2, c3, c4, c5
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            return await _httpClient.PostJsonAsync<bool>("api/RatesGbaseUploadCtl", ratesControlPostDto);
        }
    }
}
