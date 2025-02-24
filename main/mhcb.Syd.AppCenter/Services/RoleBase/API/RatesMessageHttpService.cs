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
    public class RatesMessageHttpService: HttpBaseService, IRatesMessageHttpService
    {
        public RatesMessageHttpService(HttpClient httpClient,
                                IHttpContextAccessor httpContext,
                                IJwtToken jwtToken,
                                ILocalStorageService localStorageService,
                                IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        public async Task<int> SendMessageToQueue(MessageDTO messageDto)
        {
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "FX_RATE_Authorise"),
                    //new Claim(ClaimTypes.Role, "Manager")
                    //new Claim(ClaimTypes.Role, loginUser.Username),
                    //c1, c2, c3, c4, c5
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            return await _httpClient.PostJsonAsync<int>("api/RatesMessage", messageDto);

            //// 1.Prepare HttpMessage
            //string serializedObject = JsonConvert.SerializeObject(messageDto);

            //var requestMessage = new HttpRequestMessage(HttpMethod.Post, "api/RatesMessage");
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
    }
}
