using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Blazored.LocalStorage;
using Microsoft.Extensions.Configuration;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class LoanMasterTrancheHttpService : HttpBaseService, ILoanMasterTrancheHttpService
    {
        public LoanMasterTrancheHttpService(HttpClient httpClient,
                                            IHttpContextAccessor httpContext,
                                            IJwtToken jwtToken,
                                            ILocalStorageService localStorageService,
                                            IConfiguration configuration)
            : base(httpClient, httpContext, jwtToken, localStorageService, configuration)
        {
        }

        // *************************************************************************************
        // The following Http services has been replaced by Generic http service, because they
        // are not required  [Authorize(Roles = "xxxx")] in Web API
        // B. Li
        // *************************************************************************************

        //public async Task<IEnumerable<LoanMasterTrancheView>> GetCovenantCheckList()
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IEnumerable<LoanMasterTrancheView>> GetLiborDiscontinuation()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
