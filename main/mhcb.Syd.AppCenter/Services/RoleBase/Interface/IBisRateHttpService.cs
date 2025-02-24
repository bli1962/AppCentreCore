using mhcb.Syd.Models;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IBisRateHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<BisRateViewModel>> GetBisRatesByDate(string dataDate);
        //Task<BisRateViewModel> GetBisRatesByDateCcyDuration(string dataDate, string ccy, int duration, string unit);

        Task<int> AddBisRate(BisRateViewModel bisRateViewModel);
        Task<string> DeleteBisRate(string dataDate, string ccy, int duration, string unit);
        Task<int> UpdateBisRate(BisRateViewModel bisRateViewModel);
    }
}
