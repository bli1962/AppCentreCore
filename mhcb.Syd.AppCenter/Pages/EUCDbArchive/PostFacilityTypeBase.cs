using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.DataAccess.Models.EUCDbArchive;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Pages.EUCDbArchive
{
    public class PostFacilityTypeBase : ComponentBase
    {

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        [Inject]
        public IFacilityTypeService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public IHttpContextAccessor _httpContext { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IWebHostEnvironment Env { get; set; }

        public IEnumerable<FacilityTypeOverride> modelView { get; set; } = new List<FacilityTypeOverride>();
        public FacilityTypeAttribute facilityTypeAttr;

        protected override async Task OnInitializedAsync()
        {
            facilityTypeAttr = new FacilityTypeAttribute()
            {
                RefNo = "",
                FacilityType = "Committed",
                AuthorizeBy = ""
            };

            var authenticationState = await authenticationStateTask;

            if (!authenticationState.User.Identity.IsAuthenticated)
            {
                string returnUrl = WebUtility.UrlEncode($"/UpdateFXFCustAttribute");
                NavigationManager.NavigateTo($"/identity/account/login?returnUrl={returnUrl}");
            }
            else
            {
                facilityTypeAttr.AuthorizeBy = authenticationState.User.Identity.Name.ToUpper();

                //string myAutication = _httpContext.HttpContext.Session.GetString("GuideAuthorizorCookies");
                //if ((myAutication == null) || !myAutication.Contains("Customer - Authorise"))
                //{
                //    NavigationManager.NavigateTo($"/AccessDeny");
                //}

            }
        }

        protected async Task UpdateStatusClickAsync()
        {
            var result = await _httpService.InsertFacilityType(facilityTypeAttr);

            switch (result)
            {
                case 200:
                    //await IJSRuntime.InvokeVoidAsync("AlertMessage", "Save successfully.");
                    ComfirmationComponentSaveSuccess.Show();
                    break;
                case 422:
                    //await IJSRuntime.InvokeVoidAsync("AlertMessage", "Save unsuccessfully.");
                    ComfirmationComponentSaveUnsuccess.Show();
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
                NavigationManager.NavigateTo("/ELCS");
            }
        }



    }
}
