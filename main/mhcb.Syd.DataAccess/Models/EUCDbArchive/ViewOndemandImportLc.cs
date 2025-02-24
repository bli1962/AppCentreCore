using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    public partial class ViewOndemandImportLc
    {
        public long RowNo { get; set; }
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
        [Column("START_OPE", TypeName = "datetime")]
        public DateTime? StartOpe { get; set; }
        [Column("START_VALUE", TypeName = "datetime")]
        public DateTime? StartValue { get; set; }
        [Column("EXPIRY", TypeName = "datetime")]
        public DateTime? Expiry { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("ISSUED_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? IssuedAmount { get; set; }
        [Column("BALANCE", TypeName = "decimal(16, 3)")]
        public decimal? Balance { get; set; }
        [Column("REVOLVING_LIMIT", TypeName = "decimal(16, 3)")]
        public decimal? RevolvingLimit { get; set; }
        [Column("REVOLVING_OPTION")]
        [StringLength(1)]
        public string RevolvingOption { get; set; }
        [Column("ATTENTION_CD")]
        [StringLength(1)]
        public string AttentionCd { get; set; }
        [Column("COUNTRY_CD")]
        [StringLength(2)]
        public string CountryCd { get; set; }
        [Column("COMMODITY_CD")]
        [StringLength(3)]
        public string CommodityCd { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("APPLYING_BRANCH")]
        [StringLength(3)]
        public string ApplyingBranch { get; set; }
        [Column("PURPOSE_CD")]
        [StringLength(2)]
        public string PurposeCd { get; set; }
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
        [Column("BAL_ACM_MONTH", TypeName = "decimal(18, 3)")]
        public decimal? BalAcmMonth { get; set; }
        [Column("BAL_ACM_TERM", TypeName = "decimal(18, 3)")]
        public decimal? BalAcmTerm { get; set; }
        [Column("BAL_PEAK_MONTH", TypeName = "decimal(16, 3)")]
        public decimal? BalPeakMonth { get; set; }
        [Column("BAL_BOTTOM_MONTH", TypeName = "decimal(16, 3)")]
        public decimal? BalBottomMonth { get; set; }
        [Column("BAL_PEAK_TERM", TypeName = "decimal(16, 3)")]
        public decimal? BalPeakTerm { get; set; }
        [Column("BAL_BOTTOM_TERM", TypeName = "decimal(16, 3)")]
        public decimal? BalBottomTerm { get; set; }
        [Column("COMM_RATE", TypeName = "decimal(10, 7)")]
        public decimal? CommRate { get; set; }
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
        [Column("REMARKS_EUC")]
        [StringLength(20)]
        public string RemarksEuc { get; set; }
        [Column("CRT_DATE")]
        [StringLength(19)]
        public string CrtDate { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
        [Column("BATCH_NUMBER")]
        public int? BatchNumber { get; set; }
    }
}
