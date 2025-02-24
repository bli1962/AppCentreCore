using System.Collections.Generic;
using System.Threading.Tasks;
using mhcb.Syd.Models;

namespace mhcb.Syd.AppCenter.Services.RoleBase.Interface
{
    public interface IRFRInterestHttpService
    {
        Task<IEnumerable<RFRInterestLoanView>> GetRFRInterestForLoanByReportDate(string reportDate, string custAbbr);
        Task<IEnumerable<RFRInterestSwapView>> GetRFRInterestForSwapByReportDate(string reportDate, string custAbbr);
    }
}
