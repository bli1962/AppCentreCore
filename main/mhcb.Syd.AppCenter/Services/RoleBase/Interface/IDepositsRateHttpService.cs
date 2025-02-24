using mhcb.Syd.Models;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IDepositsRateHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<DepositsRateViewModel>> GetDepositsRatesByDate(string dataDate);
        //Task<DepositsRateViewModel> GetDepositsRateByDateCcyPeriod(string dataDate, string ccy, string period);

        Task<int> AddDepositsRate(DepositsRateViewModel depositsRateViewModel);
        Task<string> DeleteDepositsRate(string dataDate, string ccy, string period);
        Task<int> UpdateDepositsRate(DepositsRateViewModel depositsRateViewModel);
    }
}
