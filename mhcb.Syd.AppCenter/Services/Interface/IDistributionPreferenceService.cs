using mhcb.Syd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.Interface
{
    public interface IDistributionPreferenceService
    {
        Task<IEnumerable<DistributionPreferenceView>> GetDistributionPreference();
    }
}
