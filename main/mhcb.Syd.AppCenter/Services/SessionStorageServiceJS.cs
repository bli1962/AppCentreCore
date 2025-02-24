using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services
{
    public class SessionStorageServiceJS
    {
        private readonly IJSRuntime _jsRuntime;

        public SessionStorageServiceJS(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task SetItemAsync(string key, string value)
        {
            await _jsRuntime.InvokeVoidAsync("sessionStorageHelper.setItem", key, value);
        }

        public async Task<string> GetItemAsync(string key)
        {
            return await _jsRuntime.InvokeAsync<string>("sessionStorageHelper.getItem", key);
        }

        public async Task RemoveItemAsync(string key)
        {
            await _jsRuntime.InvokeVoidAsync("sessionStorageHelper.removeItem", key);
        }
    }
}
