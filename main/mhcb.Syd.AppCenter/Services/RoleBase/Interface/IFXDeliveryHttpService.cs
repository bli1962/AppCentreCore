using System.Collections.Generic;
using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IFXDeliveryHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<FxDeliveryView>> GetFxDeliveryCorpByDate(string deliveryDate);
        //Task<IEnumerable<FxDeliveryCorpSummaryView>> GetFxDeliveryCorpSummaryByDate(string deliveryDate);
        //Task<FxSettlementInf> GetFXSettlementByRefNo(string refNo);
        //Task<IEnumerable<FxDeliveryView>> GetFxDeliveryByDates(string strDateFrom, string strDateTo);

        Task<IEnumerable<FXDeliveryView>> GetPendingFxDelivery();
        Task<int> UpdateStatus(InputFXTrans status);
    }
}
