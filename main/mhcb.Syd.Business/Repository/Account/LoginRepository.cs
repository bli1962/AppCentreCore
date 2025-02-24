using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;


namespace mhcb.Syd.Business.Repository.Account
{
    public class LoginRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginRepository> _logger;
        //private readonly IUserSecurityService _userSecurityService;

        private readonly AppCenterDbContext _appDbContext;
        private readonly GUIDEDbContext _guideDbContext;

        public LoginRepository(AppCenterDbContext appDbContext,
                                GUIDEDbContext guideDbContext,
                                SignInManager<IdentityUser> signInManager,
                                UserManager<IdentityUser> userManager,
                                ILogger<LoginRepository> logger)    
        {
            this._appDbContext = appDbContext;
            this._guideDbContext = guideDbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public async Task<ModelState> SignInAsync(string userName, string password, ModelState modelState)
        {

            modelState.CallbackUrl = "~/";
            var result = await  _signInManager.PasswordSignInAsync(userName, password, modelState.isPersistent, false);

            if (result.Succeeded)
            {
                // get from guide database
                _logger.LogInformation("Get Guide Role List.");

                List<string> roles = (List<string>) new UserSecurityRepository(_guideDbContext).GetAuthorizations(userName);

                var claims = new List<Claim>();
                foreach (var roleDesc in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, roleDesc));
                }
                claims.Add(new Claim(ClaimTypes.Name, userName));

                var claimsIdentity = new ClaimsIdentity(claims, "apiauth_type");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                //await HttpContext.SignInAsync(claimsPrincipal);

                _logger.LogInformation("User logged in.");

                return modelState;
            }
            if (result.RequiresTwoFactor)
            {
                //return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
            }
            if (result.IsLockedOut)
            {
                _logger.LogWarning("User account locked out.");
                //return RedirectToPage("./Lockout");
                modelState.CallbackUrl = "./Lockout";
            }
            else
            {
                //ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                //return Page();
                modelState.ModelError = "Invalid login attempt.";
            }
            return modelState;
        }

    }
}
