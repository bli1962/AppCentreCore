using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface IFacilityMasterLoanTransService
    {
        Task<IEnumerable<FacilityMasterLoanTransView>> GetLoanTransactionByCcyDates(string dateFrom, string dateTo);
        Task<IEnumerable<FacilityMasterLoanTransView>> GetLoanTransactionByDatesCcy(string dateFrom, string dateTo, string ccy);
    }
}
