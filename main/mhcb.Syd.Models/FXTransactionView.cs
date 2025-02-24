using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    public class FXTransactionView
    {
        public string REF_NO { get; set; }
        public string CUST_ABBR { get; set; }      
        public string CUST_NAME { get; set; }

        public string ACT_CD { get; set; }
        public string ACT_ABBR { get; set; }

        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime CONTRACT_DATE_OPE { get; set; }

        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime CONTRACT_DATE_VALUE { get; set; }

        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime DELIVARY_DATE { get; set; }

        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime SETTLEMENT_VALUE_DATE { get; set; }

        //public string CONTRACT_DATE_OPE { get; set; }
        //public string CONTRACT_DATE_VALUE { get; set; }
        //public string DELIVARY_DATE { get; set; }
        //public string SETTLEMENT_VALUE_DATE { get; set; }
        public string CONTRACT_CCY_ABBR { get; set; }
        public decimal CONTRACT_CCY_AMT { get; set; }
        public string EQUIV_CCY_ABBR { get; set; }
        public decimal EQUIV_CCY_AMT { get; set; }
        public Nullable<decimal> EXCHANGE_RATE { get; set; }
        public Nullable<decimal> INTERNAL_RATE { get; set; }
        public Nullable<decimal> SPREAD { get; set; }

        public string STATUS { get; set; }
        public string DELETION_STATUS { get; set; }
        public string GIP_STATUS { get; set; }
        public string GIP_DESCRIPTION { get; set; }
        public string TRAN_NO { get; set; }
        public string AUTHORIZE_BY { get; set; }
    }
}
