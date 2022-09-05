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
    public class CustomerMasterService : ICustomerMasterService
    {
        //Task<IEnumerable<CustomerMaster>> LoadCustomerMasterByCustAbbr(string custAbbr, string branchNo);

        private readonly HttpClient httpClient;
        public CustomerMasterService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<CustomerMaster>> LoadCustomerMasterByCustAbbr(string custAbbr, string branchNo)
        {
            //throw new NotImplementedException();
            return await httpClient.GetJsonAsync<CustomerMaster[]>($"api/CustomerMasters/GetCustomerMasterByCustAbbr/{custAbbr}/{branchNo}");
        }
    }
}
