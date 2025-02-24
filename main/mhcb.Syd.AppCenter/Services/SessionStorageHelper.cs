using Blazored.SessionStorage;
using System.Threading.Tasks;
using System;
using Blazored.LocalStorage;

namespace mhcb.Syd.AppCenter.Services
{
    public class SessionStorageHelper
    {
        //private readonly ISessionStorageService _storageService;
        private readonly ILocalStorageService _storageService;

        public SessionStorageHelper(ILocalStorageService storageService)
        {
            _storageService = storageService;
        }

        //public async Task SetItemAsync<T>(string key, T value, TimeSpan expiry)
        //{
        //    var dataWithExpiry = new DataWithExpiry<T>
        //    {
        //        Data = value,
        //        Expiry = DateTime.UtcNow.Add(expiry)
        //    };
        //    await _sessionStorage.SetItemAsync(key, dataWithExpiry);
        //}

        //public async Task<T> GetItemAsync<T>(string key)
        //{
        //    var dataWithExpiry = await _sessionStorage.GetItemAsync<DataWithExpiry<T>>(key);

        //    if (dataWithExpiry != null && dataWithExpiry.Expiry > DateTime.UtcNow)
        //    {
        //        return dataWithExpiry.Data;
        //    }
        //    await _sessionStorage.RemoveItemAsync(key);
        //    return default;
        //}


        public async Task SetItemAsync(string key, string value)
        {
            await _storageService.SetItemAsync(key, value);
        }

        public async Task<string> GetItemAsync(string key)
        {
            var data = await _storageService.GetItemAsync<string>(key);
            return data;
        }

        private class DataWithExpiry<T>
        {
            public T Data { get; set; }
            public DateTime Expiry { get; set; }
        }
    }

}
