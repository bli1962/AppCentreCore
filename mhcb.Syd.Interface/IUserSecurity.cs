using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IUserSecurity
	{
		string GetAuthorization(string userid);
		IEnumerable<string> GetAuthorizations(string userid);
		User GetGUser(string userid, string decPassword);
		bool Login(string userid, string decPassword);
	}
}