using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IBankInfHttpService
    {
        // ** Move to generic http service **
        //Task<IEnumerable<BankInfView>> GetPendingBIF();
        //Task<IEnumerable<BankInfView>> GetBIFByCustName(string custName, string branchNo);
        //Task<IEnumerable<BankInfView>> GetBIFBySwiftID(string swiftId);
        //Task<IEnumerable<BankInfView>> GetBIFByStatus(string status);
        //Task<IEnumerable<BankInfView>> GetFullBankInfByStatus(string status);

        Task<int> UpdateStatus(InputBIF status);
    }
}
