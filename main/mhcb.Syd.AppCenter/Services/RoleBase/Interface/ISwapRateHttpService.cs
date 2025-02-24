using mhcb.Syd.Models;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface ISwapRateHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<SwapRateViewModel>> GetSwapRatesByDate(string dataDate);
        //Task<SwapRateViewModel> GetSwapRateByDateCcyDuration(string dataDate, string ccy, int duration, string unit);

        Task<int> AddSwapRate(SwapRateViewModel swapRateViewModel);
        Task<string> DeleteSwapRate(string dataDate, string ccy, int duration, string unit);
        Task<int> UpdateSwapRate(SwapRateViewModel swapRateViewModel);
    }
}
