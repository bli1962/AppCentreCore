using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T05_GUARANTEE", Schema = "EUC")]
    public partial class T05Guarantee
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
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("GRT_TYPE")]
        [StringLength(2)]
        public string GrtType { get; set; }
        [Column("ORGANIZATION")]
        [StringLength(1)]
        public string Organization { get; set; }
        [Column("APPLYING_BRANCH")]
        [StringLength(3)]
        public string ApplyingBranch { get; set; }
        [Column("NEXT_APPL_DATE", TypeName = "datetime")]
        public DateTime? NextApplDate { get; set; }
        [Column("COMMIT_AVAIL")]
        [StringLength(1)]
        public string CommitAvail { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("APPL_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? ApplAmount { get; set; }
        [Column("USED_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? UsedAmount { get; set; }
        [Column("DD_BAL_TTL", TypeName = "decimal(18, 3)")]
        public decimal? DdBalTtl { get; set; }
        [Column("TERM_REVOLVING")]
        [StringLength(1)]
        public string TermRevolving { get; set; }
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
        [Column("RISK_CUST_ABBR")]
        [StringLength(12)]
        public string RiskCustAbbr { get; set; }
        [Column("EXPIRY", TypeName = "datetime")]
        public DateTime? Expiry { get; set; }
        [Column("SIGHT")]
        [StringLength(2)]
        public string Sight { get; set; }
        [Column("MULTI_CCY")]
        [StringLength(1)]
        public string MultiCcy { get; set; }
        [Column("FEE_CALC_CD_1_CND")]
        [StringLength(1)]
        public string FeeCalcCd1Cnd { get; set; }
        [Column("FEE_CALC_CD_2_CND")]
        [StringLength(1)]
        public string FeeCalcCd2Cnd { get; set; }
        [Column("FEE_CALC_CD_3_CND")]
        [StringLength(2)]
        public string FeeCalcCd3Cnd { get; set; }
        [Column("FEE_CALC_CD_4_CND")]
        [StringLength(1)]
        public string FeeCalcCd4Cnd { get; set; }
        [Column("FEE_RCV_ID_1_CND")]
        [StringLength(1)]
        public string FeeRcvId1Cnd { get; set; }
        [Column("FEE_RCV_ID_2_CND")]
        [StringLength(1)]
        public string FeeRcvId2Cnd { get; set; }
        [Column("FEE_RATE_CND", TypeName = "decimal(9, 6)")]
        public decimal? FeeRateCnd { get; set; }
        [Column("SUB_PARTOUT_FLG")]
        [StringLength(1)]
        public string SubPartoutFlg { get; set; }
        [Column("SUB_PARTOUT_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? SubPartoutAmount { get; set; }
        [Column("SPO_UNDISCLOSED")]
        [StringLength(1)]
        public string SpoUndisclosed { get; set; }
        [Column("DKB_STATUS")]
        [StringLength(4)]
        public string DkbStatus { get; set; }
        [Column("AGENT_FLG")]
        [StringLength(1)]
        public string AgentFlg { get; set; }
        [Column("SUB_PARTIN_BANK")]
        [StringLength(12)]
        public string SubPartinBank { get; set; }
        [Column("DD_NO")]
        [StringLength(3)]
        public string DdNo { get; set; }
        [Column("DD_OPE_DATE", TypeName = "datetime")]
        public DateTime? DdOpeDate { get; set; }
        [Column("DD_VALUE", TypeName = "datetime")]
        public DateTime? DdValue { get; set; }
        [Column("DD_DUE", TypeName = "datetime")]
        public DateTime? DdDue { get; set; }
        [Column("DD_TERM", TypeName = "decimal(4, 0)")]
        public decimal? DdTerm { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("SCHEME_AUTHORIZED")]
        [StringLength(1)]
        public string SchemeAuthorized { get; set; }
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
        [Column("FEE_AMOUNT_RO", TypeName = "decimal(18, 3)")]
        public decimal? FeeAmountRo { get; set; }
        [Column("FEE_RATE_RO", TypeName = "decimal(9, 6)")]
        public decimal? FeeRateRo { get; set; }
        [Column("FEE_CALC_CD_1_RO")]
        [StringLength(1)]
        public string FeeCalcCd1Ro { get; set; }
        [Column("FEE_CALC_CD_2_RO")]
        [StringLength(1)]
        public string FeeCalcCd2Ro { get; set; }
        [Column("FEE_CALC_CD_3_RO")]
        [StringLength(2)]
        public string FeeCalcCd3Ro { get; set; }
        [Column("FEE_CALC_CD_4_RO")]
        [StringLength(1)]
        public string FeeCalcCd4Ro { get; set; }
        [Column("FEE_RCV_ID_1_RO")]
        [StringLength(1)]
        public string FeeRcvId1Ro { get; set; }
        [Column("FEE_RCV_ID_2_RO")]
        [StringLength(1)]
        public string FeeRcvId2Ro { get; set; }
        [Column("FEE_RCV_ID_3_RO")]
        [StringLength(1)]
        public string FeeRcvId3Ro { get; set; }
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
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
