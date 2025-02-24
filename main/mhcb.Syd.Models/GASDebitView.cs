﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models
{
    public class GASDebitView
    {
        public string MIN_NO { get; set; }
        public string TYPE_TX { get; set; }
        public string GROUPNO_TX { get; set; }
        public DateTime VALUEDATE_DT { get; set; }
        public string DREAMS_REF_CODE { get; set; }
        public string REMARKS_TX { get; set; }
        public string BACKVALUE_IND { get; set; }
        public string CCY_TX { get; set; }
        public decimal AMOUNT_AMT { get; set; }
        public string CUSTID_TX { get; set; }
        public string ACC_CD_TX { get; set; }
        public string ACCNUM_TX { get; set; }
        public string DETAILS_TX { get; set; }
        public string ADVISEPRINT_TX { get; set; }
        public string FXCCY_TX { get; set; }
        public Nullable<decimal> INTERRATE_INT { get; set; }
        public Nullable<decimal> EXCHRATE_INT { get; set; }
        public string ENTITY_TX { get; set; }
        public string DIVISION_TX { get; set; }
        public string DESCRIPTION_TX { get; set; }
        public string CREATED_BY { get; set; }

        public DateTime CREATED_DATE { get; set; }
        public string LAST_EDITED_BY { get; set; }
        public DateTime LAST_EDITED_DATE { get; set; }
        public string APPROVED_BY { get; set; }

        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime APPROVED_DATE { get; set; }
        public string DELETED_BY { get; set; }

        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime DELETED_DATE { get; set; }

        public string DELETION_IND { get; set; }
        public string REASON_TX { get; set; }
        public string UPLOADED_BY { get; set; }

        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime UPLOADED_DATE { get; set; }
        public string REVERSED_BY { get; set; }

        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime REVERSED_DATE { get; set; }
        public string TRANSNO_TX { get; set; }
        public Nullable<decimal> STATUS_INT { get; set; }
        public string ACUBU_TX { get; set; }
        public string PUSH_FLAG { get; set; }
        public string PUSH_TXN_FLAG { get; set; }

        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime AVAILABLE_DATE { get; set; }
        public string TRAN_TYPE { get; set; }
        public string BULK_UPLOAD_IND { get; set; }

        [DisplayFormat(DataFormatString = ("{dd/MM/yyyy}"))]
        public DateTime EXPORTED_DT { get; set; }
        public string CHECKNO_TX { get; set; }
        public string FUND_TX { get; set; }
        public Nullable<decimal> SEQ_NO { get; set; }
        public string IBF_TX { get; set; }

    }
}
