using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface ICustomerMasterService
    {
        Task<IEnumerable<CustomerMaster>> LoadCustomerMasterByCustAbbr(string custAbbr, string branchNo);
    }
}
