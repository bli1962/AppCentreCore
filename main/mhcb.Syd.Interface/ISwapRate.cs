using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Interface
{
    public interface ISwapRate
    {
        IEnumerable<SwapRateViewModel> GetSwapRates();
        IEnumerable<SwapRateViewModel> GetSwapRatesByDate(string dataDate);
        IEnumerable<SwapRateViewModel> GetSwapRatesByDateDistinct(string dataDate);

        SwapRateViewModel GetSwapRateByDateCcyDuration(string dataDate, string ccy, int duration, string Unit);
        public string AddSwapRate(SwapRate swapRate);
        public string DeleteSwapRate(string dataDate, string ccy, int duration, string Unit);
        public string UpdateSwapRate(SwapRate swapRate);

        //NDF project - Market rate for NPV
        public SwapRate CheckSwapRateImportedTime(string SPConnection, DateTime rundate);
        public bool UploadSwapRate(string SPConnection, DateTime rundate, string user);
    }
}
