using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    public class ExchRateView
    {
        public string CCY_CODE { get; set; }
        public Nullable<decimal> DKB_SPECIAL_RATE_USD { get; set; }
    }
}
