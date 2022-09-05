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
    public class FXFCustService : IFXFCustService
    {
        //Task<IEnumerable<FXFCustomerView>> LoadFXCustByCustAbbr(string abbreviation);
        //Task<string> UpdateStatus(FXFCustAttribute custAttr);

        private readonly HttpClient httpClient;
        public FXFCustService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<FXFCustomerView>> GetMMCustByAbbr(string abbreviation)
        {
            return await httpClient.GetJsonAsync<FXFCustomerView[]>($"api/FXFCusts/GetMMCustByAbbr/{abbreviation}");
        }

        public async Task<int> UpdateStatus(FXFCustAttribute custAttr)
        {
            return await httpClient.PutJsonAsync<int>("api/FXFCusts", custAttr);
        }
    }
}
