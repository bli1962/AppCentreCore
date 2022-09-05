
using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IFacilityMasterLoanTrans
	{
		IEnumerable<FacilityMasterLoanTransView> GetLoanTransactionByCcyDates(string dateFrom, string dateTo, string ccy);
		IEnumerable<FacilityMasterLoanTransView> GetLoanTransactionByDates(string dateFrom, string dateTo);
	}
}