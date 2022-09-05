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

namespace mhcb.Syd.AppCenter.Pages.GUIDE.PaymentControl
{
    public class DeleteSwiftPaymentBase : ComponentBase
    {
        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        [Inject]
        public IPaymentControlService _httpService { get; set; }
        [Inject]
        public ISwiftPaymentService _httpService2 { get; set; }

        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IHttpContextAccessor _httpContext { get; set; }
        public IEnumerable<SwiftPaymentView> modelView { get; set; } = new List<SwiftPaymentView>();

        protected SwiftPaymentStatus UpdateStatus;

        public DateTime SelectedOptDate { get; set; } = DateTime.Today;
        public string SelectedDateType { get; set; } = "ValueDate";
        public string SelectDeletionStatus { get; set; } = "N/A";
        public string SelectGipStatus { get; set; } = "15";

        protected override async Task OnInitializedAsync()
        {
            //return base.OnInitializedAsync();
            UpdateStatus = new()
            {
                PaymentId = 1,
                SwiftPaymentId = 0,
                StatusId = 0,
                AuthorizeBy = ""
            };

            //return base.OnInitializedAsync();
            var authenticationState = await authenticationStateTask;

            if (!authenticationState.User.Identity.IsAuthenticated)
            {
                string returnUrl = WebUtility.UrlEncode($"/UpdatePayment");
                NavigationManager.NavigateTo($"/identity/account/login?returnUrl={returnUrl}");
            }
            else
            {
                //SelectedAuthoriser = authenticationState.User.Identity.Name.ToUpper();
                UpdateStatus.AuthorizeBy = authenticationState.User.Identity.Name.ToUpper();

                string myAutication = _httpContext.HttpContext.Session.GetString("GuideAuthorizorCookies");
                if ((myAutication == null) || !myAutication.Contains("Payment Control Auth"))
                {
                    //await IJSRuntime.InvokeVoidAsync("alert", "You don't have GUIDE authorization permission, please logout/login again.");
                    NavigationManager.NavigateTo($"/AccessDeny");
                }
            }
        }

        protected async Task SearchClick()
        {
            modelView = null;
            modelView = (await _httpService2.GetSwiftPTransByDate(
                                SelectedOptDate.ToString("yyyy-MM-dd"),
                                SelectedDateType)).ToList();

            if (modelView.Count() == 0)
            {
                ComfirmationComponent.Show();
            }
        }

        protected async Task DeleteClick()
        {
            //if ((SelectedSwiftPaymentId == "") || (Int32.Parse(SelectedSwiftPaymentId) < 1)) return;

            var result = await _httpService2.DeleteSwiftPayment(UpdateStatus);

            switch (result)
            {
                case 200:
                    //await IJSRuntime.InvokeVoidAsync("AlertMessage", "Save successfully.");
                    ComfirmationComponentSaveSuccess.Show();
                    modelView = (await _httpService2.GetSwiftPTransByDate(
                             SelectedOptDate.ToString("yyyy-MM-dd"),
                             SelectedDateType)).ToList();
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

        //protected void SetGipStatus()
        //{
        //    if (SelectDeletionStatus == "D")
        //    {
        //        SelectGipStatus = "8";
        //    }
        //    else
        //    {
        //        SelectGipStatus = "4";
        //    }
        //}


        protected void BackClick()
        {
            NavigationManager.NavigateTo($"/PaymentControl");
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
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
