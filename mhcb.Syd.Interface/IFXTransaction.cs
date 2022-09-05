using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IFXTransaction
	{
		IEnumerable<FxTransaction> GetFullFXTransactionByDates(string strDateFrom, string strDateTo, string dateType);
		IEnumerable<FXTransactionView> GetPendingTrans();
		IEnumerable<FXTransactionView> GetFXTransactionByDatesCustAbbr(string dateFrom, string dateTo, string dateType, string custName);	
		FxTransaction GetFxTransByRefNo(string refNo);
		string UpdateStatus(FXTranStatus status);
	}
}