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
    public class EUCBalanceEventService : IEUCBalanceEventService
    {
        //Task<IEnumerable<MxEucBalanceEvent>> GetEUCBalanceEventByCustAbbr(string custAbbr, string optDate);
        //Task<IEnumerable<MxEucBalanceEvent>> GetEUCBalanceEventByRefno(string refNo, string optDate);
        //Task<IEnumerable<MxInboundEventLogView>> GetMxInboundEventLogBySender(string sender, string optDate);
        //Task<IEnumerable<MxEucBalanceEventView>> GetPendingTrans();
        //Task<string> UpdateStatus(EucBalanceAttribute balanceAttribute);
        private readonly HttpClient httpClient;
        public EUCBalanceEventService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<MxEucBalanceEvent>> GetEUCBalanceEventByCustAbbr(string custAbbr, string optDate)
        {
            return await httpClient.GetJsonAsync<MxEucBalanceEvent[]>($"api/EUCBalanceEvents/GetEUCBalanceEventByCustAbbr/{custAbbr}/{optDate}");
        }

        public async Task<IEnumerable<MxEucBalanceEvent>> GetEUCBalanceEventByRefno(string refNo, string optDate)
        {
            return await httpClient.GetJsonAsync<MxEucBalanceEvent[]>($"api/EUCBalanceEvents/GetEUCBalanceEventByRefno/{refNo}/{optDate}");
        }

        public async Task<IEnumerable<MxInboundEventLogView>> GetMxInboundEventLogBySender(string sender, string optDate)
        {
            return await httpClient.GetJsonAsync<MxInboundEventLogView[]>($"api/EUCBalanceEvents/GetMxInboundEventLogBySender/{sender}/{optDate}");
        }

        public async Task<IEnumerable<MxEucBalanceEventView>> GetPendingEUCBalanceEvent(string UpdateDdate)
        {
            return await httpClient.GetJsonAsync<MxEucBalanceEventView[]>($"api/EUCBalanceEvents/GetPendingEUCBalanceEvent/{UpdateDdate}");
        }

        public async Task<int> UpdateStatus(EucBalanceAttribute balanceAttribute)
        {
            return await httpClient.PutJsonAsync<int>("api/EUCBalanceEvents", balanceAttribute);
        }
    }
}
