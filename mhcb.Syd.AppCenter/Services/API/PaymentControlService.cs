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
    public class PaymentControlService : IPaymentControlService
    {
        //Task<string> DeleteSwiftPayment(SwiftPaymentStatus status);
        //Task<IEnumerable<SwiftPaymentView>> GetPaymentControlPaymentByDate(string strDateValue, string dateType);
        //Task<IEnumerable<SwiftPaymentView>> GetSwiftPaymentByDate(string strDateValue, string dateType);
        //Task<string> UpdateStatus(SwiftPaymentStatus status);
        private readonly HttpClient httpClient;
        public PaymentControlService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<SwiftPaymentView>> GetPPTransByDate(string dateValue, string dateType)
        {
            return await httpClient.GetJsonAsync<SwiftPaymentView[]>($"api/Payments/GetPPTransByDate/{dateValue}/{dateType}");
        }

        public async Task<int> UpdateStatus(SwiftPaymentStatus status)
        {
            return await httpClient.PutJsonAsync<int>("api/Payments", status);
        }
        public Task<int> DeleteSwiftPayment(SwiftPaymentStatus status)
        {
            throw new NotImplementedException();
        }

    }
}
