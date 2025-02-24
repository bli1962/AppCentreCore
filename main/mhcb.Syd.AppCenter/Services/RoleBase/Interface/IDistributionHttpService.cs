using mhcb.Syd.Models;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IDistributionService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<DistributionPreferenceView>> GetDistributionPreference(string AppName);
        //Task<IEnumerable<DistributionPasswordView>> GetDistributionPassword(string abbreviation, string branch);
        //Task<IEnumerable<DistributionView>> GetElcsConfirmation(string dateAdded);

        Task<int> UpdateStatus(InputEDistribution status);
    }
}


