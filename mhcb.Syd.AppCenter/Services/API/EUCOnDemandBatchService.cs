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

namespace mhcb.Syd.Interface
{
    public class EUCOnDemandBatchService : IEUCOnDemandBatchService
    {
        //Task<IEnumerable<OnDemandBatchLogView>> GetOnDemandBatchLogByBatchNo(string strBatchId);
        //Task<IEnumerable<OnDemandBatchView>> GetOnDemandBatchNoByDate(string createdDate);
        // Task<string> UpdateStatus(OnDemandBatchAttribute onDemandBatchAttribute);
        private readonly HttpClient httpClient;
        public EUCOnDemandBatchService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<OnDemandBatchView>> GetOnDemandBatchNoByDate()
        {
            return await httpClient.GetJsonAsync<OnDemandBatchView[]>($"api/EUCOnDemandBatchs/GetOnDemandBatchNoByDate");
        }

        public async Task<IEnumerable<OnDemandBatchView>> GetOnDemandBatchLogByBatchNo(string batchId)
        {
            return await httpClient.GetJsonAsync<OnDemandBatchView[]>($"api/EUCOnDemandBatchs/GetOnDemandBatchLogByBatchNo/{batchId}");
        }

        public async Task<int> UpdateStatus(OnDemandBatchAttribute onDemandBatchAttribute)
        {
            return await httpClient.PutJsonAsync<int>("api/EUCOnDemandBatchs", onDemandBatchAttribute);
        }

       
    }
}
