using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Interface
{
    public interface IDepositsRate
    {
        IEnumerable<DepositsRateViewModel> GetDepositsRates();
        IEnumerable<DepositsRateViewModel> GetDepositsRatesByDate(string dataDate);
        IEnumerable<DepositsRateViewModel> GetDepositsRatesByDateDistinct(string dataDate);
        DepositsRateViewModel GetDepositsRateByDateCcyPeriod(string dataDate, string ccy, string period);
        public string AddDepositsRate(DepositsRate depositesRate);
        public string DeleteDepositsRate(string dataDate, string ccy, string period);
        public string UpdateDepositsRate(DepositsRate depositesRate);

        //NDF project - Deposit rates for funding
        public DepositsRate CheckDepostRateImportedTime(string SPConnection, DateTime rundate);
        public bool UploadDepositRate(string SPConnection, DateTime rundate, string user);
    }
}
