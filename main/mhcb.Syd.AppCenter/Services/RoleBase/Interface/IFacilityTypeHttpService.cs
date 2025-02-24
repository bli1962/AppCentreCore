using mhcb.Syd.Models;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IFacilityTypeHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<FacilityTypeOverride>> GetFacilityType();

        Task<int> InsertFacilityType(InputFacilityType status);
    }
}
