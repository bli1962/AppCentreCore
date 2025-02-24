using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Models.LOAN;
using mhcb.Syd.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Interface
{
    public interface IBisRate
    {
        IEnumerable<BisRateViewModel> GetBisRates();
        IEnumerable<BisRateViewModel> GetBisRatesByDate(string dataDate);
        IEnumerable<BisRateViewModel> GetBisRatesByDateDistinct(string dataDate);
        BisRateViewModel GetBisRatesByDateCcyDuration(string dataDate, string ccy, int duration, string Unit);
        public string AddBisRate(BisRate bisRate);
        public string DeleteBisRate(string dataDate, string ccy, int duration, string durationUnit);
        public string UpdateBisRate(BisRate bisRate);

        //NDF project - BIS Rate
        public BisRate CheckBisRateImportedTime(string SPConnection, DateTime rundate);
        public bool UploadBis(string SPConnection, DateTime rundate, string user);
    }
}
