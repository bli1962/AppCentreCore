using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface ISettlementInfHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<SettlementInfView>> GetPendingSIF();
        //Task<IEnumerable<SettlementInfView>> GetSIFById(int id);
        //Task<IEnumerable<SettlementInfView>> GetSIFByCustAbbr(string custAbbr);
        //Task<IEnumerable<SettlementInfView>> GetSifInstructionsByStatus(string status);
        //Task<IEnumerable<SettlementInfView>> GetSIFByCustAbbrCcyCDRecKind(string custAbbr, string ccyCD, string recordKind);
        //Task<IEnumerable<SettlementInf>> GetSIFByStatus(string status = "All");

        Task<int> UpdateStatus(InputSIF status);
    }
}
