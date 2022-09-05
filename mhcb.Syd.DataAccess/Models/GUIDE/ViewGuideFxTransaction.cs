using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    public partial class ViewGuideFxTransaction
    {
        [Required]
        [Column("REF_No")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("Ref_Num")]
        [StringLength(14)]
        public string RefNum { get; set; }
        [Required]
        [StringLength(15)]
        public string DealNo { get; set; }
        [Column("SHORTNAME")]
        [StringLength(35)]
        public string Shortname { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Required]
        [Column("CUST_CODE")]
        [StringLength(6)]
        public string CustCode { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CONTRACT_DATE_OPE", TypeName = "smalldatetime")]
        public DateTime? ContractDateOpe { get; set; }
        [Column("CONTRACT_DATE_VALUE", TypeName = "smalldatetime")]
        public DateTime? ContractDateValue { get; set; }
        [Column("DELIVARY_DATE", TypeName = "smalldatetime")]
        public DateTime? DelivaryDate { get; set; }
        [Column("DELIVARY_THRU", TypeName = "smalldatetime")]
        public DateTime? DelivaryThru { get; set; }
        [Column("CONTRACT_CCY_ABBR")]
        [StringLength(4)]
        public string ContractCcyAbbr { get; set; }
        [Column("CONTRACT_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal? ContractCcyAmt { get; set; }
        [Column("CONTRACT_CCY_BAL", TypeName = "decimal(16, 3)")]
        public decimal? ContractCcyBal { get; set; }
        [Column("CONTRACT_CCY_TTB", TypeName = "decimal(16, 8)")]
        public decimal? ContractCcyTtb { get; set; }
        [Column("EQUIV_CCY_ABBR")]
        [StringLength(4)]
        public string EquivCcyAbbr { get; set; }
        [Column("EQUIV_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal? EquivCcyAmt { get; set; }
        [Column("EQUIV_CCY_BAL", TypeName = "decimal(16, 3)")]
        public decimal? EquivCcyBal { get; set; }
        [Column("EQUIV_CCY_TTB", TypeName = "decimal(16, 8)")]
        public decimal? EquivCcyTtb { get; set; }
        [Column("EXCHANGE_RATE", TypeName = "decimal(16, 8)")]
        public decimal? ExchangeRate { get; set; }
        [Column("DEALER")]
        [StringLength(6)]
        public string Dealer { get; set; }
        [Column("OPTIONSFlag")]
        public int? Optionsflag { get; set; }
        [Column("Scheme_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("ExecutionRefNO")]
        public int? ExecutionRefNo { get; set; }
        [Required]
        [Column("TRANS_STATUS")]
        [StringLength(1)]
        public string TransStatus { get; set; }
        [Required]
        [Column("TRANS_DELETION_STATUS")]
        [StringLength(1)]
        public string TransDeletionStatus { get; set; }
        [Required]
        [Column("TRANS_GIP_STATUS")]
        [StringLength(2)]
        public string TransGipStatus { get; set; }
        [Required]
        [Column("TRANS_GIP_DESCRIPTION")]
        [StringLength(100)]
        public string TransGipDescription { get; set; }
        [Required]
        [Column("TRANS_TRAN_NO")]
        [StringLength(5)]
        public string TransTranNo { get; set; }
        [Required]
        [Column("TRANS_ADD_BY")]
        [StringLength(8)]
        public string TransAddBy { get; set; }
        [Required]
        [Column("TRANS_MODIFY_BY")]
        [StringLength(8)]
        public string TransModifyBy { get; set; }
        [Column("TRANS_DELETE_BY")]
        [StringLength(8)]
        public string TransDeleteBy { get; set; }
        [Required]
        [Column("TRANS_VERIFY_BY")]
        [StringLength(8)]
        public string TransVerifyBy { get; set; }
        [Required]
        [Column("TRANS_AUTHORIZE_BY")]
        [StringLength(8)]
        public string TransAuthorizeBy { get; set; }
        [Column("TRANS_ADD_ON", TypeName = "smalldatetime")]
        public DateTime TransAddOn { get; set; }
        [Column("TRANS_MODIFY_ON", TypeName = "smalldatetime")]
        public DateTime TransModifyOn { get; set; }
        [Column("TRANS_DELETE_ON", TypeName = "smalldatetime")]
        public DateTime TransDeleteOn { get; set; }
        [Column("TRANS_VERIFY_ON", TypeName = "smalldatetime")]
        public DateTime TransVerifyOn { get; set; }
        [Column("TRANS_AUTHORIZE_ON", TypeName = "smalldatetime")]
        public DateTime TransAuthorizeOn { get; set; }
        [Column("BROKER")]
        [StringLength(12)]
        public string Broker { get; set; }
        [Required]
        [Column("PAY_ACT_NO")]
        [StringLength(9)]
        public string PayActNo { get; set; }
        [Required]
        [Column("REC_ACT_NO")]
        [StringLength(9)]
        public string RecActNo { get; set; }
        [Column("SELL_CCY")]
        [StringLength(4)]
        public string SellCcy { get; set; }
        [Column("SELL_AMT", TypeName = "decimal(16, 3)")]
        public decimal? SellAmt { get; set; }
        [Column("BUY_CCY")]
        [StringLength(4)]
        public string BuyCcy { get; set; }
        [Column("BUY_AMT", TypeName = "decimal(16, 3)")]
        public decimal? BuyAmt { get; set; }
        [Column("DELIVERY_CONTRACT_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal? DeliveryContractCcyAmt { get; set; }
        [Column("DELIVERY_EQUIV_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal? DeliveryEquivCcyAmt { get; set; }
        [Column("REC_SETTL_CODE")]
        [StringLength(2)]
        public string RecSettlCode { get; set; }
        [Column("PAY_SETTL_CODE")]
        [StringLength(2)]
        public string PaySettlCode { get; set; }
        [Required]
        [Column("DELIVERY_STATUS")]
        [StringLength(1)]
        public string DeliveryStatus { get; set; }
        [Required]
        [Column("DELIVERY_DELETION_STATUS")]
        [StringLength(1)]
        public string DeliveryDeletionStatus { get; set; }
        [Required]
        [Column("DELIVERY_GIP_STATUS")]
        [StringLength(2)]
        public string DeliveryGipStatus { get; set; }
        [Required]
        [Column("DELIVERY_GIP_DESCRIPTION")]
        [StringLength(100)]
        public string DeliveryGipDescription { get; set; }
        [Required]
        [Column("DELIVERY_TRAN_NO")]
        [StringLength(5)]
        public string DeliveryTranNo { get; set; }
        [Column("DELIVERY_ADD_BY")]
        [StringLength(8)]
        public string DeliveryAddBy { get; set; }
        [Column("DELIVERY_MODIFY_BY")]
        [StringLength(8)]
        public string DeliveryModifyBy { get; set; }
        [Column("DELIVERY_DELETE_BY")]
        [StringLength(8)]
        public string DeliveryDeleteBy { get; set; }
        [Column("DELIVERY_VERIFY_BY")]
        [StringLength(8)]
        public string DeliveryVerifyBy { get; set; }
        [Column("DELIVERY_AUTHORIZE_BY")]
        [StringLength(8)]
        public string DeliveryAuthorizeBy { get; set; }
        [Column("DELIVERY_ADD_ON", TypeName = "smalldatetime")]
        public DateTime DeliveryAddOn { get; set; }
        [Column("DELIVERY_MODIFY_ON", TypeName = "smalldatetime")]
        public DateTime DeliveryModifyOn { get; set; }
        [Column("DELIVERY_DELETE_ON", TypeName = "smalldatetime")]
        public DateTime DeliveryDeleteOn { get; set; }
        [Column("DELIVERY_VERIFY_ON", TypeName = "smalldatetime")]
        public DateTime DeliveryVerifyOn { get; set; }
        [Column("DELIVERY_AUTHORIZE_ON", TypeName = "smalldatetime")]
        public DateTime DeliveryAuthorizeOn { get; set; }
        [Required]
        [StringLength(1)]
        public string Bank { get; set; }
    }
}
