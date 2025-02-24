using mhcb.Syd.DataAccess.Models.GUIDE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mhcb.Syd.Models;


namespace mhcb.Syd.Interface
{
    public interface IRatesGbaseUploadCtl
    {
        public List<RatesGbaseUploadCtl> SelectRateCtlByRateType(string SPConnection, DateTime rundate, RateTypes rateType);

        public Boolean Create_GbaseRates_Upload_Ctrl(string SPConnection, string SP, DateTime rundate, string Operator); // RateTypes rateType);

        public bool UpdateRatesGbaseUploadCtlStatus(RatesUploadCtrl ratesUploadCtrl);

	}
}
