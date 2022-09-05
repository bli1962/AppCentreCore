using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Pages.GUIDE.FXTransaction
{
    public class GetFullFXTransactionByDatesBase : ComponentBase
    {

        [Inject]
        public IFXTransactionService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public IEnumerable<FxTransaction> modelView { get; set; } = new List<FxTransaction>();
        public DateTime SelectedDateFrom { get; set; } = DateTime.Today;
        public DateTime SelectedDateTo { get; set; } = DateTime.Today;
        public string SelectedDateType { get; set; } = "ContractValueDate";

        protected override async Task OnInitializedAsync()
        {
        }

        protected async Task SearchClick()
        {
            modelView = null;
            modelView = (await _httpService.GetFullFXTransactionByDates(
                                SelectedDateFrom.ToString("yyyy-MM-dd"),
                                SelectedDateTo.ToString("yyyy-MM-dd"),
                                SelectedDateType)).ToList();

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
            navigationManager.NavigateTo($"/AuditReport");
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
