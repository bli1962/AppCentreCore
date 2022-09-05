using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Business.Repository
{
    public class DistributionPreferenceRepository : IDistributionPreference
    {
        private readonly GUIDEDbContext appDbContext;
        public DistributionPreferenceRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<DistributionPreferenceView> GetDistributionPreference()
        {
            var entry = (from b in appDbContext.DistributionPreferences
                         join c in appDbContext.CustomerMasters on b.CustomerAbbr equals c.CustAbbr into c1
                         from custMaster in c1.DefaultIfEmpty()

                         join y in appDbContext.DistributionTypes on b.DistributionType equals y.Id into y1
                         from distType in y1.DefaultIfEmpty()

                         where  (b.DistributionChannel == 1)
                                && (custMaster.StatusCd != "C") 
                         select new DistributionPreferenceView()
                         {
                             CUST_ABBR = b.CustomerAbbr,
                             CUST_NAME = custMaster.CustName,
                             VisableToSystem = distType.VisableToSystem,
                             DistributionType = distType.DistributionType1,
                             Address = (b.Address.Replace("\n", "")).Replace("\r", ""),
                             Status = b.Status
                         })
                        .ToList();
            return entry;
        }

    }
}
