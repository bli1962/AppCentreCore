using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using mhcb.Syd.AppCenter.Services;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.AppCenter.Services.Interface;
using System.Net.Http.Json;

//Note: you need to install
//Install-Package Microsoft.AspNetCore.Blazor.HttpClient -Version 3.2.0-preview2.20160.5
//https://www.nuget.org/stats/packages/Microsoft.AspNetCore.Blazor.HttpClient?groupby=Version
//  Install-Package Microsoft.AspNetCore.Blazor.HttpClient -Version 3.2.0-preview3.20168.3

//This package has been deprecated as it is legacy and is no longer maintained
//Additional Details
//Blazor WebAssembly 3.2 is no longer supported. Please update to the latest supported version.

// How to call REST APi from Blazor Component
// Step 1: Create service class implement its interface
// Step 2: Register the HttpClient service from ConfigureService() method in startup class
// Step 3: Inject the MS httpClient service class in our build-in service
// Step 4: Call the method of build-in service from Blazor component Base class

//https://localhost:44322/api/BankInfs/getPendingBIF

//https://localhost:44322/api/BankInfs/getBIFByCustName?custName=KRAAAL&branchNo=751

//https://localhost:44322/api/BankInfs/getBIFBySwiftID?swiftId=BACRIT22MIL

//https://localhost:44322/api/BankInfs/getBIFByStatus?status=S

//https://localhost:44322/api/BankInfs
//{
//  "swifT_ID": "BACRIT22CAR",
//  "authorizE_BY": "SYSTEM",
//  "status": "S",
//  "deletioN_STATUS": "",
//  "giP_STATUS": "15",
//  "giP_DESCRIPTION": "test",
//  "traN_NO": "88"
//}

namespace mhcb.Syd.AppCenter.Services.API
{
    public class BankInfService : IBankInfService
    {
        private readonly HttpClient httpClient;
        public BankInfService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<BankInfView>> GetPendingBIF()
        {
             return await httpClient.GetJsonAsync<BankInfView[]>($"api/BankInfs/GetPendingBIF");
        }

        public async Task<IEnumerable<BankInfView>> GetBIFBySwiftID(string swiftId)
        {
            //return await httpClient.GetJsonAsync<BankInfView[]>($"api/BankInfs/GetBIFBySwiftID?swiftId={swiftId}");
            return await httpClient.GetJsonAsync<BankInfView[]>($"api/BankInfs/GetBIFBySwiftID/{swiftId}");
        }

        public async Task<IEnumerable<BankInfView>> GetBIFByCustName(string custName, string branchNo)
        {
            return await httpClient.GetJsonAsync<BankInfView[]>($"api/BankInfs/GetBIFByCustName/{custName}/{branchNo}"); 
        }

        public async Task<IEnumerable<BankInfView>> GetBIFByStatus(string status)
        {
            //throw new System.NotImplementedException();
            return await httpClient.GetJsonAsync<BankInfView[]>($"api/BankInfs/GetBIFByStatus/{status}");
            //return await httpClient.GetJsonAsync<BankInfView[]>($"api/BankInfs/GetBIFByStatus/{status}");
        }
        public async Task<IEnumerable<BankInfView>> GetFullBankInfByStatus(string status)
        {
            //throw new System.NotImplementedException();
            return await httpClient.GetJsonAsync<BankInfView[]>($"api/BankInfs/GetFullBankInfByStatus/{status}");
        }

        public async Task<int> UpdateStatus(BankInfStatus status)
        {
            //throw new System.NotImplementedException();
            return await httpClient.PutJsonAsync<int>("api/BankInfs", status);
        }

    }
}
