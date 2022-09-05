using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.DataAccess.Models.GUIDE;
using System;

namespace mhcb.Syd.AppCenter.Pages.GUIDE.AuditLog
{
    public class GetAuditLogByDatesBase : ComponentBase
    {
        [Inject]
        public IAuditLogService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public IEnumerable<mhcb.Syd.DataAccess.Models.GUIDE.AuditLog> modelView { get; set; } = new List<mhcb.Syd.DataAccess.Models.GUIDE.AuditLog>();

        public DateTime SelectedDateFrom { get; set; } = DateTime.Today;
        public DateTime SelectedDateTo { get; set; } = DateTime.Today;

        protected override async Task OnInitializedAsync()
        {
        }

        protected async Task SearchClick()
        {
            modelView = null;
            modelView = (await _httpService.GetAuditLogByDates(
                                SelectedDateFrom.ToString("yyyy-MM-dd"),
                                SelectedDateTo.ToString("yyyy-MM-dd"))).ToList();

            if (modelView.Count() == 0)
            {
                ComfirmationComponent.Show();
            }
        }
        protected async Task CopyClick()
        {
            //selectElementContents
            await IJSRuntime.InvokeAsync<object>("selectElementContents", "SelectedReport");
            await IJSRuntime.InvokeVoidAsync("alert", "Now you can paste the context to excel file.");
        }

        protected void BackClick()
        {
            navigationManager.NavigateTo($"/");
        }

        //***************************
        //  Confirmation component
        //****************************
        protected MizuhoRazorComponent.ConfirmYesBase ComfirmationComponent { get; set; }
        protected async Task ConfirmClick(bool blnConfirm)
        {
            if (blnConfirm)
            {
                //navigationManager.NavigateTo("/");
            }
        }
    }
}
