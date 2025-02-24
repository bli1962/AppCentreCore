using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;
using Blazored.LocalStorage;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;


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

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class BankInfHttpService : HttpBaseService, IBankInfHttpService
    {
        public BankInfHttpService(HttpClient httpClient,
                                IHttpContextAccessor httpContext,
                                IJwtToken jwtToken,
                                ILocalStorageService localStorageService,
                                IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        public async Task<int> UpdateStatus(InputBIF status)
        {
            //string myAutication = _httpContext.HttpContext.Session.GetString("GuideAuthorizorCookies");
            //if ((myAutication != null) && myAutication.Contains("BIF - Authorise"))
            //{
            //}
            var claims = new[] {
                    new Claim(ClaimTypes.Role, "BIF - Authorise"),
                    //new Claim(ClaimTypes.Role, "Manager")
                    //new Claim(ClaimTypes.Role, loginUser.Username),
                    //c1, c2, c3, c4, c5
                };
            var roleToken = _jwtToken.GenerateJwtTokenByClaims(claims);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", roleToken);
            return await _httpClient.PutJsonAsync<int>("api/BankInfs", status);
        }


        // *************************************************************************************
        // The following Http services has been replaced by Generic http service, because they
        // are not required  [Authorize(Roles = "xxxx")] in Web API
        // B. Li
        // *************************************************************************************


        //public async Task<IEnumerable<BankInfView>> GetPendingBIF()
        //{
        //	var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/BankInfs/GetPendingBIF");
        //	var responseMessage = await _httpClient.SendAsync(requestMessage);
        //	var responseStatusCode = responseMessage.StatusCode;
        //	if (responseStatusCode.ToString() == "OK")
        //	{
        //		var responseBody = await responseMessage.Content.ReadAsStringAsync();
        //		return await Task.FromResult(JsonConvert.DeserializeObject<List<BankInfView>>(responseBody));
        //	}
        //	else
        //		return null;

        //	//var authToken = _repository.GenerateJwtTokenAuth();
        //	//return await _httpClient.GetJsonAsync<BankInfView[]>($"api/BankInfs/GetPendingBIF");
        //}

        //public async Task<IEnumerable<BankInfView>> GetBIFBySwiftID(string swiftId)
        //{
        //	var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/BankInfs/GetBIFBySwiftID/{swiftId}");
        //	var responseMessage = await _httpClient.SendAsync(requestMessage);
        //	var responseStatusCode = responseMessage.StatusCode;
        //	if (responseStatusCode.ToString() == "OK")
        //	{
        //		var responseBody = await responseMessage.Content.ReadAsStringAsync();
        //		return await Task.FromResult(JsonConvert.DeserializeObject<List<BankInfView>>(responseBody));
        //	}
        //	else
        //		return null;

        //	//return await _httpClient.GetJsonAsync<BankInfView[]>($"api/BankInfs/GetBIFBySwiftID/{swiftId}");
        //}

        //public async Task<IEnumerable<BankInfView>> GetBIFByCustName(string custName, string branchNo)
        //{
        //	var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/BankInfs/GetBIFByCustName/{custName}/{branchNo}");
        //	var responseMessage = await _httpClient.SendAsync(requestMessage);
        //	var responseStatusCode = responseMessage.StatusCode;
        //	if (responseStatusCode.ToString() == "OK")
        //	{
        //		var responseBody = await responseMessage.Content.ReadAsStringAsync();
        //		return await Task.FromResult(JsonConvert.DeserializeObject<List<BankInfView>>(responseBody));
        //	}
        //	else
        //		return null;

        //	//return await _httpClient.GetJsonAsync<BankInfView[]>($"api/BankInfs/GetBIFByCustName/{custName}/{branchNo}"); 
        //}

        //public async Task<IEnumerable<BankInfView>> GetBIFByStatus(string status)
        //{
        //	var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/BankInfs/GetBIFByStatus/{status}");
        //	var responseMessage = await _httpClient.SendAsync(requestMessage);
        //	var responseStatusCode = responseMessage.StatusCode;
        //	if (responseStatusCode.ToString() == "OK")
        //	{
        //		var responseBody = await responseMessage.Content.ReadAsStringAsync();
        //		return await Task.FromResult(JsonConvert.DeserializeObject<List<BankInfView>>(responseBody));
        //	}
        //	else
        //		return null;

        //	//return await _httpClient.GetJsonAsync<BankInfView[]>($"api/BankInfs/GetBIFByStatus/{status}");
        //}
        //public async Task<IEnumerable<BankInfView>> GetFullBankInfByStatus(string status)
        //{
        //	var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/BankInfs/GetFullBankInfByStatus/{status}");
        //	var responseMessage = await _httpClient.SendAsync(requestMessage);
        //	var responseStatusCode = responseMessage.StatusCode;
        //	if (responseStatusCode.ToString() == "OK")
        //	{
        //		var responseBody = await responseMessage.Content.ReadAsStringAsync();
        //		return await Task.FromResult(JsonConvert.DeserializeObject<List<BankInfView>>(responseBody));
        //	}
        //	else
        //		return null;

        //	//return await _httpClient.GetJsonAsync<BankInfView[]>($"api/BankInfs/GetFullBankInfByStatus/{status}");
        //}


    }
}
