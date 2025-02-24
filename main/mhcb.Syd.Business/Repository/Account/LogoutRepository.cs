using mhcb.Syd.DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Business.Repository.Account
{
    public class LogoutRepository
    {
        private readonly AppCenterDbContext appDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        //private readonly ILogger<LoginModel> _logger;
        //private readonly IUserSecurityService _userSecurityService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _config;

        public LogoutRepository(AppCenterDbContext appDbContext,
                                SignInManager<IdentityUser> signInManager,
                                UserManager<IdentityUser> userManager)
        {
            this.appDbContext = appDbContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }
    }
}
