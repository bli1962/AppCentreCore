using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.AppCenter.Services.Interface;
using System.Net.Http;
using Microsoft.AspNetCore.Components;


namespace mhcb.Syd.AppCenter.Services.API
{
    public class SettlementInfService : ISettlementInfService
    {
        //Task<IEnumerable<SettlementInfView>> GetPendingTrans();
        //Task<string> InsertSettlementInf(SettlementInf settlement_inf);
        //Task<IEnumerable<SettlementInfView>> LoadSettlementInfByCustAbbr(string custAbbr);
        //Task<IEnumerable<SettlementInfView>> LoadSettlementInfByDetails(string custAbbr, string ccyCD, string recordKind);
        //Task<IEnumerable<SettlementInfView>> LoadSettlementInfBySifId(int id);
        //Task<IEnumerable<SettlementInf>> LoadSettlementInfsByStatus(string status = "All");
        //Task<string> DeleteSettlementInf(int id);
        //Task<string> UpdateStatus(SIFStatus status);

        
        private readonly HttpClient httpClient;
        public SettlementInfService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

     
        public async Task<IEnumerable<SettlementInfView>> GetPendingSIF()
        {
            return await httpClient.GetJsonAsync<SettlementInfView[]>($"api/SettlementInfs/GetPendingSIF");
        }
       
        public async Task<IEnumerable<SettlementInfView>> GetSifInstructionsByStatus(string status)
        {

            return await httpClient.GetJsonAsync<SettlementInfView[]>($"api/SettlementInfs/GetSifInstructionsByStatus/{status}");
        }
        public async Task<IEnumerable<SettlementInfView>> GetSIFById(int Id)
        {

            return await httpClient.GetJsonAsync<SettlementInfView[]>($"api/SettlementInfs/GetSIFById/{Id}");
        }

        public async Task<IEnumerable<SettlementInfView>> GetSIFByCustAbbr(string custAbbr)
        {
            return await httpClient.GetJsonAsync<SettlementInfView[]>($"api/SettlementInfs/GetSIFByCustAbbr/{custAbbr}");
        }

        public async Task<IEnumerable<SettlementInfView>> GetSIFByCustAbbrCcyCDRecKind(string custAbbr, string ccyCD, string recordKind)
        {
            return await httpClient.GetJsonAsync<SettlementInfView[]>($"api/SettlementInfs/GetSIFByCustAbbrCcyCDRecKind/{custAbbr}/{ccyCD}/{recordKind}");
        }

        public async Task<IEnumerable<SettlementInf>> GetSIFByStatus(string status)
        {
            return await httpClient.GetJsonAsync<SettlementInf[]>($"api/SettlementInfs/GetSIFByStatus/{status}");
        }

        public async Task<int> UpdateStatus(SIFStatus status)
        {
            //throw new System.NotImplementedException();
            return await httpClient.PutJsonAsync<int>("api/SettlementInfs", status);
        }

        public async Task<int> InsertSettlementInf(SettlementInf settlement_inf)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteSettlementInf(int id)
        {
            throw new NotImplementedException();
        }

    }
}
