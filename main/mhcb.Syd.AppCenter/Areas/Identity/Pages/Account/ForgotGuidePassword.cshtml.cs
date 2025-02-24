using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using mhcb.Syd.AppCenter.Services.Interface;
using System.Collections.Generic;
using mhcb.Syd.Models;
using System.Linq;

namespace mhcb.Syd.AppCenter.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ForgotGuidePasswordModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly IUserHttpService _httpService;

        public ForgotGuidePasswordModel(UserManager<IdentityUser> userManager, 
                                        IEmailSender sender,
                                        IUserHttpService httpService)
        {
            _userManager = userManager;
            _emailSender = sender;
            _httpService = httpService;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        }

        public IEnumerable<UserView> modelView { get; set; } = new List<UserView>();

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    // Don't reveal that the user does not exist or is not confirmed
                    return RedirectToPage("./ForgotPasswordConfirmation");
                }

                // For more information on how to enable account confirmation and password reset please 
                // visit https://go.microsoft.com/fwlink/?LinkID=532713

                //var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                //var callbackUrl = Url.Page(
                //    "/Account/ResetPassword",
                //    pageHandler: null,
                //    values: new { area = "Identity", code },
                //    protocol: Request.Scheme);

                //var password = await _httpService.LoadGuidePasswordByUserId(user.UserName);
                modelView = await _httpService.LoadGuidePasswordByUserId(user.UserName);
                string password = modelView.FirstOrDefault().PASSWORD;

                if (password != "")
                {
                    try
                    {
                        await _emailSender.SendEmailAsync(
                              Input.Email,
                              "Forgot GUIDE Password",
                              $"Your current GUIDE password is " + password);

                    }
                    catch { }
                }         
                return RedirectToPage("./ForgotPasswordConfirmation");
            }

            return Page();
        }
    }
}
