using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Pages.LOAN
{
    public class GetCovenantRatioBase : ComponentBase
    {
        [Inject]
        public ICovenantMasterService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public IEnumerable<CovenantRatioView> modelView { get; set; } = new List<CovenantRatioView>();
        //public DateTime SelectedDateFrom { get; set; } = DateTime.Today;
        //public DateTime SelectedDateTo { get; set; } = DateTime.Today;
        //public string SelectCustAbbr { get; set; } = "";
        //public string SelectBranchNo { get; set; } = "751";

        public string SelectedCovenantType { get; set; } = "Covenant";

        protected override async Task OnInitializedAsync()
        {
        }

        protected async Task SearchClick()
        {
            modelView = null;
            modelView = (await _httpService.GetCovenantRatio(SelectedCovenantType)).ToList();

            if (modelView.Count() == 0)
            {
                ComfirmationComponent.Show();
            }
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
