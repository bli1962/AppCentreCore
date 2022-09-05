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
    public class FXTransactionService : IFXTransactionService
    {
        //Task<IEnumerable<FxDeliveryView>> GetFxTransactioByDates(string strDateFrom, string strDateTo);
        //Task<IEnumerable<FXTransactionView>> GetFXTransactionByDatesCustAbbr(string strDateFrom, string strDateTo, string dateType, string custName);
        //Task<IEnumerable<FXTransactionView>> GetPendingTrans();
        //Task<FxTransaction> LoadFXTransactionByRefNo(string refNo);
        //Task<string> UpdateStatus(FXTranStatus status);

        private readonly HttpClient httpClient;
        public FXTransactionService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<FxTransaction>> GetFullFXTransactionByDates(string dateFrom, string dateTo, string dateType)
        {
            return await httpClient.GetJsonAsync<FxTransaction[]>($"api/FXTransactions/GetFullFXTransactionByDates/{dateFrom}/{dateTo}/{dateType}");
        }

        public async Task<IEnumerable<FXTransactionView>> GetPendingFxTrans()
        {
            return await httpClient.GetJsonAsync<FXTransactionView[]>($"api/FXTransactions/GetPendingFxTrans");
        }

        public async Task<IEnumerable<FXTransactionView>> GetFxTransByDatesCustAbbr(string dateFrom, string dateTo, string dateType, string custName)
        {
            return await httpClient.GetJsonAsync<FXTransactionView[]>($"api/FXTransactions/GetFxTransByDatesCustAbbr/{dateFrom}/{dateTo}/{dateType}/{custName}");
        }

        public async Task<FxTransaction> GetFxTransByRefNo(string refNo)
        {
            return await httpClient.GetJsonAsync<FxTransaction>($"api/FXTransactions/GetFxTransactioByDates/{refNo}");
        }


        public async Task<int> UpdateStatus(FXTranStatus status)
        {
            return await httpClient.PutJsonAsync<int>("api/FXTransactions", status);
        }

       
    }
}
