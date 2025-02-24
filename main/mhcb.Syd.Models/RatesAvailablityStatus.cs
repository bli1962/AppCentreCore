using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    [Serializable]
    public class RatesAvailablityStatus
    {
        public DateTime DataDate { get; set; }
        public int FXRateCount { get; set; }
        public int RevaluationRateCount { get; set; }
        public int SwapRateCount { get; set; }
        public int DepositRateCount { get; set; }
        public int BitRateCount { get; set; }
    }
}
