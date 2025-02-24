using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
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
    public class FXDeliveryHttpService : HttpBaseService, IFXDeliveryHttpService
    {
        public FXDeliveryHttpService(HttpClient httpClient,
                                    IHttpContextAccessor httpContext,
                                    IJwtToken jwtToken,
                                    ILocalStorageService localStorageService,
                                    IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        public async Task<int> UpdateStatus(InputFXTrans status)
        {
            //string myAutication = _httpContext.HttpContext.Session.GetString("GuideAuthorizorCookies");
            //if ((myAutication != null) && myAutication.Contains("FX-Delivery - Author"))
            //{          
            //}
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "FX-Delivery - Author")
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            return await _httpClient.PutJsonAsync<int>("api/FXDeliverys", status);
        }

        public async Task<IEnumerable<FXDeliveryView>> GetPendingFxDelivery()
        {
            return await _httpClient.GetJsonAsync<FXDeliveryView[]>($"api/FXDeliverys/GetPendingFxDelivery");

            //https://localhost:44356/api/FXDeliverys/GetPendingFxDelivery
        }

        // *************************************************************************************
        // The following Http services has been replaced by Generic http service, because they
        // are not required  [Authorize(Roles = "xxxx")] in Web API
        // B. Li
        // *************************************************************************************

        //public async Task<IEnumerable<FxDeliveryView>> GetFxDeliveryByDates(string dateFrom, string dateTo)
        //{
        //    return await _httpClient.GetJsonAsync<FxDeliveryView[]>($"api/FXDeliverys/GetFxDeliveryByDates/{dateFrom}/{dateTo}");
        //}

        //public async Task<IEnumerable<FxDeliveryView>> GetFxDeliveryCorpByDate(string deliveryDate)
        //{
        //    return await _httpClient.GetJsonAsync<FxDeliveryView[]>($"api/FXDeliverys/GetFxDeliveryCorpByDate/{deliveryDate}");
        //}

        //public async Task<IEnumerable<FxDeliveryCorpSummaryView>> GetFxDeliveryCorpSummaryByDate(string deliverySummryDate)
        //{
        //    return await _httpClient.GetJsonAsync<FxDeliveryCorpSummaryView[]>($"api/FXDeliverys/GetFxDeliveryCorpSummaryByDate/{deliverySummryDate}");
        //}

        //public async Task<FxSettlementInf> GetFXSettlementByRefNo(string refNo)
        //{
        //    return await _httpClient.GetJsonAsync<FxSettlementInf>($"api/FXDeliverys/GetFxDeliveryByRefNo/{refNo}");
        //}


    }
}
