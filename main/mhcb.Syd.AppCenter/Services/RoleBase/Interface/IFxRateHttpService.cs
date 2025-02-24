using mhcb.Syd.Models;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IFxRateHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<FxRateViewModel>> GetFxRatesByDate(string dataDate);
        //Task<FxRateViewModel> GetFxRateByDateCcy(string dataDate, string ccy);

        Task<int> AddFxRate(FxRateViewModel fxRateViewModel);
        Task<string> DeleteFxRate(string dataDate, string ccy);
        Task<int> UpdateFxRate(FxRateViewModel fxRateViewModel);
    }
}
