using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    [Serializable]
    public class RatesControlPostDTO
    {
        public DateTime RunDate { get; set; }
        public string Operator { get; set; }
        public RateTypes RateType { get; set; }
       
    }
}
