using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface IFXTransactionService
    {
        Task<IEnumerable<FxTransaction>> GetFullFXTransactionByDates(string dateFrom, string dateTo, string dateType);
        Task<IEnumerable<FXTransactionView>> GetPendingFxTrans();
        Task<IEnumerable<FXTransactionView>> GetFxTransByDatesCustAbbr(string dateFrom, string dateTo, string dateType, string custName);
        Task<FxTransaction> GetFxTransByRefNo(string refNo);
        Task<int> UpdateStatus(FXTranStatus status);
    }
}
