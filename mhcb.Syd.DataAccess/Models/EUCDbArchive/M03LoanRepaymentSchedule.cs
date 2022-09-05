using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M03_LOAN_REPAYMENT_SCHEDULE", Schema = "EUC")]
    public partial class M03LoanRepaymentSchedule
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("RECORD_ID")]
        [StringLength(2)]
        public string RecordId { get; set; }
        [Column("FILE_MAKE_DATE", TypeName = "datetime")]
        public DateTime? FileMakeDate { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("DD_NO")]
        [StringLength(3)]
        public string DdNo { get; set; }
        [Column("RO_NO")]
        [StringLength(3)]
        public string RoNo { get; set; }
        [Column("DEPT_CD")]
        [StringLength(2)]
        public string DeptCd { get; set; }
        [Column("LOAN_KIND")]
        [StringLength(1)]
        public string LoanKind { get; set; }
        [Column("TERM_REVOLV")]
        [StringLength(1)]
        public string TermRevolv { get; set; }
        [Column("MLT_CCY")]
        [StringLength(1)]
        public string MltCcy { get; set; }
        [Column("REPAY_CD")]
        [StringLength(1)]
        public string RepayCd { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("MERGE_ID1")]
        [StringLength(1)]
        public string MergeId1 { get; set; }
        [Column("MERGE_ID2")]
        [StringLength(1)]
        public string MergeId2 { get; set; }
        [Column("INT_CALC_CD")]
        [StringLength(1)]
        public string IntCalcCd { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("CONTRACT_DATE", TypeName = "datetime")]
        public DateTime? ContractDate { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("AMOUNT_FC", TypeName = "decimal(21, 3)")]
        public decimal? AmountFc { get; set; }
        [Column("AMOUNT_BC", TypeName = "decimal(21, 3)")]
        public decimal? AmountBc { get; set; }
        [Column("EXCHANGE_AMT", TypeName = "decimal(21, 3)")]
        public decimal? ExchangeAmt { get; set; }
        [Column("DD_OPE_DATE", TypeName = "datetime")]
        public DateTime? DdOpeDate { get; set; }
        [Column("DD_VALUE", TypeName = "datetime")]
        public DateTime? DdValue { get; set; }
        [Column("RO_OPE_DATE", TypeName = "datetime")]
        public DateTime? RoOpeDate { get; set; }
        [Column("RO_VALUE", TypeName = "datetime")]
        public DateTime? RoValue { get; set; }
        [Column("RO_DUE", TypeName = "datetime")]
        public DateTime? RoDue { get; set; }
        [Column("FINAL_DUE", TypeName = "datetime")]
        public DateTime? FinalDue { get; set; }
        [Column("DAYS", TypeName = "decimal(4, 0)")]
        public decimal? Days { get; set; }
        [Column("RO_OVER_DAYS", TypeName = "decimal(4, 0)")]
        public decimal? RoOverDays { get; set; }
        [Column("SETTL_OPE_DATE", TypeName = "datetime")]
        public DateTime? SettlOpeDate { get; set; }
        [Column("SETTL_VALUE", TypeName = "datetime")]
        public DateTime? SettlValue { get; set; }
        [Column("DISCOUNT_FLG")]
        [StringLength(1)]
        public string DiscountFlg { get; set; }
        [Column("DAYS_CD")]
        [StringLength(1)]
        public string DaysCd { get; set; }
        [Column("LOAN_FRACTION_CD")]
        [StringLength(1)]
        public string LoanFractionCd { get; set; }
        [Column("CALCULATION_CODE")]
        [StringLength(2)]
        public string CalculationCode { get; set; }
        [Column("FINAL_DAY_CD")]
        [StringLength(1)]
        public string FinalDayCd { get; set; }
        [Column("FIXED_FLOAT")]
        [StringLength(1)]
        public string FixedFloat { get; set; }
        [Column("BASE_RATE_CD")]
        [StringLength(2)]
        public string BaseRateCd { get; set; }
        [Column("BASE_RATE_SUB_CD")]
        [StringLength(2)]
        public string BaseRateSubCd { get; set; }
        [Column("BASE_RATE_TERM")]
        [StringLength(1)]
        public string BaseRateTerm { get; set; }
        [Column("SPREAD", TypeName = "decimal(9, 6)")]
        public decimal? Spread { get; set; }
        [Column("PRIME_FLG")]
        [StringLength(1)]
        public string PrimeFlg { get; set; }
        [Column("RATE_CHANGE_FLG")]
        [StringLength(1)]
        public string RateChangeFlg { get; set; }
        [Column("RESCHEDULED_FLG")]
        [StringLength(1)]
        public string RescheduledFlg { get; set; }
        [Column("OVERDUE_FLG")]
        [StringLength(1)]
        public string OverdueFlg { get; set; }
        [Column("INT_ID")]
        [StringLength(1)]
        public string IntId { get; set; }
        [Column("OVER_INT_ACCR_FLG")]
        [StringLength(1)]
        public string OverIntAccrFlg { get; set; }
        [Column("DELAYED_INT_ACCR_FLG")]
        [StringLength(1)]
        public string DelayedIntAccrFlg { get; set; }
        [Column("NON_INT_ACCR")]
        [StringLength(1)]
        public string NonIntAccr { get; set; }
        [Column("NON_ACCR_START", TypeName = "datetime")]
        public DateTime? NonAccrStart { get; set; }
        [Column("INT_RATE_INTEGER")]
        [StringLength(3)]
        public string IntRateInteger { get; set; }
        [Column("INT_RATE_FRCTION")]
        [StringLength(6)]
        public string IntRateFrction { get; set; }
        [Column("INT_RATE", TypeName = "decimal(9, 6)")]
        public decimal? IntRate { get; set; }
        [Column("INT_AMOUNT", TypeName = "decimal(21, 3)")]
        public decimal? IntAmount { get; set; }
        [Column("INT_REALIZED_TTL_FC", TypeName = "decimal(21, 3)")]
        public decimal? IntRealizedTtlFc { get; set; }
        [Column("INT_REALIZED_TTL_BC", TypeName = "decimal(21, 3)")]
        public decimal? IntRealizedTtlBc { get; set; }
        [Column("NON_ACCR", TypeName = "decimal(21, 3)")]
        public decimal? NonAccr { get; set; }
        [Column("INT_PART_GIVEN_UP", TypeName = "decimal(21, 3)")]
        public decimal? IntPartGivenUp { get; set; }
        [Column("INT_WRITTEN_OFF", TypeName = "decimal(21, 3)")]
        public decimal? IntWrittenOff { get; set; }
        [Column("INT_ACCR", TypeName = "decimal(21, 3)")]
        public decimal? IntAccr { get; set; }
        [Column("TERM_CD")]
        [StringLength(1)]
        public string TermCd { get; set; }
        [Column("PRIME_CCY")]
        [StringLength(2)]
        public string PrimeCcy { get; set; }
        [Column("PRIME_CCY_ABBR")]
        [StringLength(4)]
        public string PrimeCcyAbbr { get; set; }
        [Column("PRIME_AMT", TypeName = "decimal(21, 3)")]
        public decimal? PrimeAmt { get; set; }
        [Column("REPAY_CYCLE", TypeName = "decimal(2, 0)")]
        public decimal? RepayCycle { get; set; }
        [Column("REPAY_COUNT", TypeName = "decimal(3, 0)")]
        public decimal? RepayCount { get; set; }
        [Column("ADD_DATA_ID")]
        [StringLength(2)]
        public string AddDataId { get; set; }
        [Column("REPAYMENT_DATE", TypeName = "datetime")]
        public DateTime? RepaymentDate { get; set; }
        [Column("REPAYMENT1_CCY_CD")]
        [StringLength(2)]
        public string Repayment1CcyCd { get; set; }
        [Column("REPAYMENT1_CCY")]
        [StringLength(4)]
        public string Repayment1Ccy { get; set; }
        [Column("REPAYMENT1_FC", TypeName = "decimal(21, 3)")]
        public decimal? Repayment1Fc { get; set; }
        [Column("REPAYMENT1_HC", TypeName = "decimal(21, 3)")]
        public decimal? Repayment1Hc { get; set; }
        [Column("REPAYMENT1_USD", TypeName = "decimal(21, 3)")]
        public decimal? Repayment1Usd { get; set; }
        [Column("REPAYMENT2_PRIME_CCY")]
        [StringLength(2)]
        public string Repayment2PrimeCcy { get; set; }
        [Column("REPAYMENT2_PRIME_CCY_ABBR")]
        [StringLength(4)]
        public string Repayment2PrimeCcyAbbr { get; set; }
        [Column("REPAYMENT2_FC", TypeName = "decimal(21, 3)")]
        public decimal? Repayment2Fc { get; set; }
        [Column("SIGNING_DATE", TypeName = "datetime")]
        public DateTime? SigningDate { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
