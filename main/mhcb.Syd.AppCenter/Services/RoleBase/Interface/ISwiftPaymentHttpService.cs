using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface ISwiftPaymentHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<SwiftPaymentView>> GetSwiftPTransByDate(string dateValue, string dateType);

        Task<int> UpdateDeleteSwiftPayment(InputSwiftPayment status);
    }
}
