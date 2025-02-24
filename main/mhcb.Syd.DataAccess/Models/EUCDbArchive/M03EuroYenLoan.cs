using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M03_EURO_YEN_LOAN", Schema = "EUC")]
    public partial class M03EuroYenLoan
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("PRIME_CCY")]
        [StringLength(2)]
        public string PrimeCcy { get; set; }
        [Column("PRIME_CCY_ABBR")]
        [StringLength(4)]
        public string PrimeCcyAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("APPLYING_BRANCH")]
        [StringLength(3)]
        public string ApplyingBranch { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("APPL_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? ApplAmount { get; set; }
        [Column("FIXED_FLOAT")]
        [StringLength(1)]
        public string FixedFloat { get; set; }
        [Column("FIXED_RATE", TypeName = "decimal(9, 6)")]
        public decimal? FixedRate { get; set; }
        [Column("DD_NO")]
        [StringLength(3)]
        public string DdNo { get; set; }
        [Column("DD_OPE_DATE", TypeName = "datetime")]
        public DateTime? DdOpeDate { get; set; }
        [Column("DD_VALUE", TypeName = "datetime")]
        public DateTime? DdValue { get; set; }
        [Column("FINAL_DUE", TypeName = "datetime")]
        public DateTime? FinalDue { get; set; }
        [Column("DD_TERM", TypeName = "decimal(4, 0)")]
        public decimal? DdTerm { get; set; }
        [Column("DELAYED_BAL_PRM_CCY", TypeName = "decimal(18, 3)")]
        public decimal? DelayedBalPrmCcy { get; set; }
        [Column("RO_OPE_DATE", TypeName = "datetime")]
        public DateTime? RoOpeDate { get; set; }
        [Column("RO_VALUE", TypeName = "datetime")]
        public DateTime? RoValue { get; set; }
        [Column("RO_DUE", TypeName = "datetime")]
        public DateTime? RoDue { get; set; }
        [Column("DD_CCY_CD")]
        [StringLength(2)]
        public string DdCcyCd { get; set; }
        [Column("DD_CCY_ABBR")]
        [StringLength(4)]
        public string DdCcyAbbr { get; set; }
        [Column("BALANCE_DD_CCY", TypeName = "decimal(18, 3)")]
        public decimal? BalanceDdCcy { get; set; }
        [Column("INT_AMOUNT_RO", TypeName = "decimal(18, 3)")]
        public decimal? IntAmountRo { get; set; }
        [Column("INT_RATE_RO", TypeName = "decimal(9, 6)")]
        public decimal? IntRateRo { get; set; }
        [Column("BASE_RATE_CD_RO")]
        [StringLength(2)]
        public string BaseRateCdRo { get; set; }
        [Column("BASE_RATE_SUB_CD_RO")]
        [StringLength(2)]
        public string BaseRateSubCdRo { get; set; }
        [Column("BASE_RATE_TERM_RO")]
        [StringLength(1)]
        public string BaseRateTermRo { get; set; }
        [Column("SPREAD_RO", TypeName = "decimal(9, 6)")]
        public decimal? SpreadRo { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
