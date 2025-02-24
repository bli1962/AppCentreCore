using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class UserSecurityHttpService : IUserSecurityHttpService
    {
        private readonly HttpClient _httpClient;
        public UserSecurityHttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetAuthorization(string UserId)
        {
            return await _httpClient.GetJsonAsync<string>($"api/UserSecuritys/GetAuthorization/{UserId}");
        }
        public async Task<List<string>> GetAuthorizations(string UserId)
        {
            return await _httpClient.GetJsonAsync<List<string>>($"api/UserSecuritys/GetAuthorizations/{UserId}");
        }
    }

}
