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
    public class GASService : IGASService
    {
        //Task<IEnumerable<GASDebitView>> GetGASTransByDate(string optDate);
        //Task<string> UpdateDCSStatus(GASAttribute gasAttribute);
        //Task<string> UpdateGASStatus(GASAttribute gasAttribute);

        private readonly HttpClient httpClient;
        public GASService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<GASDebitView>> GetGASTransByDate(string optDate)
        {
            return await httpClient.GetJsonAsync<GASDebitView[]>($"api/GAS/GetGASTransByDate/{optDate}");
        }

        public async Task<int> UpdateDCSStatus(GASAttribute gasAttribute)
        {
            return await httpClient.PutJsonAsync<int>("api/GAS", gasAttribute);
        }
    }
}
