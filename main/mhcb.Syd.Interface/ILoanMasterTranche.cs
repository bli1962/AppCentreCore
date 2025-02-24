using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface ILoanMasterTranche
	{
		IEnumerable<LoanMasterTrancheView> GetCovenantCheckList();
		IEnumerable<LoanMasterTrancheView> GetLiborDiscontinuation();
	}
}