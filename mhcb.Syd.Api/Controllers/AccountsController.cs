using System;
using System.Threading.Tasks;
using System.Net;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Authorization;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IBankInf _repository;
        private readonly ILogger<AccountsController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AccountsController(IBankInf repository,
                                    ILogger<AccountsController> logger,
                                    IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }
    }
}
