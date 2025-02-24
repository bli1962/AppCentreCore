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
    public class RevaluationRateViewModel
    {
        public DateTime DataDate { get; set; }       
        public string Ccy { get; set; }  
        public int Days { get; set; }

        //[MaxLength(9, ErrorMessage = "Maximum charactor is 9")]
        [Range(-99.99999, 99.99999)]
        public decimal Rate { get; set; }  
        
        public string ImportedBy { get; set; }      
        public string RecStatus { get; set; }      
        public string GbaseMsg { get; set; }     
        public DateTime ImportedTime { get; set; }
    }
}
