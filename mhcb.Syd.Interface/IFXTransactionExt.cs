using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IFXTransactionExt
	{
		IEnumerable<FXTransactionExtView> GetPendingTrans();
		string UpdateStatus(FXGIDStatus status);
	}
}