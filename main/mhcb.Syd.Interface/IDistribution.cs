using mhcb.Syd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Interface
{
    public interface IDistribution
    {
        public IEnumerable<DistributionPreferenceView> GetDistributionPreference(string appName);

        public IEnumerable<DistributionPasswordView> GetDistributionPassword(string customerAbbr, string branch, string sharedkey);

        public IEnumerable<DistributionView> GetElcsConfirmation(string dateAdded);

        string UpdateStatus(InputEDistribution status);
    }
}
