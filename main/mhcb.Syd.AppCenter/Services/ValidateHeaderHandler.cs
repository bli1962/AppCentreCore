using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace mhcb.Syd.AppCenter.Services
{
    public class ValidateHeaderHandler : DelegatingHandler
    {
        // this is the funtion gets call before you call your api
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
                                                                    CancellationToken cancellationToken)
        {
            //if (!request.Headers.Contains("Authorization"))
            //{
            //    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
            //}

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
