using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Pages.LoanMaster
{
    public class GetLoanRfrInterestBase : ComponentBase
    {
        [Inject]
        public IRFRInterestService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }
        public IEnumerable<RFRInterestLoanView> modelView { get; set; } = new List<RFRInterestLoanView>();
        public DateTime SelectReportDate { get; set; } = DateTime.Today;

        public DateTime SelectedOptDate { get; set; } = DateTime.Today;

        //public string SelectCustAbbr { get; set; } = "";
        protected CustSearchModel searchModel = new()
        {
            CustAbbr = "",
            BranchNo = "751",
            CustName = "Dummy"
        };

        protected override async Task OnInitializedAsync()
        {
        }

        protected async Task SearchClick()
        {
            //if ((searchModel.CustAbbr == "")) return;

            modelView = null;
            modelView = (await _httpService.GetRFRInterestForLoanByReportDate(
                                SelectReportDate.ToString("yyyy-MM-dd"),
                                searchModel.CustAbbr)).ToList();

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
