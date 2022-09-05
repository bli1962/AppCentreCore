using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IUser
	{
		IEnumerable<UserView> LoadUserByUserId(string userId);
		IEnumerable<UserView> LoadUsersByRecStatus(string status);
		string UpdateStatus(UserAttribute userAttr);
	}
}