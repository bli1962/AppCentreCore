using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T07_LOAN", Schema = "EUC")]
    public partial class T07Loan
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
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("PRIME_CCY")]
        [StringLength(2)]
        public string PrimeCcy { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("SYND_DIRECT")]
        [StringLength(1)]
        public string SyndDirect { get; set; }
        [Column("APPLYING_BRANCH")]
        [StringLength(3)]
        public string ApplyingBranch { get; set; }
        [Column("NEXT_APPL_DUE", TypeName = "datetime")]
        public DateTime? NextApplDue { get; set; }
        [Column("COMMIT_AVAIL")]
        [StringLength(1)]
        public string CommitAvail { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("PRIME_CCY_ABBR")]
        [StringLength(4)]
        public string PrimeCcyAbbr { get; set; }
        [Column("APPL_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? ApplAmount { get; set; }
        [Column("USED_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? UsedAmount { get; set; }
        [Column("DD_BAL_TTL", TypeName = "decimal(18, 3)")]
        public decimal? DdBalTtl { get; set; }
        [Column("TERM_REVOLV")]
        [StringLength(1)]
        public string TermRevolv { get; set; }
        [Column("PURPOSE_CD")]
        [StringLength(2)]
        public string PurposeCd { get; set; }
        [Column("SIGNING_DATE", TypeName = "datetime")]
        public DateTime? SigningDate { get; set; }
        [Column("GRADE_CD")]
        [StringLength(2)]
        public string GradeCd { get; set; }
        [Column("RATING_POINT", TypeName = "decimal(3, 0)")]
        public decimal? RatingPoint { get; set; }
        [Column("RATING_APPL")]
        [StringLength(9)]
        public string RatingAppl { get; set; }
        [Column("RISK_COUNTRY")]
        [StringLength(2)]
        public string RiskCountry { get; set; }
        [Column("ACTUAL_RISK_ABBR")]
        [StringLength(12)]
        public string ActualRiskAbbr { get; set; }
        [Column("FINAL_MATURITY", TypeName = "datetime")]
        public DateTime? FinalMaturity { get; set; }
        [Column("SIGHT")]
        [StringLength(2)]
        public string Sight { get; set; }
        [Column("MULTI_CCY")]
        [StringLength(1)]
        public string MultiCcy { get; set; }
        [Column("INT_CALC_CD_1_CND")]
        [StringLength(1)]
        public string IntCalcCd1Cnd { get; set; }
        [Column("INT_CALC_CD_2_CND")]
        [StringLength(1)]
        public string IntCalcCd2Cnd { get; set; }
        [Column("INT_CALC_CD_3_CND")]
        [StringLength(2)]
        public string IntCalcCd3Cnd { get; set; }
        [Column("INT_CALC_CD_4_CND")]
        [StringLength(1)]
        public string IntCalcCd4Cnd { get; set; }
        [Column("INT_RCV_ID_1_CND")]
        [StringLength(1)]
        public string IntRcvId1Cnd { get; set; }
        [Column("INT_RCV_ID_2_CND")]
        [StringLength(1)]
        public string IntRcvId2Cnd { get; set; }
        [Column("INT_RCV_ID_3_CND")]
        [StringLength(1)]
        public string IntRcvId3Cnd { get; set; }
        [Column("FIXED_FLOAT")]
        [StringLength(1)]
        public string FixedFloat { get; set; }
        [Column("FIXED_RATE", TypeName = "decimal(9, 6)")]
        public decimal? FixedRate { get; set; }
        [Column("SUB_PARTOUT_FLG")]
        [StringLength(1)]
        public string SubPartoutFlg { get; set; }
        [Column("SUB_PARTOUT_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? SubPartoutAmount { get; set; }
        [Column("SPO_UNDISCLOSED")]
        [StringLength(1)]
        public string SpoUndisclosed { get; set; }
        [Column("BASE_RATE_CD_CND")]
        [StringLength(2)]
        public string BaseRateCdCnd { get; set; }
        [Column("BASE_RATE_SUB_CD_CND")]
        [StringLength(2)]
        public string BaseRateSubCdCnd { get; set; }
        [Column("BASE_RATE_TERM_CND")]
        [StringLength(1)]
        public string BaseRateTermCnd { get; set; }
        [Column("SPREAD_CND", TypeName = "decimal(9, 6)")]
        public decimal? SpreadCnd { get; set; }
        [Column("DKB_STATUS")]
        [StringLength(4)]
        public string DkbStatus { get; set; }
        [Column("AGENT_FLG")]
        [StringLength(1)]
        public string AgentFlg { get; set; }
        [Column("SUBPARTIN_BANK")]
        [StringLength(12)]
        public string SubpartinBank { get; set; }
        [Column("WHOLE_SCHEDULE")]
        [StringLength(1)]
        public string WholeSchedule { get; set; }
        [Column("TAX_SPARING")]
        [StringLength(1)]
        public string TaxSparing { get; set; }
        [Column("TAX_SPARING_RATE", TypeName = "decimal(10, 6)")]
        public decimal? TaxSparingRate { get; set; }
        [Column("TAX_CD")]
        [StringLength(1)]
        public string TaxCd { get; set; }
        [Column("TAX_RATE", TypeName = "decimal(10, 6)")]
        public decimal? TaxRate { get; set; }
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
        [Column("RESCHEDULED_FLG")]
        [StringLength(1)]
        public string RescheduledFlg { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("SCHEME_AUTHORIZED")]
        [StringLength(1)]
        public string SchemeAuthorized { get; set; }
        [Column("REPAYMENT_START", TypeName = "datetime")]
        public DateTime? RepaymentStart { get; set; }
        [Column("REPAYMENT_INTERVAL")]
        [StringLength(2)]
        public string RepaymentInterval { get; set; }
        [Column("REPAYMENT_NOS", TypeName = "decimal(3, 0)")]
        public decimal? RepaymentNos { get; set; }
        [Column("REPAYMENT_DATE")]
        [StringLength(2)]
        public string RepaymentDate { get; set; }
        [Column("RO_NO")]
        [StringLength(3)]
        public string RoNo { get; set; }
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
        [Column("BALANCE_PRM_CCY", TypeName = "decimal(18, 3)")]
        public decimal? BalancePrmCcy { get; set; }
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
        [Column("INTERNAL_RATE_TYPE")]
        [StringLength(1)]
        public string InternalRateType { get; set; }
        [Column("INTERNAL_RATE", TypeName = "decimal(9, 6)")]
        public decimal? InternalRate { get; set; }
        [Column("INT_CALC_CD_1_RO")]
        [StringLength(1)]
        public string IntCalcCd1Ro { get; set; }
        [Column("INT_CALC_CD_2_RO")]
        [StringLength(1)]
        public string IntCalcCd2Ro { get; set; }
        [Column("INT_CALC_CD_3_RO")]
        [StringLength(2)]
        public string IntCalcCd3Ro { get; set; }
        [Column("INT_CALC_CD_4_RO")]
        [StringLength(1)]
        public string IntCalcCd4Ro { get; set; }
        [Column("INT_RCV_ID_1_RO")]
        [StringLength(1)]
        public string IntRcvId1Ro { get; set; }
        [Column("INT_RCV_ID_2_RO")]
        [StringLength(1)]
        public string IntRcvId2Ro { get; set; }
        [Column("INT_RCV_ID_3_RO")]
        [StringLength(1)]
        public string IntRcvId3Ro { get; set; }
        [Column("MONTH_ACM", TypeName = "decimal(20, 3)")]
        public decimal? MonthAcm { get; set; }
        [Column("MONTH_ACM_VAL", TypeName = "decimal(20, 3)")]
        public decimal? MonthAcmVal { get; set; }
        [Column("TERM_ACM", TypeName = "decimal(20, 3)")]
        public decimal? TermAcm { get; set; }
        [Column("TERM_ACM_VAL", TypeName = "decimal(20, 3)")]
        public decimal? TermAcmVal { get; set; }
        [Column("MONTH_DAYS", TypeName = "decimal(3, 0)")]
        public decimal? MonthDays { get; set; }
        [Column("TERM_DAYS", TypeName = "decimal(3, 0)")]
        public decimal? TermDays { get; set; }
        [Column("SECURITY_CD")]
        [StringLength(1)]
        public string SecurityCd { get; set; }
        [Column("SECURITY_INFO")]
        [StringLength(12)]
        public string SecurityInfo { get; set; }
        [Column("SOLD_DATE")]
        [StringLength(8)]
        public string SoldDate { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
