using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Pages.GUIDE.FXTransaction
{
    public class GetFXTransactionByDatesCustAbbrBase : ComponentBase
    {
        [Inject]
        public IFXTransactionService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public IEnumerable<FXTransactionView> modelView { get; set; } = new List<FXTransactionView>();
        public DateTime SelectedDateFrom { get; set; } = DateTime.Today;
        public DateTime SelectedDateTo { get; set; } = DateTime.Today;
        public string dateType { get; set; } = "DelivaryDate";

        protected CustSearchModel searchModel = new()
        {
            CustAbbr = "Dummy",
            BranchNo = "751",
            CustName = ""
        };
        
        protected override async Task OnInitializedAsync()
        {
        }

        protected async Task SearchClick()
        {
            //if ((searchModel.CustName == "")) return;
         
            modelView = null;
            modelView = (await _httpService.GetFxTransByDatesCustAbbr(
                                            SelectedDateFrom.ToString("yyyy-MM-dd"),
                                            SelectedDateTo.ToString("yyyy-MM-dd"),
                                            dateType, searchModel.CustName)).ToList();

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
            navigationManager.NavigateTo($"/GUIDEReport");
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
