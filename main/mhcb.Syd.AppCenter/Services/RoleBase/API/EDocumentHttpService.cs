using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Blazored.LocalStorage;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class EDocumentHttpService : HttpBaseService, IEDocumentHttpService
    {
        public EDocumentHttpService(HttpClient httpClient,
                                    IHttpContextAccessor httpContext,
                                    IJwtToken jwtToken,
                                    ILocalStorageService localStorageService,
                                    IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        public async Task<int> UpdateStatus(InputEDocument eDocAttribute)
        {
            return await _httpClient.PutJsonAsync<int>("api/EDocuments", eDocAttribute);
        }

        // *************************************************************************************
        // The following Http services has been replaced by Generic http service, because they
        // are not required  [Authorize(Roles = "xxxx")] in Web API
        // B. Li
        // *************************************************************************************

        //public async Task<IEnumerable<eDocumentView>> GetPendingEDoc(string eDocType, string optDate)
        //{
        //    return await _httpClient.GetJsonAsync<eDocumentView[]>($"api/EDocuments/GetPendingEDoc/{eDocType}/{optDate}");
        //}

    }
}
