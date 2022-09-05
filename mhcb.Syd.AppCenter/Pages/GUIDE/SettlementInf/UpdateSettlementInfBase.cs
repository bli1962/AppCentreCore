using mhcb.Syd.AppCenter.Services.Interface;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace mhcb.Syd.AppCenter.Pages.GUIDE.SettlementInf
{
    public class UpdateSettlementInfBase : ComponentBase
    {
        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        [Inject]
        public ISettlementInfService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public IHttpContextAccessor _httpContext { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IWebHostEnvironment Env { get; set; }

        public IEnumerable<SettlementInfView> settlementInfView { get; set; } = new List<SettlementInfView>();
        public SIFStatus UpdateStatus;

        //[Inject]
        //public SignInManager<IdentityUser> _signInManager { get; set; }
        //[Inject]
        //public UserManager<IdentityUser> _userManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            UpdateStatus = new SIFStatus()
            {
                //SifId = 0,
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
                string returnUrl = WebUtility.UrlEncode($"/UpdateSettlementInf");
                NavigationManager.NavigateTo($"/identity/account/login?returnUrl={returnUrl}");
            }
            else
            {
                UpdateStatus.AuthorizeBy = authenticationState.User.Identity.Name.ToUpper();

                //if (!Env.IsDevelopment())
                //{
                string myAutication = _httpContext.HttpContext.Session.GetString("GuideAuthorizorCookies");
                if ((myAutication == null) || !myAutication.Contains("SIF - Authorise"))
                {
                    //await IJSRuntime.InvokeVoidAsync("alert", "You don't have GUIDE authorization permission, please logout/login again.");
                    NavigationManager.NavigateTo($"/AccessDeny");
                }
                //}

            }
        }

        protected async Task SearchClick()
        {
            settlementInfView = null;
            settlementInfView = (await _httpService.GetPendingSIF()).ToList();
            if (settlementInfView.Count() == 0)
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
            var result = await _httpService.UpdateStatus(UpdateStatus);

            switch (result)
            {
                case 200:
                    //await IJSRuntime.InvokeVoidAsync("AlertMessage", "Save successfully.");
                    ComfirmationComponentSaveSuccess.Show();
                    settlementInfView = (await _httpService.GetPendingSIF()).ToList();
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

        //***********************************************************
        //  For Confirmation purpose codes
        //***********************************************************
        protected MizuhoRazorComponent.ConfirmYesBase ComfirmationComponent { get; set; }
        protected MizuhoRazorComponent.ConfirmYesBase ComfirmationComponentSaveSuccess { get; set; }
        protected MizuhoRazorComponent.ConfirmYesBase ComfirmationComponentSaveUnsuccess { get; set; }
        protected MizuhoRazorComponent.ConfirmYesBase ComfirmationComponentBadRequest { get; set; }
        protected MizuhoRazorComponent.ConfirmYesBase ComfirmationComponentError { get; set; }
        protected async Task ConfirmClick(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {

            }
        }
    }
}
