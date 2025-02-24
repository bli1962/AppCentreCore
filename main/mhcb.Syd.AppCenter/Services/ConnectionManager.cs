using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace mhcb.Syd.AppCenter.Services
{
    public class ConnectionManager
    {
        [JSInvokable]
        public static Task<string> CheckConnectionAsync()
        {
            return Task.FromResult("Connection is active");
        }
    }
}
