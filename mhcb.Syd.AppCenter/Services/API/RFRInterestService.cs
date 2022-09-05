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
    public class RFRInterestService : IRFRInterestService
    {
        //Task<IEnumerable<RFRInterestLoanView>> GetRFRInterestForLoanByReportDate(string strReportDate, string custAbbr);
        //Task<IEnumerable<RFRInterestSwapView>> GetRFRInterestForSwapByReportDate(string strReportDate, string custAbbr);

        private readonly HttpClient httpClient;
        public RFRInterestService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<RFRInterestLoanView>> GetRFRInterestForLoanByReportDate(string reportDate, string custAbbr)
        {
            return await httpClient.GetJsonAsync<RFRInterestLoanView[]>($"api/RFRInterests/GetRFRLoanInterest/{reportDate}/{custAbbr}");
        }

        public async Task<IEnumerable<RFRInterestSwapView>> GetRFRInterestForSwapByReportDate(string reportDate, string custAbbr)
        {
            return await httpClient.GetJsonAsync<RFRInterestSwapView[]>($"api/RFRInterests/GetRFRSwapInterest/{reportDate}/{custAbbr}");
        }
    }
}
