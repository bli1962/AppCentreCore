using mhcb.Syd.AppCenter.Services.Interface;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;


namespace mhcb.Syd.AppCenter.Pages.GUIDE.SettlementInf
{
    public class GetSettlementInfByCustAbbrBase :   ComponentBase
    {
        [Inject]
        public ISettlementInfService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public IEnumerable<SettlementInfView> settlementInfView { get; set; } = new List<SettlementInfView>();

        protected CustSearchModel searchModel = new()
        {
            CustAbbr = "",
            BranchNo = "751",
            CustName = "Dummy"
        };

        protected override async Task OnInitializedAsync()
        {
            // modelView = (await _bankInfServiceService.GetPendingBIF()).ToList();
            //return base.OnInitializedAsync();
        }

        protected async Task SearchClick()
        {
            //if ((searchModel.CustAbbr == "")) return;

            settlementInfView = null;
            settlementInfView = (await _httpService.GetSIFByCustAbbr(searchModel.CustAbbr)).ToList();

            if (settlementInfView.Count() == 0)
            {
                //await IJSRuntime.InvokeVoidAsync("alert", "No records found!");
                //bool confirmed = await IJSRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
                //string prompted = await IJSRuntime.InvokeAsync<string>("prompt", "Take some input :");

                //await IJSRuntime.InvokeVoidAsync("AlertMessage", "No Bank Information Found.");
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

        //***********************************************************
        //  For Confirmation purpose codes
        //***********************************************************
        protected MizuhoRazorComponent.ConfirmYesBase ComfirmationComponent { get; set; }
        protected async Task ConfirmClick(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                //await EmployeeService.DeleteEmployee(Employee.EmployeeId);
                //navigationManager.NavigateTo("/");
            }
        }
    }
}
