using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Pages.LoanMaster
{
    public class UpdateSpecialRateBase : ComponentBase
    {
        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        [Inject]
        public ISpecialRateService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public IEnumerable<ExchRateView> modelView { get; set; } = new List<ExchRateView>();
        public string SelectedCcyCode { get; set; } = "AUD";
        public string SelectedRate { get; set; } = "0.00";
        public string SelectedAuthoriser { get; set; } = "";

        protected override async Task OnInitializedAsync()
        {
            var authenticationState = await authenticationStateTask;

            if (!authenticationState.User.Identity.IsAuthenticated)
            {
                string returnUrl = WebUtility.UrlEncode($"/UpdateSpecialRate");
                NavigationManager.NavigateTo($"/identity/account/login?returnUrl={returnUrl}");
            }
            else
            {
                SelectedAuthoriser = authenticationState.User.Identity.Name.ToUpper();
            }
        }

        protected async Task SearchClick()
        {
            modelView = null;
            modelView = (await _httpService.GetMizuhoRates()).ToList();

            if (modelView.Count() == 0)
            {
                ComfirmationComponent.Show();
            }
        }

        protected async Task UpdateStatusClick()
        {
            RateAttribute status = new()
            {
                CcyCode = SelectedCcyCode,
                Rate = Decimal.Parse(SelectedRate),
                AuthorizeBy = SelectedAuthoriser,

            };

            var result = await _httpService.UpdateStatus(status);

            switch (result)
            {
                case 200:
                    //await IJSRuntime.InvokeVoidAsync("AlertMessage", "Save successfully.");
                    ComfirmationComponentSaveSuccess.Show();
                    modelView = (await _httpService.GetMizuhoRates()).ToList();
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
            NavigationManager.NavigateTo($"/ELCS");
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
