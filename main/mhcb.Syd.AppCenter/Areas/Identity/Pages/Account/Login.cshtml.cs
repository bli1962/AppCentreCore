using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using mhcb.Syd.AppCenter.Services.Interface;
using Microsoft.Extensions.Configuration;

using mhcb.Syd.AppCenter.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Security.Claims;
//using BlazorServerApp.Data;


namespace mhcb.Syd.AppCenter.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IUserSecurityHttpService _userSecurityService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _config;

        //private readonly CustomAuthenticationStateProvider customAuthenticationStateProvider;
        private readonly AuthenticationStateProvider _authenticationStateProvider;


        public LoginModel(SignInManager<IdentityUser> signInManager, 
                            ILogger<LoginModel> logger,
                            UserManager<IdentityUser> userManager,
                            IUserSecurityHttpService userSecurityService,
                            IHttpContextAccessor httpContextAccessor,
                            IConfiguration config,
                            AuthenticationStateProvider authenticationStateProvider)

        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _userSecurityService = userSecurityService;
            _httpContextAccessor = httpContextAccessor;
            _config = config;
            _authenticationStateProvider = authenticationStateProvider;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "AppCenter ID must be {2} characters at least and at max {1}.")]
            [Display(Name = "AppCenter ID")]
            public string UserName { get; set; }

            [Required]
            [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.UserName, Input.Password, Input.RememberMe, lockoutOnFailure: false);

                // please confirmed email has been done, if it fails login
                if (result.Succeeded)
                {
                    // New test code start
                    //User user = new();
                    //user.UserId = Input.UserName;
                    //user.Password = Input.Password;

                    //await ((CustomAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(user);
                    // New test code End


                    // get from guide database
                    _logger.LogInformation("Get Guide Role List.");
                    List<string> roles = (List<string>)await _userSecurityService.GetAuthorizations(Input.UserName);
                    //string auth = string.Join(";", roles);

                    //_logger.LogInformation("Create GuideAuthorizorCookies.");
                    //_httpContextAccessor.HttpContext.Session.SetString("GuideAuthorizorCookies", auth);

                    var claims = new List<Claim>();
                    foreach (var roleDesc in roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, roleDesc));
                    }
                    claims.Add(new Claim(ClaimTypes.Name, Input.UserName));

                    var claimsIdentity = new ClaimsIdentity( claims , "apiauth_type");
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);

                    _logger.LogInformation("User logged in.");
                    return LocalRedirect(returnUrl);
                }

                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private void SetJWTCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddMinutes(5),
            };
            Response.Cookies.Append("jwtCookie", token, cookieOptions);
        }
    }
}
