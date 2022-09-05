using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface ICustomerMaster
	{
		IEnumerable<CustomerMaster> LoadCustomerMasterByCustAbbr(string custAbbr, string branchNo);
	}
}