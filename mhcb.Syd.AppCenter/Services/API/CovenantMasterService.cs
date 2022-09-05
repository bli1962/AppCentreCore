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
    public class CovenantMasterService : ICovenantMasterService
    {
        //Task<IEnumerable<CovenantMasterRecordView>> GetCovenantMasterRecord();
        //Task<IEnumerable<CovenantRatioView>> GetCovenantRatio(string covenantType);

        private readonly HttpClient httpClient;
        public CovenantMasterService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<CovenantMasterRecordView>> GetCovenantMasterRecord()
        {
            return await httpClient.GetJsonAsync<CovenantMasterRecordView[]>($"api/CovenantMasters/GetCovenantMasterRecord");
        }

        public async Task<IEnumerable<CovenantRatioView>> GetCovenantRatio(string covenantType, string dateType, string dateFrom, string dateTo)
        {
            return await httpClient.GetJsonAsync<CovenantRatioView[]>($"api/CovenantMasters/GetCovenantRatio/{covenantType}/{dateType}/{dateFrom}/{dateTo}");
        }
    }
}
