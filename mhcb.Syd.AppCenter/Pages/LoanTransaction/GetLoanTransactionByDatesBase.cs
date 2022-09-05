using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Pages.LoanTransaction
{
    public class GetLoanTransactionByDatesBase : ComponentBase
    {
        [Inject]
        public IFacilityMasterLoanTransService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public IEnumerable<FacilityMasterLoanTransView> modelView { get; set; } = new List<FacilityMasterLoanTransView>();
        public DateTime SelectedDateFrom { get; set; } = DateTime.Today;
        public DateTime SelectedDateTo { get; set; } = DateTime.Today;
        public string SelectedCcyCode { get; set; } = "AUD";

        protected override async Task OnInitializedAsync()
        {
        }

        protected async Task SearchClick()
        {
            modelView = null;
            modelView = (await _httpService.GetLoanTransactionByCcyDates(
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
            navigationManager.NavigateTo($"/ELCSReport");
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
