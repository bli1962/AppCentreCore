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
    public class GetFXTransactionByDatesBase : ComponentBase
    {
        [Inject]
        public IFXDeliveryService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public IEnumerable<FxDeliveryView> modelView { get; set; } = new List<FxDeliveryView>();
        public DateTime SelectedDateFrom { get; set; } = DateTime.Today;
        public DateTime SelectedDateTo { get; set; } = DateTime.Today;

        protected override async Task OnInitializedAsync()
        {
        }

        protected async Task SearchClick()
        {
            modelView = null;
            modelView = (await _httpService.GetFxDeliveryByDates(
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
