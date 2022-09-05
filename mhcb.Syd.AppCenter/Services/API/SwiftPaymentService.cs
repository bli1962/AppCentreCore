using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.API
{
    public class SwiftPaymentService : ISwiftPaymentService
    {
        private readonly HttpClient httpClient;
        public SwiftPaymentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
      
        public async Task<IEnumerable<SwiftPaymentView>> GetSwiftPTransByDate(string optDate, string dateType)
        {
            return await httpClient.GetJsonAsync<SwiftPaymentView[]>($"api/SwiftPayments/GetSwiftPTransByDate/{optDate}/{dateType}");
        }

        async Task<int> ISwiftPaymentService.DeleteSwiftPayment(SwiftPaymentStatus status)
        {
            throw new NotImplementedException();
            //return await httpClient.DeleteAsync<int>("api/SwiftPayments/Delete/", status);
        }

       

    }
}
