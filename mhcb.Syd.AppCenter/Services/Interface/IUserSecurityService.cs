using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface IUserSecurityService
    {
        Task<string> GetAuthorization(string userid);
        Task<List<string>> GetAuthorizations(string userid);
        Task<User> GetGUser(string userid, string decPassword);
        Task<bool> Login(string userid, string decPassword);
    }
}
