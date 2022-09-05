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
    public class UserSecurityService : IUserSecurityService
    {
        //Task<string> GetAuthorisers(string userid);
        //Task<User> GetGUser(string userid, string decPassword);
        //Task<bool> Login(string userid, string decPassword);
        private readonly HttpClient httpClient;
        public UserSecurityService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<string> GetAuthorization(string UserId)
        {
            return await httpClient.GetJsonAsync<string>($"api/UserSecuritys/GetAuthorization/{UserId}");
            //throw new NotImplementedException();
        }
        public async Task<List<string>> GetAuthorizations(string UserId)
        {
            return await httpClient.GetJsonAsync<List<string>>($"api/UserSecuritys/GetAuthorizations/{UserId}");
        }

        public async Task<User> GetGUser(string userid, string decPassword)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Login(string userid, string decPassword)
        {
            throw new NotImplementedException();
        }

        
    }
}
