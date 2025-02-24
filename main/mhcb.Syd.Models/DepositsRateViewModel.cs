using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    [Serializable]
    public class DepositsRateViewModel
    {
        public DateTime DataDate { get; set; }
        public string Ccy { get; set; }
        public string Period { get; set; }
        public decimal? Bid { get; set; }
        public decimal? Offer { get; set; }

        //[MaxLength(12, ErrorMessage = "Maximum charactor is 12")]
        //[Range(0.00001, 99.99999)]
        public decimal Rate { get; set; }
        public string ImportedBy { get; set; }
        public string RecStatus { get; set; }
        public DateTime ImportedTime { get; set; }

      
    }
}
