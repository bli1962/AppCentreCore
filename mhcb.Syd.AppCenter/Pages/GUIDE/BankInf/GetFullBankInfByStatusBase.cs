
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
namespace mhcb.Syd.AppCenter.Pages.GUIDE.BankInf
{
    public class GetFullBankInfByStatusBase : ComponentBase
    {
        [Inject]
        public IBankInfService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public IEnumerable<BankInfView> modelView { get; set; } = new List<BankInfView>();
        public string SelectStatus { get; set; } = "F";

        protected override async Task OnInitializedAsync()
        {
            // modelView = (await _bankInfServiceService.GetPendingBIF()).ToList();
            //return base.OnInitializedAsync();
        }

        protected async Task SearchClick()
        {
            modelView = null;
            modelView = (await _httpService.GetFullBankInfByStatus(SelectStatus)).ToList();

            if (modelView.Count() == 0)
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
                //await EmployeeService.DeleteEmployee(Employee.EmployeeId);
                //navigationManager.NavigateTo("/");
            }
        }
    }
}
