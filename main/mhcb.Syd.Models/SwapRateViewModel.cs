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
    public class SwapRateViewModel
    {      
        public DateTime DataDate { get; set; }
        public string Ccy { get; set; }
        public int Duration { get; set; }
        public string DurationUnit { get; set; }

        //[MaxLength(10, ErrorMessage = "Maximum charactor is 10")]
        [Range(0.00001, 99.99999)]
        public decimal BidRate { get; set; }

        //[MaxLength(10, ErrorMessage = "Maximum charactor is 10")]
        [Range(0.0000100, 99.99999)]
        public decimal OfferRate { get; set; }    
        public string ImportedBy { get; set; }
        public string RecStatus { get; set; }
        public DateTime ImportedTime { get; set; }
    }
}
