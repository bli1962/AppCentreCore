using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IFXFCustHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<FXFCustomerView>> GetMMCustByAbbr(string abbreviation);

        Task<int> UpdateStatus(InputFXFCustomer custAttr);
    }
}
