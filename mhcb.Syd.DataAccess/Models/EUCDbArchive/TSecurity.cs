using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T_SECURITY", Schema = "EUC")]
    public partial class TSecurity
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
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("TYPE_CD")]
        [StringLength(2)]
        public string TypeCd { get; set; }
        [Column("OPTIONAL_CD")]
        [StringLength(4)]
        public string OptionalCd { get; set; }
        [Column("ISSUE_DATE", TypeName = "datetime")]
        public DateTime? IssueDate { get; set; }
        [Column("FINAL_MATURITY", TypeName = "datetime")]
        public DateTime? FinalMaturity { get; set; }
        [Column("TERM", TypeName = "decimal(4, 0)")]
        public decimal? Term { get; set; }
        [Column("FIXED_FLOAT")]
        [StringLength(1)]
        public string FixedFloat { get; set; }
        [Column("INTEREST_RATE", TypeName = "decimal(9, 6)")]
        public decimal? InterestRate { get; set; }
        [Column("BASE_RATE_CD")]
        [StringLength(2)]
        public string BaseRateCd { get; set; }
        [Column("SPREAD", TypeName = "decimal(8, 6)")]
        public decimal? Spread { get; set; }
        [Column("INT_CALC_CD")]
        [StringLength(1)]
        public string IntCalcCd { get; set; }
        [Column("INT_CYCLE")]
        [StringLength(2)]
        public string IntCycle { get; set; }
        [Column("GRADE_CD")]
        [StringLength(2)]
        public string GradeCd { get; set; }
        [Column("RATING_POINT", TypeName = "decimal(3, 0)")]
        public decimal? RatingPoint { get; set; }
        [Column("RATING_APPL")]
        [StringLength(9)]
        public string RatingAppl { get; set; }
        [Column("CREDIT_RATING_GRT")]
        [StringLength(10)]
        public string CreditRatingGrt { get; set; }
        [Column("CREDIT_RATING_ISSUER")]
        [StringLength(10)]
        public string CreditRatingIssuer { get; set; }
        [Column("PUBLIC_PRIVATE")]
        [StringLength(2)]
        public string PublicPrivate { get; set; }
        [Column("LISTED_MARKET")]
        [StringLength(2)]
        public string ListedMarket { get; set; }
        [Column("ISSUE_PRICE", TypeName = "decimal(9, 6)")]
        public decimal? IssuePrice { get; set; }
        [Column("ISSUE_TTL_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? IssueTtlAmount { get; set; }
        [Column("CUSTODIAN_CD")]
        [StringLength(3)]
        public string CustodianCd { get; set; }
        [Column("TAX_GRACE")]
        [StringLength(1)]
        public string TaxGrace { get; set; }
        [Column("TAX_RATE1", TypeName = "decimal(9, 6)")]
        public decimal? TaxRate1 { get; set; }
        [Column("TAX_RATE2", TypeName = "decimal(9, 6)")]
        public decimal? TaxRate2 { get; set; }
        [Column("BALANCE_FACE", TypeName = "decimal(16, 3)")]
        public decimal? BalanceFace { get; set; }
        [Column("BALANCE_BOOK", TypeName = "decimal(16, 3)")]
        public decimal? BalanceBook { get; set; }
        [Column("DENOMINATED_AMOUNT_1", TypeName = "decimal(16, 3)")]
        public decimal? DenominatedAmount1 { get; set; }
        [Column("NOS_1", TypeName = "decimal(7, 0)")]
        public decimal? Nos1 { get; set; }
        [Column("DENOMINATED_AMOUNT_2", TypeName = "decimal(16, 3)")]
        public decimal? DenominatedAmount2 { get; set; }
        [Column("NOS_2", TypeName = "decimal(7, 0)")]
        public decimal? Nos2 { get; set; }
        [Column("DENOMINATED_AMOUNT_3", TypeName = "decimal(16, 3)")]
        public decimal? DenominatedAmount3 { get; set; }
        [Column("NOS_3", TypeName = "decimal(7, 0)")]
        public decimal? Nos3 { get; set; }
        [Column("DENOMINATED_AMOUNT_4", TypeName = "decimal(16, 3)")]
        public decimal? DenominatedAmount4 { get; set; }
        [Column("NOS_4", TypeName = "decimal(7, 0)")]
        public decimal? Nos4 { get; set; }
        [Column("DENOMINATED_AMOUNT_5", TypeName = "decimal(16, 3)")]
        public decimal? DenominatedAmount5 { get; set; }
        [Column("NOS_5", TypeName = "decimal(7, 0)")]
        public decimal? Nos5 { get; set; }
        [Column("MARKET_PRICE", TypeName = "decimal(9, 6)")]
        public decimal? MarketPrice { get; set; }
        [Column("MARKET_PRICE_STOCK", TypeName = "decimal(16, 3)")]
        public decimal? MarketPriceStock { get; set; }
        [Column("COMMISSION", TypeName = "decimal(16, 3)")]
        public decimal? Commission { get; set; }
        [Column("SUSPENSE_PAY_BAL", TypeName = "decimal(16, 3)")]
        public decimal? SuspensePayBal { get; set; }
        [Column("SUSPENSE_RCV_BAL", TypeName = "decimal(16, 3)")]
        public decimal? SuspenseRcvBal { get; set; }
        [Column("RO_OPE_DATE", TypeName = "datetime")]
        public DateTime? RoOpeDate { get; set; }
        [Column("RO_VALUE", TypeName = "datetime")]
        public DateTime? RoValue { get; set; }
        [Column("RO_DUE", TypeName = "datetime")]
        public DateTime? RoDue { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("BAL_BOOK_ACM_M", TypeName = "decimal(18, 3)")]
        public decimal? BalBookAcmM { get; set; }
        [Column("BAL_BOOK_ACM_T", TypeName = "decimal(18, 3)")]
        public decimal? BalBookAcmT { get; set; }
        [Column("BAL_FACE_ACM_M", TypeName = "decimal(18, 3)")]
        public decimal? BalFaceAcmM { get; set; }
        [Column("BAL_FACE_ACM_T", TypeName = "decimal(18, 3)")]
        public decimal? BalFaceAcmT { get; set; }
        [Column("INTERNAL_RATE_TYPE")]
        [StringLength(1)]
        public string InternalRateType { get; set; }
        [Column("INTERNAL_RATE", TypeName = "decimal(9, 6)")]
        public decimal? InternalRate { get; set; }
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
        [Column("AMORT_ACM_FLG")]
        [StringLength(1)]
        public string AmortAcmFlg { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
