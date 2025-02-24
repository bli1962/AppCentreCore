using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using mhcb.Syd.Business.Utilities;
using mhcb.Syd.Models.Account;
using System;
using Microsoft.AspNetCore.Identity;

namespace mhcb.Syd.AppCenter.Services.Identity
{
    public class AccountHttpService : IAccountHttpService
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContext;
        private readonly IJwtToken _jwtToken;
        private readonly IConfiguration _configuration;

        public AccountHttpService(HttpClient httpClient,
                             IConfiguration configuration,
                             IHttpContextAccessor httpContext,
                             IJwtToken jwtToken)
        {
            this._httpClient = httpClient;
            this._configuration = configuration;
            this._httpContext = httpContext;
            this._jwtToken = jwtToken;

            httpClient.BaseAddress = new Uri(_configuration["ApiAddress"]);
            _httpClient = httpClient;
        }

        public async Task<string> SignInAsync(LoginInput user)
        {
            //user.Password = Utility.Encrypt(user.Password);

            string serializedUser = JsonConvert.SerializeObject(user);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"api/Account/Login");

            // if use bearer token
            //var token = await _localStorageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //               = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            requestMessage.Content = new StringContent(serializedUser);
            requestMessage.Content.Headers.ContentType
                            = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();
            return await Task.FromResult(responseBody);

            //var returnedUser = JsonConvert.DeserializeObject<string>(responseBody);
            //return await Task.FromResult(returnedUser);
        }


        public async Task<string> RegisterAsync(RegisterInput user)
        {
            string serializedUser = JsonConvert.SerializeObject(user);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"api/Account/Register");

            // if use bearer token
            //var token = await _localStorageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //               = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            requestMessage.Content = new StringContent(serializedUser);
            requestMessage.Content.Headers.ContentType
                            = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();
            return await Task.FromResult(responseBody);

            //var returnedUser = JsonConvert.DeserializeObject<string>(responseBody);
            //return await Task.FromResult(returnedUser);
        }


        // 1.
        public async Task<IdentityUser> FindByEmailAsync(string email)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/Account/FindByEmailAsync/{email}");

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //         = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            return await Task.FromResult(JsonConvert.DeserializeObject<IdentityUser>(responseBody));
        }

        public async Task<IdentityUser> FindByNameAsync(string userName)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/Account/FindByNameAsync/{userName}");

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //         = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            return await Task.FromResult(JsonConvert.DeserializeObject<IdentityUser>(responseBody));
        }

        public async Task<IdentityUser> FindByIdAsync(string userId)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/Account/FindByIdAsync/{userId}");

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //         = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            return await Task.FromResult(JsonConvert.DeserializeObject<IdentityUser>(responseBody));
        }

        // 2.
        public async Task<string> GetUserIdByNameAsync(string userName)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/Account/GetUserIdByNameAsync/{userName}");

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //         = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            return await Task.FromResult((responseBody));
        }

        public async Task<string> GetUserIdByEmailAsync(string email)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/Account/GetUserIdEmailAsync/{email}");

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //         = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            //return await Task.FromResult(JsonConvert.DeserializeObject<string>(responseBody));
            return await Task.FromResult((responseBody));
        }


        // 3.
        public async Task<bool> IsEmailConfirmedByEmailAsync(string email)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/Account/IsEmailConfirmedByEmailAsync/{email}");

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //         = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            return await Task.FromResult(JsonConvert.DeserializeObject<bool>(responseBody));
        }

        public async Task<bool> IsEmailConfirmedByNameAsync(string userName)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/Account/IsEmailConfirmedByNameAsync/{userName}");

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //         = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            return await Task.FromResult(JsonConvert.DeserializeObject<bool>(responseBody));
        }


        // 4.
        public async Task<string> GenerateEmailConfirmationTokenAsync(string email)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/Account/GenerateEmailConfirmationTokenAsync/{email}");

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //         = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            return await Task.FromResult((responseBody));
        }

        public async Task<string> GeneratePasswordResetTokenAsync(string userName)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/Account/GeneratePasswordResetTokenByNameAsync/{userName}");

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //         = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            return await Task.FromResult((responseBody));
        }


        public async Task<string> ResetPasswordByNameAsync(string userName, string newPassword)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/Account/ResetPasswordByNameAsync/{userName}/{newPassword}");

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //         = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            return await Task.FromResult((responseBody));
        }

        public async Task<string> ResetPasswordByEmailAsync(string email, string newPassword)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/Account/ResetPasswordByEmailAsync/{email}/{newPassword}");

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //         = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            return await Task.FromResult((responseBody));
        }

        public async Task<string> ConfirmEmailAsync(string email)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"api/Account/ConfirmEmailAsync/{email}");

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //         = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            return await Task.FromResult((responseBody));
        }
    }
}
