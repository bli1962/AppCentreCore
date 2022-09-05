using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Pages.GUIDE.FXFCust
{
    public class GetFXFCustByAbbrBase : ComponentBase
    {
        [Inject]
        public IFXFCustService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public IEnumerable<FXFCustomerView> modelView { get; set; } = new List<FXFCustomerView>();

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
            modelView = (await _httpService.GetMMCustByAbbr(searchModel.CustAbbr)).ToList();
            if (modelView.Count() == 0)
            {
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
