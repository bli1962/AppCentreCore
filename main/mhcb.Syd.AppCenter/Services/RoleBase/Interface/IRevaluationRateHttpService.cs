using mhcb.Syd.Models;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IRevaluationRateHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<RevaluationRateViewModel>> GetRevaluationRatesByDate(string dataDate);
        //Task<RevaluationRateViewModel> GetRevaluationRateByDateCcyDay(string dataDate, string ccy, int day);

        Task<int> AddRevaluationRate(RevaluationRateViewModel revaluationRateViewModel);
        Task<string> DeleteRevaluationRate(string dataDate, string ccy, int day);
        Task<int> UpdateRevaluationRate(RevaluationRateViewModel revaluationRateViewModel);
    }
}
