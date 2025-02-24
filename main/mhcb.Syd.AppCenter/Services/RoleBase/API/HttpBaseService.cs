using Blazored.LocalStorage;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace mhcb.Syd.AppCenter.Services.RoleBase.API
{
    public class HttpBaseService
    {
        protected readonly HttpClient _httpClient;
        protected readonly IHttpContextAccessor _httpContext;
        protected readonly IJwtToken _jwtToken;
        protected readonly IConfiguration _configuration;
        protected readonly ILocalStorageService _localStorageService;

        public HttpBaseService(HttpClient httpClient,
                            IHttpContextAccessor httpContext,
                            IJwtToken jwtToken,
                            ILocalStorageService localStorageService,
                            IConfiguration configuration)
        {

            _httpContext = httpContext;
            _httpClient = httpClient;
            _configuration = configuration;
            _jwtToken = jwtToken;

            var authToken = _jwtToken.GenerateJwtTokenAuth();
            _httpClient.BaseAddress = new Uri(_configuration["ApiAddress"]);
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "BlazorServer");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
        }
    }
}
