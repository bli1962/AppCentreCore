using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IFXTransactionHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<FxTransactionCompleteView>> GetFullFXTransactionByDates(string dateFrom, string dateTo, string dateType);
        //Task<IEnumerable<FXTransactionView>> GetPendingFxTrans();
        //Task<IEnumerable<FXTransactionView>> GetFxTransByDatesCustAbbr(string dateFrom, string dateTo, string dateType, string custName);
        //Task<FxTransaction> GetFxTransByRefNo(string refNo);

        Task<int> UpdateStatus(InputFXTrans status);
    }
}
