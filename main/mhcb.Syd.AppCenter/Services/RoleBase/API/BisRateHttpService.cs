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
    public class BisRateHttpService : HttpBaseService, IBisRateHttpService
    {
        public BisRateHttpService(HttpClient httpClient,
                                IHttpContextAccessor httpContext,
                                IJwtToken jwtToken,
                                ILocalStorageService localStorageService,
                                IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        //public async Task<IEnumerable<BisRateViewModel>> GetBisRatesByDate(string dataDate)
        //{
        //    // **Initial version**
        //    //return await _httpClient.GetJsonAsync<BisRateViewModel[]>($"api/BisRate/GetBisRatesByDate/{dataDate}");


        //    // 1.Prepare HttpMessage
        //    var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/BisRate/GetBisRatesByDate/{dataDate}");

        //    // 2.Send httpMessage
        //    var response = await _httpClient.SendAsync(requestMessage);

        //    // 3.Catch response message
        //    var responseStatusCode = response.StatusCode;
        //    var responseBody = await response.Content.ReadAsStringAsync();

        //    if (responseStatusCode == HttpStatusCode.OK)
        //    {
        //        return await Task.FromResult(JsonConvert.DeserializeObject<BisRateViewModel[]>(responseBody));
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //public async Task<BisRateViewModel> GetBisRatesByDateCcyDuration(string dataDate, string ccy, int duration, string unit)
        //{
        //    // **Initial version**
        //    //return await _httpClient.GetJsonAsync<BisRateViewModel>($"api/BisRate/GetBisRatesByDateCcyDuration/{dataDate}/{ccy}/{duration}/{unit}");


        //    // 1.Prepare HttpMessage
        //    var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/BisRate/GetBisRatesByDateCcyDuration/{dataDate}/{ccy}/{duration}/{unit}");

        //    // 2.Send httpMessage
        //    var response = await _httpClient.SendAsync(requestMessage);

        //    // 3.Catch response message
        //    var responseStatusCode = response.StatusCode;
        //    var responseBody = await response.Content.ReadAsStringAsync();

        //    if (responseStatusCode == HttpStatusCode.OK)
        //    {
        //        return await Task.FromResult(JsonConvert.DeserializeObject<BisRateViewModel>(responseBody));
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
   

        public async Task<int> AddBisRate(BisRateViewModel bisRateViewModel)
        {
            // **Initial version**
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "FX_RATE_Authorise"),
                    //new Claim(ClaimTypes.Role, "Manager")
                    //new Claim(ClaimTypes.Role, loginUser.Username),
                    //c1, c2, c3, c4, c5
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            return await _httpClient.PostJsonAsync<int>("api/BisRate", bisRateViewModel);


            // ** pseudo code **
            // 1.Prepare HttpMessage
            //string serializedObject = JsonConvert.SerializeObject(bisRateViewModel);

            //var requestMessage = new HttpRequestMessage(HttpMethod.Post, "api/BisRate");
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

        public async Task<int> UpdateBisRate(BisRateViewModel bisRateViewModel)
        {
            // **Initial version**
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "FX_RATE_Authorise"),
                    //new Claim(ClaimTypes.Role, "Manager")
                    //new Claim(ClaimTypes.Role, loginUser.Username),
                    //c1, c2, c3, c4, c5
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            return await _httpClient.PutJsonAsync<int>("api/BisRate", bisRateViewModel);
        }

        public async Task<string> DeleteBisRate(string dataDate, string ccy, int duration, string unit)
        {
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "FX_RATE_Authorise"),
                    //new Claim(ClaimTypes.Role, "Manager")
                    //new Claim(ClaimTypes.Role, loginUser.Username),
                    //c1, c2, c3, c4, c5
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            var response = await _httpClient.DeleteAsync($"api/BisRate/{dataDate}/{ccy}/{duration}/{unit}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();

            // 1.Prepare HttpMessage
            //var requestMessage = new HttpRequestMessage(HttpMethod.Delete, $"api/BisRate/{dataDate}/{ccy}/{duration}/{unit}");

            //// 2.Send httpMessage
            //var response = await _httpClient.SendAsync(requestMessage);

            //// 3.Catch response message
            //var responseStatusCode = response.StatusCode;
            //var responseBody = await response.Content.ReadAsStringAsync();

            //if (responseStatusCode == HttpStatusCode.OK)
            //{
            //    return await Task.FromResult(true);
            //}
            //else
            //{
            //    return await Task.FromResult(false);
            //}
        }

    }
}
