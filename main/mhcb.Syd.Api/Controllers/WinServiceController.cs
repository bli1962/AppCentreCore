using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ServiceProcess;
using System;

//If you're deploying this as a web application (like a Web API), the application pool in IIS
//should also have the necessary permissions. In a development environment,
//it’s common to run the application under your user account which likely has the required permissions.

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WinServiceController : ControllerBase
    {

        [HttpPost("start")]
        public IActionResult StartService([FromBody] string serviceName)
        {
            return ManageService(serviceName, ServiceControllerStatus.Running, sc => sc.Start());
        }

        [HttpPost("stop")]
        public IActionResult StopService([FromBody] string serviceName)
        {
            return ManageService(serviceName, ServiceControllerStatus.Stopped, sc => sc.Stop());
        }

        [HttpPost("restart")]
        public IActionResult RestartService([FromBody] string serviceName)
        {
            return ManageService(serviceName, ServiceControllerStatus.Stopped, sc =>
            {
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped);
                sc.Start();
            });
        }

        private IActionResult ManageService(string serviceName, ServiceControllerStatus desiredStatus, Action<ServiceController> action)
        {
            try
            {
                using (ServiceController sc = new ServiceController(serviceName))
                {
                    if (sc.Status != desiredStatus)
                    {
                        action(sc);
                        sc.WaitForStatus(desiredStatus);
                        return Ok($"{serviceName} service {desiredStatus.ToString().ToLower()}ed successfully.");
                    }
                    else
                    {
                        return Ok($"{serviceName} service is already {desiredStatus.ToString().ToLower()}.");
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
