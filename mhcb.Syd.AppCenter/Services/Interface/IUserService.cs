using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface IUserService
    {  
        Task<IEnumerable<UserView>> GetUserByStatus(string status);
        Task<IEnumerable<UserView>> GetUserById(string userId);
        Task<int> UpdateStatus(UserAttribute userAttr);
    }
}
