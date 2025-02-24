using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IGASService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<GASDebitView>> GetGASTransByDate(string optDate);

        Task<int> UpdateDCSStatus(InputGAS gasAttribute);
    }
}
