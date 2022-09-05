using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface IDomesticClearingService
    {
        Task<IEnumerable<DomesticClearingPayment>> GetDCPaymentByDate(string dateValue, string dateType);
        Task<int> UpdateStatus(DomesticClearingAttribute status);
    }
}
