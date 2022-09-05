using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Pages.GUIDE.GAS
{
    public class UpdateGasPendingTransactionBase : ComponentBase
    {
        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        [Inject]
        public IGASService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IHttpContextAccessor _httpContext { get; set; }
        public IEnumerable<GASDebitView> modelView { get; set; } = new List<GASDebitView>();

        public GASAttribute UpdateStatus;

        public string SelectedMinNo { get; set; } = "";
        public DateTime SelectedOptDate { get; set; } = DateTime.Today;

        public string lblUpdateButton { get; set; } = "Set to GAS status";

        protected override async Task OnInitializedAsync()
        {
           UpdateStatus = new()
            {
                MinNo = "",
                valueDate = DateTime.Today,
                StatusId = 8,
                AuthorizeBy = "",
                HasDCSPayment = "No",
            };


            //return base.OnInitializedAsync();
            var authenticationState = await authenticationStateTask;

            if (!authenticationState.User.Identity.IsAuthenticated)
            {
                string returnUrl = WebUtility.UrlEncode($"/UpdateGasPendingTransaction");
                NavigationManager.NavigateTo($"/identity/account/login?returnUrl={returnUrl}");
            }
            else
            {
                UpdateStatus.AuthorizeBy = authenticationState.User.Identity.Name.ToUpper();

                string myAutication = _httpContext.HttpContext.Session.GetString("GuideAuthorizorCookies");
                if ((myAutication == null) || !myAutication.Contains("FX-Trans - Authorise"))
                {
                    await IJSRuntime.InvokeVoidAsync("alert", "You don't have GUIDE authorization permission, please logout/login again.");
                    NavigationManager.NavigateTo($"/GUIDE");
                }
            }
        }

        protected async Task SearchClick()
        {        
            modelView = null;
            modelView = (await _httpService.GetGASTransByDate(SelectedOptDate.ToString("yyyy-MM-dd"))).ToList();

            if (modelView.Count() == 0)
            {
                ComfirmationComponent.Show();
            }
        }

        protected async Task UpdateStatusClick()
        {
            //if (gasStatus.MinNo == "") return;

            var result = await _httpService.UpdateDCSStatus(UpdateStatus);

            switch (result)
            {
                case 200:
                    //await IJSRuntime.InvokeVoidAsync("AlertMessage", "Save successfully.");
                    ComfirmationComponentSaveSuccess.Show();
                    modelView = (await _httpService.GetGASTransByDate(SelectedOptDate.ToString("yyyy-MM-dd"))).ToList();
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

        protected void SetStatus()
        {
            if (UpdateStatus.HasDCSPayment == "Yes")
            {
                UpdateStatus.StatusId = 10;
                lblUpdateButton ="Set to DCS status";
            }
            else
            {
                lblUpdateButton = "Set to GAS status";
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
                //NavigationManager.NavigateTo("/");
            }
        }
    }
}
