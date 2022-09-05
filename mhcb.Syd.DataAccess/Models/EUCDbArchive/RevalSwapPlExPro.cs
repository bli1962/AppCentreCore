using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("REVAL_SWAP_PL_EX_PRO", Schema = "EUC")]
    public partial class RevalSwapPlExPro
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("SYSTEM_CODE")]
        [StringLength(2)]
        public string SystemCode { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("REF_SUB_NO")]
        [StringLength(3)]
        public string RefSubNo { get; set; }
        [Column("RO_NO")]
        [StringLength(3)]
        public string RoNo { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("PL_ACT_CD")]
        [StringLength(5)]
        public string PlActCd { get; set; }
        [Column("CON_CD")]
        [StringLength(3)]
        public string ConCd { get; set; }
        [Column("MANAGE_CD")]
        [StringLength(3)]
        public string ManageCd { get; set; }
        [Column("COMMODITY_CD")]
        [StringLength(4)]
        public string CommodityCd { get; set; }
        [Column("COTRACT_DATE", TypeName = "datetime")]
        public DateTime? CotractDate { get; set; }
        [Column("DUE_DATE", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("FIXED_FLOAT")]
        [StringLength(1)]
        public string FixedFloat { get; set; }
        [Column("BASE_RATE_CD")]
        [StringLength(2)]
        public string BaseRateCd { get; set; }
        [Column("BASE_RATE_TERM")]
        [StringLength(2)]
        public string BaseRateTerm { get; set; }
        [Column("INT_CALC_CD")]
        [StringLength(1)]
        public string IntCalcCd { get; set; }
        [Column("INT_RATE", TypeName = "decimal(10, 7)")]
        public decimal? IntRate { get; set; }
        [Column("SPREAD", TypeName = "decimal(9, 7)")]
        public decimal? Spread { get; set; }
        [Column("BALANCE_FC", TypeName = "decimal(15, 3)")]
        public decimal? BalanceFc { get; set; }
        [Column("BALANCE_BC", TypeName = "decimal(15, 3)")]
        public decimal? BalanceBc { get; set; }
        [Column("NMNL_AMT_FC", TypeName = "decimal(15, 3)")]
        public decimal? NmnlAmtFc { get; set; }
        [Column("NMNL_AMT_BC", TypeName = "decimal(15, 3)")]
        public decimal? NmnlAmtBc { get; set; }
        [Column("REAL_INT_FC", TypeName = "decimal(15, 3)")]
        public decimal? RealIntFc { get; set; }
        [Column("REAL_INT_BC", TypeName = "decimal(15, 3)")]
        public decimal? RealIntBc { get; set; }
        [Column("ACCR_INT_FC", TypeName = "decimal(17, 3)")]
        public decimal? AccrIntFc { get; set; }
        [Column("ACCR_INT_BC", TypeName = "decimal(17, 3)")]
        public decimal? AccrIntBc { get; set; }
        [Column("NPV_FC", TypeName = "decimal(17, 3)")]
        public decimal? NpvFc { get; set; }
        [Column("NPV_BC", TypeName = "decimal(17, 3)")]
        public decimal? NpvBc { get; set; }
        [Column("NPV_ACCR_FC", TypeName = "decimal(17, 3)")]
        public decimal? NpvAccrFc { get; set; }
        [Column("NPV_ACCR_BC", TypeName = "decimal(17, 3)")]
        public decimal? NpvAccrBc { get; set; }
        [Column("ACCR_PL_FC", TypeName = "decimal(17, 3)")]
        public decimal? AccrPlFc { get; set; }
        [Column("ACCR_PL_BC", TypeName = "decimal(17, 3)")]
        public decimal? AccrPlBc { get; set; }
        [Column("REVALUE_FC", TypeName = "decimal(17, 3)")]
        public decimal? RevalueFc { get; set; }
        [Column("REVALUE_BC", TypeName = "decimal(17, 3)")]
        public decimal? RevalueBc { get; set; }
        [Column("PREV_NPV_FC", TypeName = "decimal(17, 3)")]
        public decimal? PrevNpvFc { get; set; }
        [Column("PREV_NPV_BC", TypeName = "decimal(17, 3)")]
        public decimal? PrevNpvBc { get; set; }
        [Column("PREV_ACCR_FC", TypeName = "decimal(17, 3)")]
        public decimal? PrevAccrFc { get; set; }
        [Column("PREV_ACCR_BC", TypeName = "decimal(17, 3)")]
        public decimal? PrevAccrBc { get; set; }
        [Column("HEDGE_TYPE")]
        [StringLength(1)]
        public string HedgeType { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
