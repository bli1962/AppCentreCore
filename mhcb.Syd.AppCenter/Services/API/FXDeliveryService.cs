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
    public class FXDeliveryService : IFXDeliveryService
    {
        //Task<IEnumerable<FxDeliveryView>> GetfxDeliveryCorpByDate(string strDeliveryDate);
        //Task<IEnumerable<FxDeliveryCorpSummaryView>> GetfxDeliveryCorpSummaryByDate(string strDeliveryDate);
        //Task<IEnumerable<FXDeliveryView>> GetPendingTrans();
        //Task<FxSettlementInf> LoadFXSettlementByRefNo(string refNo);
        //Task<string> UpdateStatus(FXTranStatus status);

        private readonly HttpClient httpClient;
        public FXDeliveryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<FXDeliveryView>> GetPendingFxDelivery()
        {
            return await httpClient.GetJsonAsync<FXDeliveryView[]>($"api/FXDeliverys/GetPendingFxDelivery");

            //https://localhost:44356/api/FXDeliverys/GetPendingFxDelivery
        }

        public async Task<IEnumerable<FxDeliveryView>> GetFxDeliveryByDates(string dateFrom, string dateTo)
        {
            return await httpClient.GetJsonAsync<FxDeliveryView[]>($"api/FXDeliverys/GetFxDeliveryByDates/{dateFrom}/{dateTo}");
        }


        public async Task<IEnumerable<FxDeliveryView>> GetFxDeliveryCorpByDate(string deliveryDate)
        {
            //throw new NotImplementedException();
            return await httpClient.GetJsonAsync<FxDeliveryView[]>($"api/FXDeliverys/GetFxDeliveryCorpByDate/{deliveryDate}");
        }

        public async Task<IEnumerable<FxDeliveryCorpSummaryView>> GetFxDeliveryCorpSummaryByDate(string deliverySummryDate)
        {
            return await httpClient.GetJsonAsync<FxDeliveryCorpSummaryView[]>($"api/FXDeliverys/GetFxDeliveryCorpSummaryByDate/{deliverySummryDate}");
        }

        public async Task<FxSettlementInf> GetFXSettlementByRefNo(string refNo)
        {
            return await httpClient.GetJsonAsync<FxSettlementInf>($"api/FXDeliverys/GetFxDeliveryByRefNo/{refNo}");
        }
      
        public async Task<int> UpdateStatus(FXTranStatus status)
        {
            return await httpClient.PutJsonAsync<int>("api/FXDeliverys", status);
        }

        
    }
}
