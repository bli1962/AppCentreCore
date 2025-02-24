using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IEDocumentHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<eDocumentView>> GetPendingEDoc(string eDocType, string optDate);

        Task<int> UpdateStatus(InputEDocument eDocAttribute);
    }
}
