
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mhcb.Syd.Interface;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IUser _repository;
        private readonly ILogger<UsersController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public IdentityController(IUser repository,
                            ILogger<UsersController> logger,
                            IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }
    }
}
