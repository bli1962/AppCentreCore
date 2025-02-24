using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IFXTransactionExtHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<FXTransactionExtView>> GetFXGID();

        Task<int> UpdateStatus(InputFXGID status);
    }
}
