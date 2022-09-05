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

namespace mhcb.Syd.AppCenter.Pages.GUIDE.MoneyMarketTicket
{
    public class UpdateMoneyMarketTicketBase : ComponentBase
    {
        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        [Inject]
        public IMoneyMarketTicketService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public IHttpContextAccessor _httpContext { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public MMGIDStatus UpdateStatus;

        public IEnumerable<MoneyMarketTicketView> modelView { get; set; } = new List<MoneyMarketTicketView>();
      
   
        protected override async Task OnInitializedAsync()
        {
            UpdateStatus = new()
            {
                TicketId = 0,
                optDate = DateTime.Today,
                AuthorizeBy = "",
            };

            var authenticationState = await authenticationStateTask;

            if (!authenticationState.User.Identity.IsAuthenticated)
            {
                string returnUrl = WebUtility.UrlEncode($"/UpdateMoneyMarketTicket");
                NavigationManager.NavigateTo($"/identity/account/login?returnUrl={returnUrl}");
            }
            else
            {
                UpdateStatus.AuthorizeBy = authenticationState.User.Identity.Name.ToUpper();

                string myAutication = _httpContext.HttpContext.Session.GetString("GuideAuthorizorCookies");
                if ((myAutication == null) || !myAutication.Contains("Money Market Modify"))
                {
                    //await IJSRuntime.InvokeVoidAsync("alert", "You don't have GUIDE authorization permission, please logout/login again.");
                    NavigationManager.NavigateTo($"/AccessDeny");
                }
            }
        }

        protected async Task SearchClick()
        {
            modelView = null;
            modelView = (await _httpService.GetMMGID()).ToList();

            if (modelView.Count() == 0)
            {
                ComfirmationComponent.Show();
            }
        }

        protected async Task UpdateStatusClick()
        {
            //if ((MMstatus.TicketId == 0) || (MMstatus.TicketId).ToString() == "" )return;

            var result = await _httpService.UpdateStatus(UpdateStatus);

            switch (result)
            {
                case 200:
                    //await IJSRuntime.InvokeVoidAsync("AlertMessage", "Save successfully.");
                    ComfirmationComponentSaveSuccess.Show();
                    modelView = (await _httpService.GetMMGID()).ToList();
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
