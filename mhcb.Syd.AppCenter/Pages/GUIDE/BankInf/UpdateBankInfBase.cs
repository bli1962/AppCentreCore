using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Pages.GUIDE.BankInf
{
    public class UpdateBankInfBase : ComponentBase
    {
        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        [Inject]
        public IBankInfService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public IHttpContextAccessor _httpContext { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IWebHostEnvironment Env { get; set; }

        public IEnumerable<BankInfView> modelView { get; set; } = new List<BankInfView>();
        public BankInfStatus UpdateStatus;

        //[Inject]
        //public SignInManager<IdentityUser> _signInManager { get; set; }
        //[Inject]
        //public UserManager<IdentityUser> _userManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            UpdateStatus = new BankInfStatus()
            {
                SwiftId = "",
                AuthorizeBy = "",
                Status = "F",
                DeletionStatus = "",
                GipDescription = "Approved",
                GipStatus = "4",
                TranNo = ""
            };

            //return base.OnInitializedAsync();
            var authenticationState = await authenticationStateTask;

            if (!authenticationState.User.Identity.IsAuthenticated)
            {
                string returnUrl = WebUtility.UrlEncode($"/UpdateBankInf");
                NavigationManager.NavigateTo($"/identity/account/login?returnUrl={returnUrl}");
            }
            else
            {
                UpdateStatus.AuthorizeBy = authenticationState.User.Identity.Name.ToUpper();

                //if (!Env.IsDevelopment())
                //{
                string myAutication = _httpContext.HttpContext.Session.GetString("GuideAuthorizorCookies");
                if ((myAutication == null) || !myAutication.Contains("BIF - Authorise"))
                {
                    //await IJSRuntime.InvokeVoidAsync("alert", "You don't have GUIDE authorization permission, please logout/login again.");
                    NavigationManager.NavigateTo($"/AccessDeny");
                }
                //}
            }
        }

        protected async Task SearchClick()
        {
            modelView = null;
            modelView = (await _httpService.GetPendingBIF()).ToList();
            if (modelView.Count() == 0)
            {
                //await IJSRuntime.InvokeVoidAsync("alert", "No records found!");
                //bool confirmed = await IJSRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
                //string prompted = await IJSRuntime.InvokeAsync<string>("prompt", "Take some input :");

                //await IJSRuntime.InvokeVoidAsync("AlertMessage", "No Bank Information Found.");
                ComfirmationComponent.Show();
            }
        }

        protected async Task UpdateStatusClick()
        {
            var claims = new[]
                   {
                        new Claim(ClaimTypes.Role, "BIF - Authorise" )
                    };
            var accessToken = JwtToken.GenerateJwtTokenByClaims(claims);

            var result = await _httpService.UpdateStatus(UpdateStatus);

            switch (result)
            {
                case 200:
                    //await IJSRuntime.InvokeVoidAsync("AlertMessage", "Save successfully.");
                    ComfirmationComponentSaveSuccess.Show();
                    modelView = (await _httpService.GetPendingBIF()).ToList();
                    break;
                case 404:
                    //await IJSRuntime.InvokeVoidAsync("AlertMessage", "Save unsuccessfully.");
                    ComfirmationComponentSaveUnsuccess.Show();
                    break;
                case 401:
                    //await IJSRuntime.InvokeVoidAsync("AlertMessage", "Bad request");
                    ComfirmationComponentBadRequest.Show();
                    break;
                default:
                    //await IJSRuntime.InvokeVoidAsync("AlertMessage", "Error retrieving data from the database");
                    ComfirmationComponentError.Show();
                    break;
            }
        }

        protected void SetGipStatus()
        {
            if (UpdateStatus.DeletionStatus == "D")
            {
                UpdateStatus.GipStatus = "8";
            }
            else
            {
                UpdateStatus.GipStatus = "4";
            }
        }

        protected void BackClick()
        {
            NavigationManager.NavigateTo($"/GUIDE");
        }

        //***************************
        //  Confirmation component
        //****************************
        protected MizuhoRazorComponent.ConfirmYesBase ComfirmationComponent { get; set; }
        protected MizuhoRazorComponent.ConfirmYesBase ComfirmationComponentSaveSuccess { get; set; }
        protected MizuhoRazorComponent.ConfirmYesBase ComfirmationComponentSaveUnsuccess { get; set; }
        protected MizuhoRazorComponent.ConfirmYesBase ComfirmationComponentBadRequest { get; set; }
        protected MizuhoRazorComponent.ConfirmYesBase ComfirmationComponentError { get; set; }
        protected async Task ConfirmClick(bool blnConfirm)
        {
            if (blnConfirm)
            {
                //navigationManager.NavigateTo("/");
            }
        }
    }
}
