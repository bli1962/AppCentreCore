using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
//using mhcb.Syd.Business.Utilities;
using Blazored.SessionStorage;

namespace mhcb.Syd.AppCenter.Services.Generic
{
    public class HttpService<T> : IHttpService<T>
    {
        public HttpClient _httpClient { get; }

        public ISessionStorageService _storageService { get; }
        //public ILocalStorageService _localStorageService { get; }

        public readonly IConfiguration _configuration;
        public readonly IJwtToken _jwtToken;

        public HttpService(HttpClient httpClient,
                                ISessionStorageService localStorageService,
                                IConfiguration configuration,
                                IJwtToken jwtToken)
        {
            this._configuration = configuration;
            this._storageService = localStorageService;
            this._jwtToken = jwtToken;

            var authToken = _jwtToken.GenerateJwtTokenAuth();
            httpClient.BaseAddress = new Uri(_configuration["ApiAddress"]);
            httpClient.DefaultRequestHeaders.Add("User-Agent", "BlazorServer");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);

            _httpClient = httpClient;
        }


        public async Task<List<T>> GetAllAsync(string requestUri, string accessToken)
        {
            // 1.Prepare HttpMessage
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);

            // 2. Add head for token
            //var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //                    = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            // 3.Send httpMessage
            var response = await _httpClient.SendAsync(requestMessage);

            // 4.Catch response message code
            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return await Task.FromResult(JsonConvert.DeserializeObject<List<T>>(responseBody));
            }
            else
                return new List<T>();
        }


        public async Task<T> GetByIdAsync(string requestUri, int Id, string accessToken)
        {
            // 1.Prepare HttpMessage
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri + Id);

            //var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //         = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            // 3.Send httpMessage
            var response = await _httpClient.SendAsync(requestMessage);

            // 4.Catch response message code
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            return await Task.FromResult(JsonConvert.DeserializeObject<T>(responseBody));
        }

        public async Task<T> GetAsync(string requestUri, string accessToken)
        {
            // 1.Prepare HttpMessage
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //         = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            // 3.Send httpMessage
            var response = await _httpClient.SendAsync(requestMessage);
            // 4.Catch response message code
            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return await Task.FromResult(JsonConvert.DeserializeObject<T>(responseBody));
            } 
            else
            {
                return await Task.FromResult(JsonConvert.DeserializeObject<T>("NotFound"));
            }
        }


        public async Task<bool> DeleteByIdAsync(string requestUri, int Id, string accessToken)
        {
            // 1.Prepare HttpMessage
            var requestMessage = new HttpRequestMessage(HttpMethod.Delete, requestUri + Id);

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //                = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            // 3.Send httpMessage
            var response = await _httpClient.SendAsync(requestMessage);
            // 4.Catch response message code
            var responseStatusCode = response.StatusCode;

            if (responseStatusCode == HttpStatusCode.OK)
            {
                return await Task.FromResult(true);
            }
            else
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> DeleteAsync(string requestUri, string accessToken)
        {
            // 1.Prepare HttpMessage
            var requestMessage = new HttpRequestMessage(HttpMethod.Delete, requestUri);

            //var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //                = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            // 3.Send httpMessage
            var response = await _httpClient.SendAsync(requestMessage);
            // 4.Catch response message code
            var responseStatusCode = response.StatusCode;

            if (responseStatusCode == HttpStatusCode.OK)
            {
                return await Task.FromResult(true);
            }
            else
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<int> AddAsync(string requestUri, string accessToken, T obj)
        {
            // 1.Prepare HttpMessage
            string serializedObj = JsonConvert.SerializeObject(obj);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);

            //var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //                = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            requestMessage.Content = new StringContent(serializedObj);
            requestMessage.Content.Headers.ContentType
                            = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            // 3.Send httpMessage
            var response = await _httpClient.SendAsync(requestMessage);
            // 4.Catch response message code
            var responseStatusCode = response.StatusCode;

            var responseBody = await response.Content.ReadAsStringAsync();

            var returnedObj = JsonConvert.DeserializeObject<int>(responseBody);
            return await Task.FromResult(returnedObj);
        }


        public async Task<int> UpdateByIdAsync(string requestUri, int Id, string accessToken, T obj)
        {
            string serializedObj = JsonConvert.SerializeObject(obj);

            // 1.Prepare HttpMessage
            var requestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri + Id);

            // var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //               = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            requestMessage.Content = new StringContent(serializedObj);
            requestMessage.Content.Headers.ContentType
                            = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            // 3.Send httpMessage
            var response = await _httpClient.SendAsync(requestMessage);
            // 4.Catch response message code
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            var returnedObj = JsonConvert.DeserializeObject<int>(responseBody);
            return await Task.FromResult(returnedObj);
        }

        public async Task<int> UpdateAsync(string requestUri, string accessToken, T obj)
        {
            string serializedObj = JsonConvert.SerializeObject(obj);

            // 1.Prepare HttpMessage
            var requestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);

            //var token = await _storageService.GetItemAsync<string>("accessToken");
            //requestMessage.Headers.Authorization
            //               = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            requestMessage.Content = new StringContent(serializedObj);
            requestMessage.Content.Headers.ContentType
                            = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            // 3.Send httpMessage
            var response = await _httpClient.SendAsync(requestMessage);
            // 4.Catch response message code
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            var returnedObj = JsonConvert.DeserializeObject<int>(responseBody);
            return await Task.FromResult(returnedObj);
        }
    }
}
