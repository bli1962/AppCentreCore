using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IPaymentControlHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<SwiftPaymentView>> GetPPTransByDate(string dateValue, string dateType);

        Task<int> UpdateStatus(InputSwiftPayment status);
    }
}
