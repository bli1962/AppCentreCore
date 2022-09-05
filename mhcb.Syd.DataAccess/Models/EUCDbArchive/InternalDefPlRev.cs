using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("INTERNAL_DEF_PL_REV", Schema = "EUC")]
    public partial class InternalDefPlRev
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("RECORD_ID")]
        [StringLength(2)]
        public string RecordId { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
        [Column("HEDGE_TYPE")]
        [StringLength(1)]
        public string HedgeType { get; set; }
        [Column("REF_SUB_NO")]
        [StringLength(2)]
        public string RefSubNo { get; set; }
        [Column("TRANS_CD")]
        [StringLength(1)]
        public string TransCd { get; set; }
        [Column("INT_SUP_CD")]
        [StringLength(1)]
        public string IntSupCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("DUE_DATE", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("INT_CALC_CD")]
        [StringLength(1)]
        public string IntCalcCd { get; set; }
        [Column("DAYS_CODE")]
        [StringLength(1)]
        public string DaysCode { get; set; }
        [Column("HEDGE_BASE_DATE", TypeName = "datetime")]
        public DateTime? HedgeBaseDate { get; set; }
        [Column("HEDGE_RATE", TypeName = "decimal(8, 7)")]
        public decimal? HedgeRate { get; set; }
        [Column("PREV_M_DATE", TypeName = "datetime")]
        public DateTime? PrevMDate { get; set; }
        [Column("BASE_MARKET_VAL", TypeName = "decimal(16, 3)")]
        public decimal? BaseMarketVal { get; set; }
        [Column("BASE_REVAL", TypeName = "decimal(16, 3)")]
        public decimal? BaseReval { get; set; }
        [Column("ADJ_MARKET_VAL", TypeName = "decimal(16, 3)")]
        public decimal? AdjMarketVal { get; set; }
        [Column("ADJ_REVAL", TypeName = "decimal(16, 3)")]
        public decimal? AdjReval { get; set; }
        [Column("INTERNAL_MKT_VAL_RATE", TypeName = "decimal(15, 10)")]
        public decimal? InternalMktValRate { get; set; }
        [Column("INTERNAL_REVAL_RATE", TypeName = "decimal(15, 10)")]
        public decimal? InternalRevalRate { get; set; }
        [Column("ADJ_INTERNAL_M_VAL", TypeName = "decimal(16, 3)")]
        public decimal? AdjInternalMVal { get; set; }
        [Column("ADJ_INTERNAL_REVAL", TypeName = "decimal(16, 3)")]
        public decimal? AdjInternalReval { get; set; }
        [Column("ADJ_INTERNAL_DEF_REVAL", TypeName = "decimal(16, 3)")]
        public decimal? AdjInternalDefReval { get; set; }
        [Column("INTERNAL_PROG_DAY")]
        [StringLength(4)]
        public string InternalProgDay { get; set; }
        [Column("INTERNAL_REVAL_DAY")]
        [StringLength(4)]
        public string InternalRevalDay { get; set; }
        [Column("INTERNAL_PROG_INT", TypeName = "decimal(16, 3)")]
        public decimal? InternalProgInt { get; set; }
        [Column("INTERNAL_MONTH_REVAL", TypeName = "decimal(16, 3)")]
        public decimal? InternalMonthReval { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
