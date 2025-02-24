using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Interface
{
    public interface IFxRate
    {
        IEnumerable<FxRateViewModel> GetFxRates();
        IEnumerable<FxRateViewModel> GetFxRatesByDate(string dataDate);
        IEnumerable<FxRateViewModel> GetFxRatesByDateDistinct(string dataDate);
        FxRateViewModel GetFxRateByDateCcy(string dataDate, string ccy);
        public string AddFxRate(FxRate fxRate);
        public string DeleteFxRate(string dataDate, string ccy);
        public string UpdateFxRate(FxRate fxRate);

        //NDF project - Fx rates
        FxRate CheckDailyFXRateImportedTime(string SPConnection, DateTime rundate);
        public bool UploadFxRate(string SPConnection, DateTime rundate, string user);

    }
}
