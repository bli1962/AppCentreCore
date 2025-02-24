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
    public class SwapRateHttpService : HttpBaseService, ISwapRateHttpService
    {
        public SwapRateHttpService(HttpClient httpClient,
                                    IHttpContextAccessor httpContext,
                                    IJwtToken jwtToken,
                                    ILocalStorageService localStorageService,
                                    IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        //public async Task<IEnumerable<SwapRateViewModel>> GetSwapRatesByDate(string dataDate)
        //{
        //    return await _httpClient.GetJsonAsync<SwapRateViewModel[]>($"api/SwapRate/GetSwapRatesByDate/{dataDate}");
        //}

        //public async Task<SwapRateViewModel> GetSwapRateByDateCcyDuration(string dataDate, string ccy, int duration, string unit)
        //{
        //    return await _httpClient.GetJsonAsync<SwapRateViewModel>($"api/SwapRate/GetSwapRateByDateCcyDuration/{dataDate}/{ccy}/{duration}/{unit}");
        //}

        public async Task<int> AddSwapRate(SwapRateViewModel swapRateViewModel)
        {
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "FX_RATE_Authorise"),
                    //new Claim(ClaimTypes.Role, "Manager")
                    //new Claim(ClaimTypes.Role, loginUser.Username),
                    //c1, c2, c3, c4, c5
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            return await _httpClient.PostJsonAsync<int>("api/SwapRate", swapRateViewModel);

            // ** pseudo code **
            // 1.Prepare HttpMessage
            //string serializedObject = JsonConvert.SerializeObject(swapRateViewModel);

            //var requestMessage = new HttpRequestMessage(HttpMethod.Post, "api/SwapRate");
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

        public async Task<string> DeleteSwapRate(string dataDate, string ccy, int duration, string unit)
        {
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "FX_RATE_Authorise"),
                    //new Claim(ClaimTypes.Role, "Manager")
                    //new Claim(ClaimTypes.Role, loginUser.Username),
                    //c1, c2, c3, c4, c5
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            var response = await _httpClient.DeleteAsync($"api/SwapRate/{dataDate}/{ccy}/{duration}/{unit}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<int> UpdateSwapRate(SwapRateViewModel swapRateViewModel)
        {
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "FX_RATE_Authorise"),
                    //new Claim(ClaimTypes.Role, "Manager")
                    //new Claim(ClaimTypes.Role, loginUser.Username),
                    //c1, c2, c3, c4, c5
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            return await _httpClient.PutJsonAsync<int>("api/SwapRate", swapRateViewModel);
        }
    }
}
