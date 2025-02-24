using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IEUCBalanceEvent
	{
		IEnumerable<MxEucBalanceEventView> GetEUCBalanceEventByCustAbbr(string custAbbr, string optDate);
		IEnumerable<MxEucBalanceEventView> GetEUCBalanceEventByRefno(string refNo, string optDate);
		IEnumerable<MxInboundEventLogView> GetMxInboundEventLogBySender(string sender, string optDate);
        IEnumerable<MxEucBalanceEventView> GetPendingTrans(string UpdateDdate);
        IEnumerable<MxEucBalanceView> GetEucBalanceEvents(string UpdateDdate);

        string UpdateStatus(InputEucBalance balanceAttribute);
	}
}