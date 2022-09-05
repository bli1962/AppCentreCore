using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface IRFRInterestService
    {
        Task<IEnumerable<RFRInterestLoanView>> GetRFRInterestForLoanByReportDate(string reportDate, string custAbbr);
        Task<IEnumerable<RFRInterestSwapView>> GetRFRInterestForSwapByReportDate(string reportDate, string custAbbr);
    }
}
