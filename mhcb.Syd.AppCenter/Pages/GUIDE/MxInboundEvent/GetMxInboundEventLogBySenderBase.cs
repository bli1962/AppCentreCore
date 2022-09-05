using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Pages.GUIDE.MxInboundEvent
{
    public class GetMxInboundEventLogBySenderBase : ComponentBase
    {
        [Inject]
        public IEUCBalanceEventService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public IEnumerable<MxInboundEventLogView> modelView { get; set; } = new List<MxInboundEventLogView>();
       
        public DateTime SelectedOptDate { get; set; } = DateTime.Today;

        public string SelectedCategory { get; set; } = "GBaseRefNo";

        protected override async Task OnInitializedAsync()
        {
        }
        protected async Task SearchClick()
        {
            modelView = null;
            modelView = (await _httpService.GetMxInboundEventLogBySender(
                                SelectedCategory,
                                SelectedOptDate.ToString("yyyy-MM-dd"))).ToList();

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
            navigationManager.NavigateTo($"/MxInbound");
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
