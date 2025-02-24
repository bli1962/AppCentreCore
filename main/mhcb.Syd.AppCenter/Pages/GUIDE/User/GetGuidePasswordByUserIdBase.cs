using Microsoft.AspNetCore.Components;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using System.Collections.Generic;
using mhcb.Syd.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity.UI.Services;
using mhcb.Syd.AppCenter.Services.Generic;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.AppCenter.Services.Identity;

namespace mhcb.Syd.AppCenter.Pages.GUIDE.User
{
    public class GetGuidePasswordByUserIdBase : ComponentBase
    {
        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        [Inject]
        public IHttpService<UserView> _httpService { get; set; }
        [Inject]
        public IEmailSender _emailSender { get; set; }
		//[Inject]
		//public UserManager<IdentityUser> _userManager { get; set; }
		[Inject]
		public IAccountHttpService _accountHttpService { get; set; }
		[Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public IEnumerable<UserView> modelView { get; set; } = new List<UserView>();

		// ** Variables for confirmation box 
		public string Title { get; set; }
		public string Message { get; set; }
		public string YesButtonText { get; set; }
		public string NoButtonText { get; set; }
		public string InfoButtonText { get; set; }
		public bool IsVisible { get; set; }
		public bool IsInformationOnly { get; set; }
		public string BtnClass { get; set; }
		// ** End


		protected InputModel inputModel = new()
        {
            Email = "",
        };

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        }

        protected override async Task OnInitializedAsync() 
        {
			Title = "Forgot GUIDE password";
			Message = "Do you want to save?";
			YesButtonText = "Yes";
			NoButtonText = "No";
			InfoButtonText = "OK";
			BtnClass = "btn btn-primary float-left";

			var authenticationState = await authenticationStateTask;
            //var user = await _userManager.FindByNameAsync(authenticationState.User.Identity.Name);
			var user = await _accountHttpService.FindByNameAsync(authenticationState.User.Identity.Name);

			if (user == null)
            {
				// Don't reveal that the user does not exist or email does not belong to login user
				//ConfirmationComponent.Show();
				IsVisible = true;
				IsInformationOnly = true;
				Message = "No records found.";
			}
            else
            {
                inputModel.Email = user.Email.ToLower();
            }
        }
		protected async Task Save(bool IsSave) { IsVisible = IsSave; }  
        protected async Task OkClick()  { IsVisible = false; }

		protected async Task SubmitClick()
        {
            var authenticationState = await authenticationStateTask;

            //var user = await _userManager.FindByEmailAsync(inputModel.Email);
			var user = await _accountHttpService.FindByEmailAsync(inputModel.Email);
			var emailConfirm = await _accountHttpService.IsEmailConfirmedByEmailAsync(inputModel.Email);

			if ((user == null || !(emailConfirm)) ||
                (user.UserName.ToUpper() != authenticationState.User.Identity.Name.ToUpper()))
            {
				// Don't reveal that the user does not exist or email does not belong to login user
				//ConfirmationComponent.Show();
				IsVisible = true;
				IsInformationOnly = true;
				Message = "No records found.";

			} else
            {
                string userId = authenticationState.User.Identity.Name.ToUpper();
                //modelView = await _httpService2.LoadGuidePasswordByUserId(userId);
                modelView = (await _httpService.GetAllAsync($"api/Users/GetGuidePasswordByUserId/{userId}", null)).ToList();

                string password = modelView.FirstOrDefault().PASSWORD;
                if (password != "")
                {
                    try
                    {
                        await _emailSender.SendEmailAsync(
                              inputModel.Email,
                              "Forgot GUIDE Password",
                              $"Your GUIDE password is " + password + ", user Id is " + user.UserName);

                    }
                    catch { }
                    navigationManager.NavigateTo($"/GetGuidePasswordByUserIdConfirmation");
                }
            }
        }

        protected void BackClick()
        {
            navigationManager.NavigateTo($"/GUIDEUser");
        }

      
    }
}
