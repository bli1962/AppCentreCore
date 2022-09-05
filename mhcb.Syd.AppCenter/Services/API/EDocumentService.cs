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
    public class EDocumentService : IEDocumentService
    {
        //Task<IEnumerable<eDocumentView>> GetPendingTrans(string eDocType, string optDate);
        //Task<string> UpdateStatus(EDocumentAttribute eDocAttribute);
        private readonly HttpClient httpClient;
        public EDocumentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<eDocumentView>> GetPendingEDoc(string eDocType, string optDate)
        {
            return await httpClient.GetJsonAsync<eDocumentView[]>($"api/EDocuments/GetPendingEDoc/{eDocType}/{optDate}");
        }

        public async Task<int> UpdateStatus(EDocumentAttribute eDocAttribute)
        {
            return await httpClient.PutJsonAsync<int>("api/EDocuments", eDocAttribute);
        }
    }
}
