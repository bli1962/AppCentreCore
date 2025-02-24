﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("OPD-37_LoanInterestRateRetrace_Export", Schema = "dbo")]
    public partial class Opd37LoanInterestRateRetraceExport
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("RawID")]
        public int? RawId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("AS_OF_DATE", TypeName = "datetime")]
        public DateTime? AsOfDate { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("DRAW_DOWN_NO")]
        [StringLength(3)]
        public string DrawDownNo { get; set; }
        [Column("ROLL_OVER_NO")]
        [StringLength(3)]
        public string RollOverNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(255)]
        public string CustAbbr { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(10)]
        public string CcyAbbr { get; set; }
        [Column("PL_ACT_CD")]
        [StringLength(10)]
        public string PlActCd { get; set; }
        [Column("SYSTEM_CODE")]
        [StringLength(10)]
        public string SystemCode { get; set; }
        [Column("IBF_CODE")]
        [StringLength(10)]
        public string IbfCode { get; set; }
        [Column("INT_ACCR_INT_PAYABLE", TypeName = "decimal(16, 2)")]
        public decimal? IntAccrIntPayable { get; set; }
        [Column("INT_UNEARNED_INT_PREPAID")]
        [StringLength(20)]
        public string IntUnearnedIntPrepaid { get; set; }
        [Column("DECREASE")]
        [StringLength(10)]
        public string Decrease { get; set; }
        public int? Processed { get; set; }
    }
}
