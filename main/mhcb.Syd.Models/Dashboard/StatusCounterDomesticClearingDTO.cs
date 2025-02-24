using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models.Dashboard
{
	public class StatusCounterDomesticClearingDTO
	{
        public string Description { get; set; }
        public string StatusID { get; set; }
        public string Status { get; set; }
        public int Count { get; set; }

        //public int ValueDatePaymentCount { get; set; }
        //public int ProcessDatePaymentCount { get; set; }
        //public int UpdatedDatePaymentCount { get; set; }
        //public int CreatedWhenPaymentCount { get; set; }

    }
}
