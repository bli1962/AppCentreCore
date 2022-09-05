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
    public class DistributionPreferenceService : IDistributionPreferenceService
    {
        private readonly HttpClient httpClient;
        public DistributionPreferenceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<DistributionPreferenceView>> GetDistributionPreference()
        {
            //throw new NotImplementedException();
            return await httpClient.GetJsonAsync<DistributionPreferenceView[]>($"api/Distribution/GetDistributionPreference");
        }
    }
}
