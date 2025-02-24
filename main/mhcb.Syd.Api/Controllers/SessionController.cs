using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        [HttpGet("GetSessionData")]
        public IActionResult GetSessionData()
        {
            var sessionData = HttpContext.Session.GetString("Token");
            return Ok(sessionData);
        }

        [HttpPost("SetSessionData")]
        public IActionResult SetSessionData([FromBody] string value)
        {
            HttpContext.Session.SetString("Token", value);
            return Ok();
        }
    }
}
