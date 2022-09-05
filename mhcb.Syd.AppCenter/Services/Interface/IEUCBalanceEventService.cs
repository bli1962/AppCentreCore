using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface IEUCBalanceEventService
    {
        Task<IEnumerable<MxEucBalanceEvent>> GetEUCBalanceEventByCustAbbr(string custAbbr, string optDate);
        Task<IEnumerable<MxEucBalanceEvent>> GetEUCBalanceEventByRefno(string refNo, string optDate);
        Task<IEnumerable<MxInboundEventLogView>> GetMxInboundEventLogBySender(string sender, string optDate);

        Task<IEnumerable<MxEucBalanceEventView>> GetPendingEUCBalanceEvent(string UpdateDdate);
        Task<int> UpdateStatus(EucBalanceAttribute balanceAttribute);
    }
}
