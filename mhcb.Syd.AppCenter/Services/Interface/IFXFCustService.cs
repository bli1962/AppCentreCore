using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface IFXFCustService
    {
        Task<IEnumerable<FXFCustomerView>> GetMMCustByAbbr(string abbreviation);
        Task<int> UpdateStatus(FXFCustAttribute custAttr);
    }
}
