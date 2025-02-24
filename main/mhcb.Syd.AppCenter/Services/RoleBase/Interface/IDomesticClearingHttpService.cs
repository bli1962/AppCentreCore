using mhcb.Syd.Models;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IDomesticClearingHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<DomesticClearingPaymentView>> GetDCPaymentByDate(string dateValue, string dateType);

        Task<int> UpdateStatus(DomesticClearingAttribute status);
    }
}
