using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using mhcb.Syd.AppCenter.Services;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.AppCenter.Services.Interface;
using System.Net.Http.Json;
using System;

namespace mhcb.Syd.AppCenter.Services.API
{
    public class DomesticClearingService : IDomesticClearingService
    {
        private readonly HttpClient httpClient;
        public DomesticClearingService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<DomesticClearingPayment>> GetDCPaymentByDate(string dateValue, string dateType)
        {
            return await httpClient.GetJsonAsync<DomesticClearingPayment[]>($"api/DomesticClearings/GetDCPaymentByDate/{dateValue}/{dateType}");
        }

        public async Task<int> UpdateStatus(DomesticClearingAttribute status)
        {
            return await httpClient.PutJsonAsync<int>("api/DomesticClearings", status);
        }
    }
}
