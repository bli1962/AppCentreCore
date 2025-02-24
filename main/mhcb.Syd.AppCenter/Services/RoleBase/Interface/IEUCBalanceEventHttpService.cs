using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IEUCBalanceEventHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<MxEucBalanceEventView>> GetEUCBalanceEventByCustAbbr(string custAbbr, string optDate);
        //Task<IEnumerable<MxEucBalanceEventView>> GetEUCBalanceEventByRefno(string refNo, string optDate);
        //Task<IEnumerable<MxInboundEventLogView>> GetMxInboundEventLogBySender(string sender, string optDate);
        //Task<IEnumerable<MxEucBalanceEventView>> GetPendingEUCBalanceEvent(string UpdateDdate);
        //Task<IEnumerable<MxEucBalanceView>> GetEUCBalanceEvents(string optDate);

        Task<int> UpdateStatus(InputEucBalance balanceAttribute);
    }
}
