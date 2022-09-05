using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("MONEY_MARKET_TRANS", Schema = "EUC")]
    [Index(nameof(DataDate), Name = "IX_MONEY_MARKET_TRANS")]
    public partial class MoneyMarketTran
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
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
        [Column("BALANCE", TypeName = "decimal(16, 3)")]
        public decimal? Balance { get; set; }
        [Column("START_VALUE", TypeName = "datetime")]
        public DateTime? StartValue { get; set; }
        [Column("START_OPE", TypeName = "datetime")]
        public DateTime? StartOpe { get; set; }
        [Column("DISCOUNT_FLG")]
        [StringLength(1)]
        public string DiscountFlg { get; set; }
        [Column("FINAL_DUE", TypeName = "datetime")]
        public DateTime? FinalDue { get; set; }
        [Column("NOS_OF_DAYS", TypeName = "decimal(4, 0)")]
        public decimal? NosOfDays { get; set; }
        [Column("COL_DEPO_FLG")]
        [StringLength(1)]
        public string ColDepoFlg { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("HO_ORDER", TypeName = "decimal(16, 3)")]
        public decimal? HoOrder { get; set; }
        [Column("BROKER")]
        [StringLength(12)]
        public string Broker { get; set; }
        [Column("FIXED_FLOAT")]
        [StringLength(1)]
        public string FixedFloat { get; set; }
        [Column("BA_TYPE")]
        [StringLength(1)]
        public string BaType { get; set; }
        [Column("BA_AMOUNT_EXPORT", TypeName = "decimal(12, 3)")]
        public decimal? BaAmountExport { get; set; }
        [Column("BA_AMOUNT_IMPORT", TypeName = "decimal(12, 3)")]
        public decimal? BaAmountImport { get; set; }
        [Column("BA_AMOUNT_OTHERS", TypeName = "decimal(12, 3)")]
        public decimal? BaAmountOthers { get; set; }
        [Column("GRADE_CD")]
        [StringLength(2)]
        public string GradeCd { get; set; }
        [Column("RATING_POINT", TypeName = "decimal(3, 0)")]
        public decimal? RatingPoint { get; set; }
        [Column("RATING_APPL")]
        [StringLength(9)]
        public string RatingAppl { get; set; }
        [Column("HIDEAL")]
        [StringLength(16)]
        public string Hideal { get; set; }
        [Column("RO_OPE_DATE", TypeName = "datetime")]
        public DateTime? RoOpeDate { get; set; }
        [Column("RO_VALUE", TypeName = "datetime")]
        public DateTime? RoValue { get; set; }
        [Column("RO_DUE", TypeName = "datetime")]
        public DateTime? RoDue { get; set; }
        [Column("INT_RATE", TypeName = "decimal(9, 6)")]
        public decimal? IntRate { get; set; }
        [Column("INT_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? IntAmount { get; set; }
        [Column("SPREAD", TypeName = "decimal(8, 6)")]
        public decimal? Spread { get; set; }
        [Column("INTERNAL_RATE_TYPE")]
        [StringLength(1)]
        public string InternalRateType { get; set; }
        [Column("INTERNAL_RATE", TypeName = "decimal(9, 6)")]
        public decimal? InternalRate { get; set; }
        [Column("INT_SETTLE_CD")]
        [StringLength(1)]
        public string IntSettleCd { get; set; }
        [Column("RWT_PAY_KIND")]
        [StringLength(1)]
        public string RwtPayKind { get; set; }
        [Column("RWT_CD")]
        [StringLength(2)]
        public string RwtCd { get; set; }
        [Column("RWT_RATE", TypeName = "decimal(10, 7)")]
        public decimal? RwtRate { get; set; }
        [Column("RWT_AMOUNT_PREV", TypeName = "decimal(16, 3)")]
        public decimal? RwtAmountPrev { get; set; }
        [Column("RWT_AMOUNT_CURR", TypeName = "decimal(16, 3)")]
        public decimal? RwtAmountCurr { get; set; }
        [Column("FID_PAY_KIND")]
        [StringLength(1)]
        public string FidPayKind { get; set; }
        [Column("FID_CD")]
        [StringLength(2)]
        public string FidCd { get; set; }
        [Column("FID_RATE", TypeName = "decimal(10, 7)")]
        public decimal? FidRate { get; set; }
        [Column("FID_AMOUNT_PREV", TypeName = "decimal(16, 3)")]
        public decimal? FidAmountPrev { get; set; }
        [Column("FID_AMOUNT_CURR", TypeName = "decimal(16, 3)")]
        public decimal? FidAmountCurr { get; set; }
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
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
