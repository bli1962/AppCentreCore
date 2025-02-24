using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Interface
{
    public interface IRevaluationRate
    {
        IEnumerable<RevaluationRateViewModel> GetRevaluationRates();
        IEnumerable<RevaluationRateViewModel> GetRevaluationRatesByDate(string dataDate);
        IEnumerable<RevaluationRateViewModel> GetRevaluationRatesByDateDistinct(string dataDate);
        RevaluationRateViewModel GetRevaluationRateByDateCcyDay(string dataDate, string ccy, int day);
        public string AddRevaluationRate(RevaluationRate revaluationRate);
        public string DeleteRevaluationRate(string dataDate, string ccy, int day);
        public string UpdateRevaluationRate(RevaluationRate revaluationRate);

        //NDF project - Revaluation Rate
        public RevaluationRate CheckRevaluationRateImportedTime(string SPConnection, DateTime rundate);
        public bool UploadRevaluationRate(string SPConnection, DateTime rundate, string user);
    }
}
