using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface IFXDeliveryService
    {
        Task<IEnumerable<FxDeliveryView>> GetFxDeliveryCorpByDate(string deliveryDate);
        Task<IEnumerable<FxDeliveryCorpSummaryView>> GetFxDeliveryCorpSummaryByDate(string deliveryDate);
        Task<FxSettlementInf> GetFXSettlementByRefNo(string refNo);
        Task<IEnumerable<FxDeliveryView>> GetFxDeliveryByDates(string strDateFrom, string strDateTo);
        Task<IEnumerable<FXDeliveryView>> GetPendingFxDelivery();
        Task<int> UpdateStatus(FXTranStatus status);
    }
}
