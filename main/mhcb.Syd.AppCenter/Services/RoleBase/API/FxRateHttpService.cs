using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Security.Claims;

using Blazored.LocalStorage;

using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Components;

using mhcb.Syd.AppCenter.Services.RoleBase.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class FxRateHttpService : HttpBaseService, IFxRateHttpService
    {
        public FxRateHttpService(HttpClient httpClient,
                                    IHttpContextAccessor httpContext,
                                    IJwtToken jwtToken,
                                    ILocalStorageService localStorageService,
                                    IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        //public async Task<IEnumerable<FxRateViewModel>> GetFxRatesByDate(string dataDate)
        //{
        //    return await _httpClient.GetJsonAsync<FxRateViewModel[]>($"api/FxRate/GetFxRatesByDate/{dataDate}");
        //}

        //public async Task<FxRateViewModel> GetFxRateByDateCcy(string dataDate, string ccy)
        //{
        //    return await _httpClient.GetJsonAsync<FxRateViewModel>($"api/FxRate/GetFxRateByDateCcy/{dataDate}/{ccy}");
        //}

        public async Task<int> AddFxRate(FxRateViewModel fxRateViewModel)
        {
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "FX_RATE_Authorise"),
                    //new Claim(ClaimTypes.Role, "Manager")
                    //new Claim(ClaimTypes.Role, loginUser.Username),
                    //c1, c2, c3, c4, c5
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            return await _httpClient.PostJsonAsync<int>("api/FxRate", fxRateViewModel);

            // ** pseudo code **
            // 1.Prepare HttpMessage
            //string serializedObject = JsonConvert.SerializeObject(fxRateViewModel);

            //var requestMessage = new HttpRequestMessage(HttpMethod.Post, "api/FxRate");
            //requestMessage.Content = new StringContent(serializedObject);
            //requestMessage.Content.Headers.ContentType
            //               = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            //// 2.Send httpMessage
            //var response = await _httpClient.SendAsync(requestMessage);

            //// 3.Catch response message
            //var responseStatusCode = response.StatusCode;
            //var responseBody = await response.Content.ReadAsStringAsync();

            //var returnedObj = JsonConvert.DeserializeObject<int>(responseBody);
            //return await Task.FromResult(returnedObj);
        }

        public async Task<string> DeleteFxRate(string dataDate, string ccy)
        {
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "FX_RATE_Authorise"),
                    //new Claim(ClaimTypes.Role, "Manager")
                    //new Claim(ClaimTypes.Role, loginUser.Username),
                    //c1, c2, c3, c4, c5
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            var response = await _httpClient.DeleteAsync($"api/FxRate/{dataDate}/{ccy}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<int> UpdateFxRate(FxRateViewModel fxRateViewModel)
        {

            var claims = new[] {
                    new Claim(ClaimTypes.Role, "FX_RATE_Authorise"),
                    //new Claim(ClaimTypes.Role, "Manager")
                    //new Claim(ClaimTypes.Role, loginUser.Username),
                    //c1, c2, c3, c4, c5
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            return await _httpClient.PutJsonAsync<int>("api/FxRate", fxRateViewModel);
        }
    }
}
