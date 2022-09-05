using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface ISpecialRateService
    {
        Task<IEnumerable<ExchRateView>> GetMizuhoRates();
        Task<int> UpdateStatus(RateAttribute rate);
    }
}
