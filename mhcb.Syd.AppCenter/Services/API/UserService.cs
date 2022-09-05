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
    public class UserService : IUserService
    {
        //Task< UserView> LoadUserByUserId(string userId);
        //Task<IEnumerable<UserView>> LoadUsersByRecStatus(string status);
        //Task<string> UpdateStatus(UserAttribute userAttr);
        private readonly HttpClient httpClient;
        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<UserView>> GetUserByStatus(string status)
        {
            return await httpClient.GetJsonAsync<UserView[]>($"api/Users/GetUserByStatus/{status}");
        }

        public async Task<IEnumerable<UserView>> GetUserById(string userId)
        {
            return await httpClient.GetJsonAsync<UserView[]>($"api/Users/GetUserById/{userId}");
        }

        public async Task<int> UpdateStatus(UserAttribute userAttr)
        {
            return await httpClient.PutJsonAsync<int>("api/Users", userAttr);
        }
    }
}
