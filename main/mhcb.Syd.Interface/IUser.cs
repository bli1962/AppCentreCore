using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IUser
	{
        IEnumerable<UserView> LoadUserByUserId(string userId);

		IEnumerable<UserView> LoadGuidePasswordByUserId(string userId);
		//UserView LoadGuidePasswordByUserId(string userId);

		IEnumerable<UserView> LoadUsersByRecStatus(string status);
		string UpdateStatus(InputGuideUser userAttr);
	}
}