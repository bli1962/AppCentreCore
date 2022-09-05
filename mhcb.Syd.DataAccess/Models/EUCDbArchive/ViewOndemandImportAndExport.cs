using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    public partial class ViewOndemandImportAndExport
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
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("BALANCE", TypeName = "decimal(16, 3)")]
        public decimal? Balance { get; set; }
        [Column("START_VALUE", TypeName = "datetime")]
        public DateTime? StartValue { get; set; }
        [Column("START_OPE", TypeName = "datetime")]
        public DateTime? StartOpe { get; set; }
        [Column("INT_PAYER")]
        [StringLength(1)]
        public string IntPayer { get; set; }
        [Column("DISCOUNT_FLG")]
        [StringLength(1)]
        public string DiscountFlg { get; set; }
        [Column("BASE_RATE_CD")]
        [StringLength(2)]
        public string BaseRateCd { get; set; }
        [Column("SPREAD", TypeName = "decimal(8, 6)")]
        public decimal? Spread { get; set; }
        [Column("MATURITY", TypeName = "datetime")]
        public DateTime? Maturity { get; set; }
        [Column("TERM", TypeName = "decimal(4, 0)")]
        public decimal? Term { get; set; }
        [Column("RISK_CUST_ABBR")]
        [StringLength(12)]
        public string RiskCustAbbr { get; set; }
        [Column("RISK_COUNTRY")]
        [StringLength(2)]
        public string RiskCountry { get; set; }
        [Column("GRADE_CD")]
        [StringLength(2)]
        public string GradeCd { get; set; }
        [Column("RATING_POINT", TypeName = "decimal(3, 0)")]
        public decimal? RatingPoint { get; set; }
        [Column("RATING_APPL")]
        [StringLength(9)]
        public string RatingAppl { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("APPLYING_BRANCH")]
        [StringLength(3)]
        public string ApplyingBranch { get; set; }
        [Column("PURPOSE_CD")]
        [StringLength(2)]
        public string PurposeCd { get; set; }
        [Column("COMMODITY_CD")]
        [StringLength(3)]
        public string CommodityCd { get; set; }
        [Column("LC_NO")]
        [StringLength(20)]
        public string LcNo { get; set; }
        [Column("LC_ISSUING_BANK_ABBR")]
        [StringLength(12)]
        public string LcIssuingBankAbbr { get; set; }
        [Column("LC_ISSUING_BANK_CD")]
        [StringLength(7)]
        public string LcIssuingBankCd { get; set; }
        [Column("DRAFT_NO")]
        [StringLength(15)]
        public string DraftNo { get; set; }
        [Column("IBD_ACC")]
        [StringLength(1)]
        public string IbdAcc { get; set; }
        [Column("TENOR", TypeName = "decimal(3, 0)")]
        public decimal? Tenor { get; set; }
        [Column("COUNTRY_CD")]
        [StringLength(2)]
        public string CountryCd { get; set; }
        [Column("COM_PAYMENT_RATE", TypeName = "decimal(7, 6)")]
        public decimal? ComPaymentRate { get; set; }
        [Column("COM_PAYMENT_CCY")]
        [StringLength(4)]
        public string ComPaymentCcy { get; set; }
        [Column("COM_PAYMENT_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? ComPaymentAmount { get; set; }
        [Column("COM_PAYMENT_PAYER")]
        [StringLength(1)]
        public string ComPaymentPayer { get; set; }
        [Column("COM_HANDLING_RATE", TypeName = "decimal(7, 6)")]
        public decimal? ComHandlingRate { get; set; }
        [Column("COM_HANDLING_CCY")]
        [StringLength(4)]
        public string ComHandlingCcy { get; set; }
        [Column("COM_HANDLING_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? ComHandlingAmount { get; set; }
        [Column("COM_HANDLING_PAYER")]
        [StringLength(1)]
        public string ComHandlingPayer { get; set; }
        [Column("COM_POSTAGE_CCY")]
        [StringLength(4)]
        public string ComPostageCcy { get; set; }
        [Column("COM_POSTAGE_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? ComPostageAmount { get; set; }
        [Column("COM_POSTAGE_PAYER")]
        [StringLength(1)]
        public string ComPostagePayer { get; set; }
        [Column("COM_CABLE_ACT_CD")]
        [StringLength(5)]
        public string ComCableActCd { get; set; }
        [Column("COM_CABLE_ACT_ABBR")]
        [StringLength(15)]
        public string ComCableActAbbr { get; set; }
        [Column("COM_CABLE_CCY")]
        [StringLength(4)]
        public string ComCableCcy { get; set; }
        [Column("COM_CABLE_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? ComCableAmount { get; set; }
        [Column("COM_CABLE_PAYER")]
        [StringLength(1)]
        public string ComCablePayer { get; set; }
        [Column("COM_THEIR_CCY")]
        [StringLength(4)]
        public string ComTheirCcy { get; set; }
        [Column("COM_THEIR_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? ComTheirAmount { get; set; }
        [Column("COM_ACC_RATE", TypeName = "decimal(7, 6)")]
        public decimal? ComAccRate { get; set; }
        [Column("COM_ACC_CCY")]
        [StringLength(4)]
        public string ComAccCcy { get; set; }
        [Column("COM_ACC_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? ComAccAmount { get; set; }
        [Column("COM_ACC_PAYER")]
        [StringLength(1)]
        public string ComAccPayer { get; set; }
        [Column("COM_DISCOUNT_FLG")]
        [StringLength(1)]
        public string ComDiscountFlg { get; set; }
        [Column("ACCEPTED_DATE", TypeName = "datetime")]
        public DateTime? AcceptedDate { get; set; }
        [Column("NEGOTIATING_BANK")]
        [StringLength(12)]
        public string NegotiatingBank { get; set; }
        [Column("INT_RATE", TypeName = "decimal(9, 6)")]
        public decimal? IntRate { get; set; }
        [Column("INT_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? IntAmount { get; set; }
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
