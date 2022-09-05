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
    public class FXTransactionExtService : IFXTransactionExtService
    {
        //Task<IEnumerable<FXTransactionExtView>> GetPendingTrans();
        // Task<string> UpdateStatus(FXGIDStatus status);
        private readonly HttpClient httpClient;
        public FXTransactionExtService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<FXTransactionExtView>> GetFXGID()
        {
            return await httpClient.GetJsonAsync<FXTransactionExtView[]>($"api/FXTransactionExts/GetFXGID");
        }

        public async Task<int> UpdateStatus(FXGIDStatus status)
        {
            return await httpClient.PutJsonAsync<int>("api/FXTransactionExts", status);
        }
    }
}
