using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;
using System.Collections.Generic;

namespace mhcb.Syd.Interface
{
	public interface IFXDelivery
	{
		IEnumerable<FxDeliveryView> GetFxDeliveryCorpByDate(string deliveryDate, string SPConnection);
		IEnumerable<FxDeliveryCorpSummaryView> GetFxDeliveryCorpSummaryByDate(string deliveryDate, string SPConnection);
		IEnumerable<FXDeliveryView> GetPendingTrans();
		IEnumerable<FxDeliveryView> GetFxDeliveryByDates(string dateFrom, string dateTo);
		FxSettlementInf GetFxDeliveryByRefNo(string refNo);
		string UpdateStatus(FXTranStatus status);
	}
}