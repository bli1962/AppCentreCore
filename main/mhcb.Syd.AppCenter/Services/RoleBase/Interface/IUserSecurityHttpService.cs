using System.Collections.Generic;
using System.Threading.Tasks;
 

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IUserSecurityHttpService
    {
        Task<string> GetAuthorization(string userid);
        Task<List<string>> GetAuthorizations(string userid);
    }
}
