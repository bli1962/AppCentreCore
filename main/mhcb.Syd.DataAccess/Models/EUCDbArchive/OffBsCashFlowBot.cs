using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("OFF_BS_CASH_FLOW_BOT", Schema = "EUC")]
    public partial class OffBsCashFlowBot
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
        [StringLength(9)]
        public string RefNo { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("SUB_NO")]
        [StringLength(3)]
        public string SubNo { get; set; }
        [Column("RO_NO")]
        [StringLength(3)]
        public string RoNo { get; set; }
        [Column("CON_CD")]
        [StringLength(3)]
        public string ConCd { get; set; }
        [Column("MANAGE_CD")]
        [StringLength(3)]
        public string ManageCd { get; set; }
        [Column("COMMODITY_CD")]
        [StringLength(4)]
        public string CommodityCd { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("PL_ACT_CD")]
        [StringLength(5)]
        public string PlActCd { get; set; }
        [Column("TRANS_DATE", TypeName = "datetime")]
        public DateTime? TransDate { get; set; }
        [Column("FINAL_DUE_DATE", TypeName = "datetime")]
        public DateTime? FinalDueDate { get; set; }
        [Column("CASH_FLOW_CD")]
        [StringLength(1)]
        public string CashFlowCd { get; set; }
        [Column("UPDOWN_CD")]
        [StringLength(1)]
        public string UpdownCd { get; set; }
        [Column("RECEIVE_PAY")]
        [StringLength(1)]
        public string ReceivePay { get; set; }
        [Column("RCV_PRINCIPAL_AMOUNT", TypeName = "decimal(19, 3)")]
        public decimal? RcvPrincipalAmount { get; set; }
        [Column("RCV_INTEREST_AMOUNT", TypeName = "decimal(19, 3)")]
        public decimal? RcvInterestAmount { get; set; }
        [Column("RCV_TOTAL_AMOUNT", TypeName = "decimal(19, 3)")]
        public decimal? RcvTotalAmount { get; set; }
        [Column("PAY_PRINCIPAL_AMOUNT", TypeName = "decimal(19, 3)")]
        public decimal? PayPrincipalAmount { get; set; }
        [Column("PAY_INTEREST_AMOUNT", TypeName = "decimal(19, 3)")]
        public decimal? PayInterestAmount { get; set; }
        [Column("PAY_TOTAL_AMOUNT", TypeName = "decimal(19, 3)")]
        public decimal? PayTotalAmount { get; set; }
        [Column("FIXED_FLOAT")]
        [StringLength(1)]
        public string FixedFloat { get; set; }
        [Column("BASE_RATE_CD")]
        [StringLength(2)]
        public string BaseRateCd { get; set; }
        [Column("INT_CAL_ID")]
        [StringLength(1)]
        public string IntCalId { get; set; }
        [Column("FFC_RATE", TypeName = "decimal(11, 8)")]
        public decimal? FfcRate { get; set; }
        [Column("CASH_ERR_ID")]
        [StringLength(1)]
        public string CashErrId { get; set; }
        [Column("INTERNAL_ID")]
        [StringLength(2)]
        public string InternalId { get; set; }
        [Column("HEDGE_TYPE")]
        [StringLength(1)]
        public string HedgeType { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
