using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IFXFCust
	{
		IEnumerable<FXFCustomerView> LoadFXCustByCustAbbr(string abbreviation);
		string UpdateStatus(FXFCustAttribute custAttr);
	}
}