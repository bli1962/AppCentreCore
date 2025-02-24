using mhcb.Syd.DataAccess.Models.EUCDbArchive;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System.Reflection.PortableExecutable;
using System.Reflection;
using System.Security.Policy;
using System;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;


namespace mhcb.Syd.AppCenter.Middleware
{
    public class SecurityHeadersMiddleware
    {
        private readonly RequestDelegate _next;

        public SecurityHeadersMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        // ** Add custom middleware sets several security headers for each HTTP response:
        //    By adding this middleware to your.NET Core application, you can enhance the security of your API
        //    by setting important security headers.
        //
        //  X-Content-Type-Options to prevent the browser from interpreting files as a different MIME type.
        //  X-Frame-Options to prevent the page from being displayed in a frame or iframe, protecting against clickjacking attacks.
        //  X-XSS-Protection to enable the cross-site scripting (XSS) filter built into most browsers.
        //  Strict-Transport-Security to enforce the use of HTTPS and prevent man-in-the-middle attacks.
      
        public async Task Invoke(HttpContext context)
        {
            //the middleware is typically called during the processing of an HTTP request
            context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
            context.Response.Headers.Add("X-Frame-Options", "DENY");
            context.Response.Headers.Add("X-XSS-Protection", "1; mode=block");
            context.Response.Headers.Add("Strict-Transport-Security", "max-age=31536000; includeSubDomains");

            await _next(context);
        }
    }
}


