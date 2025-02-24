using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using mhcb.Syd.Interface;
using mhcb.Syd.Models.Account;

namespace mhcb.Syd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserSecurity _repository;
        private readonly ILogger<AccountController> _logger;
        private readonly IConfiguration _configuration;

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IEmailSender _emailSender;

        //private readonly IUser _repositoryUser;
        //private object modelView;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public AccountController(SignInManager<IdentityUser> signInManager,
                                UserManager<IdentityUser> userManager,
                                ILogger<AccountController> logger,
                                IUserSecurity repository,
                                IEmailSender sender,
                                IConfiguration configuration,
                                IWebHostEnvironment environment)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._logger = logger;
            this._repository = repository;
            this._emailSender = sender;
            this._configuration = configuration;
            this._webHostEnvironment = environment;
        }

        // POST: api/Account
        [HttpPost("Login")]
        public async Task<ActionResult<string>> SignInAsync(LoginInput user)
        {
            _logger.LogInformation("Signing in server side ...");
            var signInResult = await _signInManager.PasswordSignInAsync(user.UserName, user.Password, user.RememberMe, user.lockoutOnFailure);

            // SignInResult return as
            //{
            //  "succeeded": true,
            //  "isLockedOut": false,
            //  "isNotAllowed": false,
            //  "requiresTwoFactor": false
            //}
            if (signInResult.Succeeded)
            {
                _logger.LogInformation("Signed in successfully in server side.");
                _logger.LogWarning(MessageValue.msgAssignedIn);

                _logger.LogInformation("Fetching user's roles from GUIDE db ...");
                //List<string> roles = (List<string>)_repository.GetAuthorizations(user.UserName);

                //var claims = new List<Claim>();
                //foreach (var roleDesc in roles)
                //{
                //    claims.Add(new Claim(ClaimTypes.Role, roleDesc));
                //}
                //claims.Add(new Claim(ClaimTypes.Name, user.UserName));

                _logger.LogInformation("Creating the claimed identity ...");
                //var claimsIdentity = new ClaimsIdentity(claims, "apiAuth_type");
                //// or var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                _logger.LogInformation("Creating the claimed principal ...");
                //var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                _logger.LogInformation("Signing in with the claimed principal.");

                ////await HttpContext.SignInAsync(claimsPrincipal);
                ////or await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

                return MessageValue.msgAssignedIn;
            }
            else if (signInResult.RequiresTwoFactor)
            {
                _logger.LogWarning(MessageValue.msgTwoFactors);
                return MessageValue.msgTwoFactors;
                //return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = user.RememberMe });
            }
            else if (signInResult.IsLockedOut)
            {
                _logger.LogWarning(MessageValue.msgLockedOut);
                return MessageValue.msgLockedOut;
                //return RedirectToPage("./Lockout");
            }
            else
            {
                _logger.LogWarning(MessageValue.msgInvalidLogin);
                return MessageValue.msgInvalidLogin;
                //return Page();
            }
            //return signInResult;
        }


        // POST: api/Account     
        [HttpPost("Register")]
        public async Task<ActionResult<string>> RegisterAsync(RegisterInput Input)
        {
            string returnUrl = Url.Content("~/");

            IdentityResult result = new IdentityResult();
            var errorMessage = string.Empty;

            var user = new IdentityUser { UserName = Input.UserName, Email = Input.Email };
            var emailValue = await _userManager.FindByEmailAsync(Input.Email);
            var usernameValue = await _userManager.FindByNameAsync(Input.UserName);

            if (usernameValue != null && Input.UserName.ToUpper() == usernameValue.UserName.ToUpper())
            {
                //modelState.ModelError = "User Name " + user.UserName + " is already taken.";
                errorMessage = MessageValue.msgInvalidUserName;
            }
            else if (emailValue != null && Input.Email.ToUpper() == emailValue.Email.ToUpper())
            {
                //modelState.ModelError = "Email address " + user.Email + " is already taken.";
                errorMessage = MessageValue.msgInvalidEmail;
            }
            else
            {
                _logger.LogInformation("Creating a new account ...");
                result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    try
                    {
                        //var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        //token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));

                        // Original Razor version
                        //var callbackUrl = Url.Page(
                        //          "/Account/ConfirmEmail",
                        //          pageHandler: null,
                        //          values: new { area = "Identity", userId = user.Id, code = token, returnUrl = returnUrl },
                        //          protocol: Request.Scheme);

                        // example :  //https://localhost:44300/RegisterConfirmation/BL007011   
                        string clientAddress = _configuration["ClientAddress"];
                        var callbackUrl = clientAddress
                                        + "/RegisterConfirmation"
                                        + "/" + user.Id;

                        _logger.LogInformation("Call back URL :" + callbackUrl);

                        await _emailSender.SendEmailAsync(Input.Email,
                                                        "Confirm your Register by email",
                                                         $"Please confirm your account by clicking here " + callbackUrl);
                    }
                    catch
                    {
                        _logger.LogWarning("Issue found in sending confirmation email.");
                    }
                }
                else
                {
                    errorMessage = "Registration Failed";
                    foreach (IdentityError error in result.Errors)
                    {
                        errorMessage += string.Empty + error.Description;
                    }
                }
            }

            // IdentityResult return as
            //{
            //  "succeeded": false,
            //  "errors": []
            //}
            if (result.Succeeded)
            {
                _logger.LogWarning(MessageValue.msgRegisterSuccess);
                return MessageValue.msgRegisterSuccess;
            }
            else
            {
                _logger.LogWarning(errorMessage);
                return errorMessage;
            }
            //return result;
        }


        [HttpPost]
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok(new { Message = "You are logged out" });
        }


        //**************************************************************
        // Get User
        //**************************************************************
        [Route("FindByEmailAsync/{email}")]
        [HttpGet]
        public async Task<IdentityUser> FindByEmailAsync(string email)
        {
            IdentityUser user = new IdentityUser();
            user = await _userManager.FindByEmailAsync(email);
            return user;
        }

        [Route("FindByNameAsync/{userName}")]
        [HttpGet]
        public async Task<IdentityUser> FindByNameAsync(string userName)
        {
            IdentityUser user = new IdentityUser();
            user = await _userManager.FindByNameAsync(userName);
            return user;
        }

        [Route("FindByIdAsync/{userId}")]
        [HttpGet]
        public async Task<IdentityUser> FindByIdAsync(string userId)
        {
            IdentityUser user = new IdentityUser();
            user = await _userManager.FindByIdAsync(userId);
            return user;
        }


        //**************************************************************
        // Get UserID
        //**************************************************************
        [Route("GetUserIdByNameAsync/{userName}")]
        [HttpGet]
        public async Task<string> GetUserIdByNameAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var userId = await _userManager.GetUserIdAsync(user);
            return userId;
        }

        [Route("GetUserIdEmailAsync/{email}")]
        [HttpGet]
        public async Task<string> GetUserIdEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var userId = await _userManager.GetUserIdAsync(user);
            return userId;
        }


        //**************************************************************
        // Check Account has been confirmed?
        //**************************************************************
        [Route("IsEmailConfirmedByEmailAsync/{email}")]
        [HttpGet]
        public async Task<bool> IsEmailConfirmedByEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var isConfirmed = await _userManager.IsEmailConfirmedAsync(user);
            return isConfirmed;
        }
        [Route("IsEmailConfirmedByNameAsync/{userName}")]
        [HttpGet]
        public async Task<bool> IsEmailConfirmedByNameAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var isConfirmed = await _userManager.IsEmailConfirmedAsync(user);
            return isConfirmed;
        }


        //**************************************************************
        // Get token of email confirmation
        //**************************************************************
        [Route("GenerateEmailConfirmationTokenAsync/{email}")]
        [HttpGet]
        public async Task<string> GenerateEmailConfirmationTokenAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            return token;
        }


        //**************************************************************
        // Get token of reset password
        //**************************************************************
        [Route("GeneratePasswordResetTokenByNameAsync/{userName}")]
        [HttpGet]
        public async Task<string> GeneratePasswordResetTokenByNameAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            return token;
        }

        [Route("GeneratePasswordResetTokenByEmailAsync/{email}")]
        [HttpGet]
        public async Task<string> GeneratePasswordResetTokenByEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            return token;
        }


        //**************************************************************
        // Actions - Reset password
        //**************************************************************
        [Route("ResetPasswordByNameAsync/{userName}/{newPassword}")]
        [HttpGet]
        public async Task<ActionResult<string>> ResetPasswordByNameAsync(string userName, string newPassword)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, newPassword);
            if (result.Succeeded)
            {
                return MessageValue.msgSuccess;
            }
            else
            {
                return MessageValue.msgUnsuccess;
            }
        }


        [Route("ResetPasswordByEmailAsync/{email}/{newPassword}")]
        [HttpGet]
        public async Task<ActionResult<string>> ResetPasswordByEmailAsync(string email, string newPassword)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, newPassword);

            if (result.Succeeded)
            {
                return MessageValue.msgSuccess;
            }
            else
            {
                return MessageValue.msgUnsuccess;
            }
        }


        [Route("ConfirmEmailAsync/{email}")]
        [HttpGet]
        public async Task<ActionResult<string>> ConfirmEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var result = await _userManager.ConfirmEmailAsync(user, token);

            if (result.Succeeded)
            {
                return MessageValue.msgSuccess;
            }
            else
            {
                return MessageValue.msgUnsuccess;
            }
        }

        [Route("ConfirmEmailByNameAsync/{userName}")]
        [HttpGet]
        public async Task<ActionResult<string>> ConfirmEmailByNameAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var result = await _userManager.ConfirmEmailAsync(user, token);

            if (result.Succeeded)
            {
                return MessageValue.msgSuccess;
            }
            else
            {
                return MessageValue.msgUnsuccess;
            }
        }
    }
}
