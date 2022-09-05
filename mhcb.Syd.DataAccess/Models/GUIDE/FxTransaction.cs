using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FX_TRANSACTION")]
    [Index(nameof(ExecutionRefNo), Name = "IX_FX_TRANSACTION_ExecutionRefNo")]
    [Index(nameof(RefNo), nameof(BranchNo), Name = "IX_FX_TRANSACTION_Ref_Branch_No")]
    [Index(nameof(Status), Name = "IX_FX_TRANSACTION_STATUS")]
    [Index(nameof(SchemeNo), Name = "IX_FX_TRANSACTION_Scheme_No")]
    [Index(nameof(SwapRefNo), Name = "IX_FX_TRANSACTION_Swap_Ref_No")]
    public partial class FxTransaction
    {
        [Key]
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Required]
        [StringLength(15)]
        public string DealNo { get; set; }
        public short TransCode { get; set; }
        [Required]
        [Column("DEALTYPE")]
        [StringLength(3)]
        public string Dealtype { get; set; }
        [Required]
        [Column("SUBTYPE")]
        [StringLength(3)]
        public string Subtype { get; set; }
        [Required]
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Required]
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Required]
        [Column("CUST_CODE")]
        [StringLength(6)]
        public string CustCode { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
        [Column("IBF_ID")]
        [StringLength(2)]
        public string IbfId { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("AUTHORIZED")]
        [StringLength(1)]
        public string Authorized { get; set; }
        [Column("REVISE")]
        [StringLength(1)]
        public string Revise { get; set; }
        [Column("COVER_PO_FLG")]
        [StringLength(1)]
        public string CoverPoFlg { get; set; }
        [Column("CONTRACT_DATE_OPE", TypeName = "smalldatetime")]
        public DateTime? ContractDateOpe { get; set; }
        [Column("CONTRACT_DATE_VALUE", TypeName = "smalldatetime")]
        public DateTime? ContractDateValue { get; set; }
        [Column("DELIVARY_DATE", TypeName = "smalldatetime")]
        public DateTime? DelivaryDate { get; set; }
        [Column("DELIVARY_THRU", TypeName = "smalldatetime")]
        public DateTime? DelivaryThru { get; set; }
        [Column("ACCRUAL_FROM", TypeName = "smalldatetime")]
        public DateTime? AccrualFrom { get; set; }
        [Column("ACCRUAL_TO", TypeName = "smalldatetime")]
        public DateTime? AccrualTo { get; set; }
        [Column("SETTLEMENT_VALUE_DATE", TypeName = "smalldatetime")]
        public DateTime? SettlementValueDate { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CONTRACT_CCY_CD")]
        [StringLength(2)]
        public string ContractCcyCd { get; set; }
        [Column("CONTRACT_CCY_ABBR")]
        [StringLength(4)]
        public string ContractCcyAbbr { get; set; }
        [Column("CONTRACT_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal? ContractCcyAmt { get; set; }
        [Column("CONTRACT_CCY_BAL", TypeName = "decimal(16, 3)")]
        public decimal? ContractCcyBal { get; set; }
        [Column("CONTRACT_CCY_TTB", TypeName = "decimal(16, 8)")]
        public decimal? ContractCcyTtb { get; set; }
        [Column("EQUIV_CCY_CD")]
        [StringLength(2)]
        public string EquivCcyCd { get; set; }
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
        [Column("INTERNAL_RATE", TypeName = "decimal(16, 8)")]
        public decimal? InternalRate { get; set; }
        [Column("SPREAD", TypeName = "decimal(9, 6)")]
        public decimal? Spread { get; set; }
        [Column("ACCOUNT_ENTRY")]
        [StringLength(1)]
        public string AccountEntry { get; set; }
        [Column("BROKER")]
        [StringLength(12)]
        public string Broker { get; set; }
        [Column("REMARKS")]
        [StringLength(50)]
        public string Remarks { get; set; }
        [Column("REMARKS_TRD")]
        [StringLength(100)]
        public string RemarksTrd { get; set; }
        [Column("SWAP_REF_NO")]
        [StringLength(12)]
        public string SwapRefNo { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("ADDRESSEE")]
        [StringLength(50)]
        public string Addressee { get; set; }
        [Column("CODE56")]
        [StringLength(50)]
        public string Code56 { get; set; }
        [Column("CODE57")]
        [StringLength(50)]
        public string Code57 { get; set; }
        [Column("CODE57A")]
        [StringLength(50)]
        public string Code57a { get; set; }
        [Column("CODE58")]
        [StringLength(50)]
        public string Code58 { get; set; }
        [StringLength(100)]
        public string SetInstruction { get; set; }
        [Column("DEALER")]
        [StringLength(6)]
        public string Dealer { get; set; }
        public int? OptionsFlag { get; set; }
        public int? ExecutionRefNo { get; set; }
        [Required]
        [Column("ADD_BY")]
        [StringLength(8)]
        public string AddBy { get; set; }
        [Column("ADD_ON", TypeName = "smalldatetime")]
        public DateTime AddOn { get; set; }
        [Required]
        [Column("AUTHORIZE_BY")]
        [StringLength(8)]
        public string AuthorizeBy { get; set; }
        [Column("AUTHORIZE_ON", TypeName = "smalldatetime")]
        public DateTime AuthorizeOn { get; set; }
        [Required]
        [Column("VERIFY_BY")]
        [StringLength(8)]
        public string VerifyBy { get; set; }
        [Column("VERIFY_ON", TypeName = "smalldatetime")]
        public DateTime VerifyOn { get; set; }
        [Required]
        [Column("MODIFY_BY")]
        [StringLength(8)]
        public string ModifyBy { get; set; }
        [Column("MODIFY_ON", TypeName = "smalldatetime")]
        public DateTime ModifyOn { get; set; }
        [Column("DELETE_BY")]
        [StringLength(8)]
        public string DeleteBy { get; set; }
        [Column("DELETE_ON", TypeName = "smalldatetime")]
        public DateTime? DeleteOn { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Required]
        [Column("DELETION_STATUS")]
        [StringLength(1)]
        public string DeletionStatus { get; set; }
        [Column("GIP_STATUS")]
        [StringLength(2)]
        public string GipStatus { get; set; }
        [Column("GIP_DESCRIPTION")]
        [StringLength(100)]
        public string GipDescription { get; set; }
        [Column("TRAN_NO")]
        [StringLength(5)]
        public string TranNo { get; set; }

        [ForeignKey("BranchNo,CustAbbr")]
        [InverseProperty("FxTransactions")]
        public virtual CustomerMaster CustomerMaster { get; set; }
        [InverseProperty("RefNoNavigation")]
        public virtual FxSettlementInf FxSettlementInf { get; set; }
    }
}
