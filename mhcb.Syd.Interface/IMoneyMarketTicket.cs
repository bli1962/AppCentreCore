using mhcb.Syd.Models;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IMoneyMarketTicket
	{
		IEnumerable<MoneyMarketReportView> GetMoneyMarketTransactionByDates(string dateFrom, string dateTo);
		IEnumerable<MoneyMarketTicketView> GetPendingTrans();
		string UpdateStatus(MMGIDStatus status);
	}
}