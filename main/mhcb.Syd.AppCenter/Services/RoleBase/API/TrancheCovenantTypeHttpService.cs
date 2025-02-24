using Blazored.LocalStorage;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class TrancheCovenantTypeHttpService : HttpBaseService, ITrancheCovenantTypeHttpService
    {
        public TrancheCovenantTypeHttpService(HttpClient httpClient,
                                            IHttpContextAccessor httpContext,
                                            IJwtToken jwtToken,
                                            ILocalStorageService localStorageService,
                                            IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        public async Task<int> AddCovenantCondition(InputCovenantCondition inputCovenantCondition)
        {
            return await _httpClient.PostJsonAsync<int>("api/TrancheCovenantType/AddCovenantCondition/", inputCovenantCondition);
        }

        public async Task<int> AddTrancheType(InputTrancheType inputTrancheType)
        {
            return await _httpClient.PostJsonAsync<int>("api/TrancheCovenantType/AddTrancheType/", inputTrancheType);
        }

        public async Task<int> AddCovenantReceiptTiming(InputCovenantReceiptTiming inputCovenantReceiptTiming)
        {
            return await _httpClient.PostJsonAsync<int>("api/TrancheCovenantType/AddCovenantReceiptTiming/", inputCovenantReceiptTiming);
        }
    }
}
