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
    public class LoanMasterTrancheService : ILoanMasterTrancheService
    {
        //Task<IEnumerable<LoanMasterTrancheView>> GetCovenantCheckList();
        //Task<IEnumerable<LoanMasterTrancheView>> GetLiborDiscontinuation();
        private readonly HttpClient httpClient;
        public LoanMasterTrancheService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<LoanMasterTrancheView>> GetCovenantCheckList()
        {

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LoanMasterTrancheView>> GetLiborDiscontinuation()
        {
            throw new NotImplementedException();
        }
    }
}
