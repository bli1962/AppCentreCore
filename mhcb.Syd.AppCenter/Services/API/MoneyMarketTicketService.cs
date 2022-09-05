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
    public class MoneyMarketTicketService : IMoneyMarketTicketService
    {
        //Task<IEnumerable<MoneyMarketReportView>> GetMoneyMarketTransactionByDates(string strDateFrom, string strDateTo);
        //Task<IEnumerable<MoneyMarketTicketView>> GetPendingTrans();
        //Task<string> UpdateStatus(MMGIDStatus status);
        private readonly HttpClient httpClient;
        public MoneyMarketTicketService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<MoneyMarketTicketView>> GetMMGID()
        {
            return await httpClient.GetJsonAsync<MoneyMarketTicketView[]>($"api/MoneyMarketTickets/GetMMGID?");
        }

        public async Task<IEnumerable<MoneyMarketReportView>> GetMMTransByDates(string dateFrom, string dateTo)
        {
            return await httpClient.GetJsonAsync<MoneyMarketReportView[]>($"api/MoneyMarketTickets/GetMMTransByDates/{dateFrom}/{dateTo}");
        }

        public async Task<int> UpdateStatus(MMGIDStatus status)
        {
            return await httpClient.PutJsonAsync<int>("api/MoneyMarketTickets", status);
        }
    }
}
