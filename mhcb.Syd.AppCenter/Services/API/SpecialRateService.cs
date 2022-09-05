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
    public class SpecialRateService : ISpecialRateService
    {
        //Task<IEnumerable<ExchRateView>> LoadSpcialRate();
        //Task<string> UpdateStatus(RateAttribute rate);
        private readonly HttpClient httpClient;
        public SpecialRateService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ExchRateView>> GetMizuhoRates()
        {
            return await httpClient.GetJsonAsync<ExchRateView[]>($"api/SpecialRates/GetMizuhoRates");
        }

        public async Task<int> UpdateStatus(RateAttribute rate)
        {
            return await httpClient.PutJsonAsync<int>("api/SpecialRates", rate);
        }
    }
}
