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
    public class BisRateViewModel
    {
 
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataDate { get; set; }
        public string Ccy { get; set; }
        public int Duration { get; set; }
        public string DurationUnit { get; set; }

        //[MaxLength(9, ErrorMessage = "Maximum charactor is 9")]
        [Range(0.0000001, 99.999999)]
        public decimal BaseRate { get; set; }

        public string ImportedBy { get; set; }
        public string RecStatus { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ImportedTime { get; set; }
    }
}
