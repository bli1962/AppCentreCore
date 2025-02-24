using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IRFRInterest
	{
		IEnumerable<RFRInterestLoanView> GetRFRInterestForLoanByReportDate(string reportDate, string custAbbr, string SPConnection);
		IEnumerable<RFRInterestSwapView> GetRFRInterestForSwapByReportDate(string reportDate, string custAbbr, string SPConnection);
	}
}