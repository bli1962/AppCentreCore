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
    public class FxRateViewModel
    {        
        public DateTime DataDate { get; set; }     
        public string Ccy { get; set; }

        //[MaxLength(8, ErrorMessage = "Maximum charactor is 8")]
        [Range(0.00001, 99.99999)]
        public decimal Bid { get; set; }

        //[MaxLength(8, ErrorMessage = "Maximum charactor is 8")]
        [Range(0.00001, 99.99999)]
        public decimal Offer { get; set; }

        //[MaxLength(8, ErrorMessage = "Maximum charactor is 8")]
        [Range(0.00001, 99.99999)]
        public decimal Rate { get; set; }     
        public string ImportedBy { get; set; }      
        public string RecStatus { get; set; }     
        public DateTime ImportedTime { get; set; }
    }
}
