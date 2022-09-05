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
    public class FacilityMasterLoanTransService : IFacilityMasterLoanTransService
    {
        //Task<IEnumerable<FacilityMasterLoanTransView>> GetLoanTransactionByCcyDates(string strDateFrom, string strDateTo, string ccy);
        //Task<IEnumerable<FacilityMasterLoanTransView>> GetLoanTransactionByDates(string strDateFrom, string strDateTo);

        private readonly HttpClient httpClient;
        public FacilityMasterLoanTransService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<FacilityMasterLoanTransView>> GetLoanTransactionByCcyDates(string dateFrom, string dateTo)
        {
            return await httpClient.GetJsonAsync<FacilityMasterLoanTransView[]>($"api/FacilityMasterLoanTrans/GetLoanTransactionByDates/{dateFrom}/{dateTo}");
        }

        public async Task<IEnumerable<FacilityMasterLoanTransView>> GetLoanTransactionByDatesCcy(string dateFrom, string dateTo, string ccy)
        {
            return await httpClient.GetJsonAsync<FacilityMasterLoanTransView[]>($"api/FacilityMasterLoanTrans/GetLoanTransactionByDatesCcy/{dateFrom}/{dateTo}/{ccy}");
        }
    }
}
