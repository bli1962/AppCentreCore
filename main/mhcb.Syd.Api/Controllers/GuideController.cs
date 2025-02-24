﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mhcb.Syd.Interface;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuideController : ControllerBase
    {
        private readonly IBankInf _repository;
        private readonly ILogger<GuideController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public GuideController(IBankInf repository,
                                  ILogger<GuideController> logger,
                                  IWebHostEnvironment environment)
        {
            this._repository = repository;
            this._logger = logger;
            this._webHostEnvironment = environment;
        }

        
    }
}
