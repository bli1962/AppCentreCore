using mhcb.Syd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Interface
{
    public interface IDistributionPreference
    {
        public IEnumerable<DistributionPreferenceView> GetDistributionPreference();
    }
}
