using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface ISpecialRateHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<ExchRateView>> GetMizuhoRates();

        Task<int> UpdateStatus(InputRate rate);
    }
}
