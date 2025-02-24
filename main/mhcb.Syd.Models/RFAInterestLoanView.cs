using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    public class RFRInterestLoanView
    {
        //-- EUC --'
        public DateTime DATA_DATE { get; set; }
        public DateTime RO_VALUE { get; set; }
        public DateTime MATURITY_DATE { get; set; }
        public DateTime RO_DUE { get; set; }
        public DateTime FINAL_DUE { get; set; }
        public string REF_NO { get; set; }
        public string DD_NO { get; set; }
        public string CUST_ABBR { get; set; }
        public string CUST_NAME { get; set; }
        public string AccountTypeName { get; set; }
        public string DD_CCY { get; set; }
        public decimal DD_AMT { get; set; }
        public decimal DD_EQUIVALENT { get; set; }

        //-- Murex --'
        public string CORP_NAME { get; set; }
        public decimal INT_AMOUNT_RO { get; set; }
        public decimal INT_RATE_RO { get; set; }
        public decimal IntAccrual_RFR { get; set; }
        public decimal IntRate_RFR { get; set; }
        public DateTime IntAccrualCreatedDate { get; set; }
    }
}
