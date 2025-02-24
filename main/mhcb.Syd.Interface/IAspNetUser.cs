using mhcb.Syd.DataAccess.Models.AppCenter;
using mhcb.Syd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Interface
{
    public interface IAspNetUser
    {
        IEnumerable<AspNetUser> GetUsers();
        AspNetUser GetUser(string Id);
        AspNetUser GetUserDetails(string Id);

        string Login(string userName, string password, bool isPersistent);

        string RegisterUser(AspNetUser user);
    }
}
