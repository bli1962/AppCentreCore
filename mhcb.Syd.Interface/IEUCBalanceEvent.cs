using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IEUCBalanceEvent
	{
		IEnumerable<MxEucBalanceEvent> GetEUCBalanceEventByCustAbbr(string custAbbr, string optDate);
		IEnumerable<MxEucBalanceEvent> GetEUCBalanceEventByRefno(string refNo, string optDate);
		IEnumerable<MxInboundEventLogView> GetMxInboundEventLogBySender(string sender, string optDate);
		IEnumerable<MxEucBalanceEventView> GetPendingTrans(string UpdateDdate);
		string UpdateStatus(EucBalanceAttribute balanceAttribute);
	}
}