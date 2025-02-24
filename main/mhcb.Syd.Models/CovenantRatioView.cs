using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    public class CovenantRatioView
    {
        public int COVENANT_NO { get; set; }
        public string CUST_ABBR { get; set; }
        public string CCIF_NAME { get; set; }
        public string COVENANT_DECS { get; set; }

        public string CONDITION_GROUP_DESC { get; set; }
        public string CONDITION_DESC { get; set; }

        public int RECORD_NO { get; set; }

        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime DATE_RECIEVED_ADJ { get; set; }
        public string RATE_ADJ { get; set; }

        public string RATE { get; set; }

        [DisplayFormat(DataFormatString =("{dd/MM/yyyy}"))]
        public DateTime DATE_RECIEVED { get; set; }
        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime REPORT_DATE { get; set; }
        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime DUE_DATE { get; set; }
        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime COV_START_DATE { get; set; }
        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime COV_END_DATE { get; set; }
    }
}
