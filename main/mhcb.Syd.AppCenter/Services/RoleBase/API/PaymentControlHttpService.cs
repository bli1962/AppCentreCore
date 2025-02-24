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
    public class PaymentControlHttpService : HttpBaseService, IPaymentControlHttpService
    {
        public PaymentControlHttpService(HttpClient httpClient,
                                        IHttpContextAccessor httpContext,
                                        IJwtToken jwtToken,
                                        ILocalStorageService localStorageService,
                                        IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        public async Task<int> UpdateStatus(InputSwiftPayment status)
        {
            //string myAutication = _httpContext.HttpContext.Session.GetString("GuideAuthorizorCookies");
            //if ((myAutication != null) && myAutication.Contains("Payment Control Auth"))
            //{                
            //}
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "Payment Control Auth")
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            return await _httpClient.PutJsonAsync<int>("api/Payments", status);
        }

        // *************************************************************************************
        // The following Http services has been replaced by Generic http service, because they
        // are not required  [Authorize(Roles = "xxxx")] in Web API
        // B. Li
        // *************************************************************************************


        //public async Task<IEnumerable<SwiftPaymentView>> GetPPTransByDate(string dateValue, string dateType)
        //{
        //    return await _httpClient.GetJsonAsync<SwiftPaymentView[]>($"api/Payments/GetPPTransByDate/{dateValue}/{dateType}");
        //}


    }
}
