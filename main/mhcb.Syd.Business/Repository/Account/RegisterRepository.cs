using mhcb.Syd.DataAccess.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

using mhcb.Syd.Models;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Business.Repository.Account
{
    public class RegisterRepository
    {     
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<RegisterRepository> _logger;
        private readonly IEmailSender _emailSender;

        private readonly AppCenterDbContext _appDbContext;
        private readonly GUIDEDbContext _guideDbContext;
        public RegisterRepository(AppCenterDbContext appDbContext,
                                SignInManager<IdentityUser> signInManager,
                                UserManager<IdentityUser> userManager,
                                ILogger<RegisterRepository> logger,
                                IEmailSender sender)
        {
            this._appDbContext = appDbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = sender;
        }

        public async Task<ModelState> RegisterAsync(string userName, string email, string password, ModelState modelState)
        {
            modelState.CallbackUrl = "~/";

            if (modelState.IsValid)
            {
                var user = new IdentityUser { UserName = userName, Email = email };

                var user2 = await _userManager.FindByEmailAsync(email);

                if (user2 != null && user.Email.ToUpper() == user2.Email.ToUpper())
                {
                    //return RedirectToPage("./ForgotPasswordConfirmation");
                    modelState.ModelError =  "Email address " + user.Email + " is already taken.";
                }
                else
                {
                    var result = await _userManager.CreateAsync(user, password);

                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User created a new account with password.");

                        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                        modelState.CallbackUrl = "/Account/ConfirmEmail";
                        //var callbackUrl = Url.Page(
                        //    "/Account/ConfirmEmail",
                        //    pageHandler: null,
                        //    values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        //    protocol: Request.Scheme);

                        try
                        {
                            await _emailSender.SendEmailAsync(email,
                                    "Confirm your Register by email",
                                     $"Please confirm your account by clicking here " + modelState.CallbackUrl);
                        }
                        catch { }

                        if (_userManager.Options.SignIn.RequireConfirmedAccount)
                        {
                            modelState.CallbackUrl = "RegisterConfirmation";
                            //return RedirectToPage("RegisterConfirmation", new { email = email, returnUrl = modelState.CallbackUrl });
                        }
                        else
                        {
                            await _signInManager.SignInAsync(user, isPersistent: false);
                            //return LocalRedirect(returnUrl);
                        }
                    }
                    foreach (var error in result.Errors)
                    {
                        modelState.ModelError += string.Empty + error.Description;
                    }
                }
            }


            //var result = await _userManager.CreateAsync(user, password);
            return modelState;
        }


    }
}
