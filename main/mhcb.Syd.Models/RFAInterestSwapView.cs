using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    public class RFRInterestSwapView
    {
        //-- EUC --'
        public DateTime DATA_DATE { get; set; }
        public string REF_NO { get; set; }
        public string CUST_ABBR { get; set; }
        public string CUST_NAME { get; set; }
        public string SWAP_TERM { get; set; }
    
        public DateTime CONTRACT_DATE_OPE { get; set; }
        public DateTime START_VALUE { get; set; }
        public DateTime CONTRACT_DATE_VALUE { get; set; }
        public DateTime MATURITY { get; set; }
        public string CCY_ABBR { get; set; }
        public decimal BALANCE { get; set; }
        public decimal PRINCIPAL_AMOUNT { get; set; }
        public decimal SPREAD { get; set; }
        public decimal INT_RATE { get; set; }

        //-- Murex --'
        public string CORP_NAME { get; set; }
        public string REF_SUB_NO { get; set; }
 
        public decimal INT_ACCRUAL_BUY_REC { get; set; }
        public decimal INT_ACCRUAL_SELL_PAY { get; set; }
        public decimal INT_ACCRUAL { get; set; }

        public string PAY_REV { get; set; }
        public string FIXED_FLOAT { get; set; }

        public decimal IntAccrual_RFR { get; set; }
        public decimal IntRate_RFR { get; set; }
        public DateTime IntAccrualCreatedDate { get; set; }

    }
}
