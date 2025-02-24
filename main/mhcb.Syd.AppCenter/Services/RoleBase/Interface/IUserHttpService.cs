using System.Collections.Generic;
using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IUserHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<UserView>> GetUserByStatus(string status);
        //Task<IEnumerable<UserView>> GetUserById(string userId);
        Task<IEnumerable<UserView>> LoadGuidePasswordByUserId(string userId);

        Task<int> UpdateStatus(InputGuideUser userAttr);
    }
}
