using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FX_SETTLEMENT_INF")]
    [Index(nameof(RefNo), Name = "IX_FX_SETTLEMENT_INF", IsUnique = true)]
    [Index(nameof(AuthorizeOn), nameof(RefNo), nameof(TranNo), nameof(GipStatus), Name = "IX_FX_SETTLEMENT_INF_GIP_SEARCH")]
    [Index(nameof(Status), Name = "IX_FX_SETTLEMENT_INF_STATUS")]
    public partial class FxSettlementInf
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Required]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Required]
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Required]
        [Column("REC_SETTL_CODE")]
        [StringLength(2)]
        public string RecSettlCode { get; set; }
        [Column("REC_CCY_CD")]
        [StringLength(2)]
        public string RecCcyCd { get; set; }
        [Column("REC_ACT_CD")]
        [StringLength(5)]
        public string RecActCd { get; set; }
        [Column("REC_ACT_NO")]
        [StringLength(9)]
        public string RecActNo { get; set; }
        [Column("REC_CUST_ABBR")]
        [StringLength(12)]
        public string RecCustAbbr { get; set; }
        [Column("REC_METHOD")]
        [StringLength(2)]
        public string RecMethod { get; set; }
        [Column("REC_MESSAGE_TYPE")]
        [StringLength(3)]
        public string RecMessageType { get; set; }
        [Column("REC_RMT_FLG")]
        [StringLength(1)]
        public string RecRmtFlg { get; set; }
        [Column("REC_ADVICE_REC_FLG")]
        [StringLength(1)]
        public string RecAdviceRecFlg { get; set; }
        [Column("REC_PRIORTY_FLG")]
        [StringLength(2)]
        public string RecPriortyFlg { get; set; }
        [Column("PRIORTY_FLG")]
        [StringLength(2)]
        public string PriortyFlg { get; set; }
        [Required]
        [Column("PAY_SETTL_CODE")]
        [StringLength(2)]
        public string PaySettlCode { get; set; }
        [Column("PAY_CCY_CD")]
        [StringLength(2)]
        public string PayCcyCd { get; set; }
        [Column("PAY_ACT_CD")]
        [StringLength(5)]
        public string PayActCd { get; set; }
        [Column("PAY_ACT_NO")]
        [StringLength(9)]
        public string PayActNo { get; set; }
        [Column("PAY_CUST_ABBR")]
        [StringLength(12)]
        public string PayCustAbbr { get; set; }
        [Column("PAY_METHOD")]
        [StringLength(2)]
        public string PayMethod { get; set; }
        [Column("PAY_MESSAGE_TYPE")]
        [StringLength(3)]
        public string PayMessageType { get; set; }
        [Column("PAY_RMT_FLG")]
        [StringLength(1)]
        public string PayRmtFlg { get; set; }
        [Column("PAY_ADVICE_REC_FLG")]
        [StringLength(1)]
        public string PayAdviceRecFlg { get; set; }
        [Column("PAY_PRIORTY_FLG")]
        [StringLength(2)]
        public string PayPriortyFlg { get; set; }
        [Column("BANK_FLG")]
        [StringLength(1)]
        public string BankFlg { get; set; }
        [Column("COVER_PO_FLG")]
        [StringLength(1)]
        public string CoverPoFlg { get; set; }
        [Column("ADVICE_REC_LIMIT", TypeName = "decimal(16, 3)")]
        public decimal? AdviceRecLimit { get; set; }
        [Column("Rec_Ordering_Customer")]
        [StringLength(12)]
        public string RecOrderingCustomer { get; set; }
        [Column("Rec_REC_BANK")]
        [StringLength(12)]
        public string RecRecBank { get; set; }
        [Column("Rec_Ordering_Bank")]
        [StringLength(12)]
        public string RecOrderingBank { get; set; }
        [Column("Rec_INTERMEDIARY_BANK")]
        [StringLength(12)]
        public string RecIntermediaryBank { get; set; }
        [Column("Rec_KIHYO_IRAI")]
        [StringLength(1)]
        public string RecKihyoIrai { get; set; }
        [Column("Rec_HO_FAVOR_MT202")]
        [StringLength(1)]
        public string RecHoFavorMt202 { get; set; }
        [Column("Rec_OTHER_METHOD")]
        [StringLength(2)]
        public string RecOtherMethod { get; set; }
        [Column("Rec_OTHER_RMT_FLG")]
        [StringLength(1)]
        public string RecOtherRmtFlg { get; set; }
        [Column("Rec_OTHER_DR")]
        [StringLength(48)]
        public string RecOtherDr { get; set; }
        [Column("Rec_OTHER_CR")]
        [StringLength(48)]
        public string RecOtherCr { get; set; }
        [Column("Pay_REC_BANK")]
        [StringLength(12)]
        public string PayRecBank { get; set; }
        [Column("Pay_Sender_Corres")]
        [StringLength(12)]
        public string PaySenderCorres { get; set; }
        [Column("Pay_INTERMEDIARY_BANK")]
        [StringLength(12)]
        public string PayIntermediaryBank { get; set; }
        [Column("Pay_Receiver_Corres")]
        [StringLength(12)]
        public string PayReceiverCorres { get; set; }
        [Column("Pay_ACC_Bank")]
        [StringLength(12)]
        public string PayAccBank { get; set; }
        [Column("Pay_Beneficiary")]
        [StringLength(12)]
        public string PayBeneficiary { get; set; }
        [Column("Pay_Ordering_Customer")]
        [StringLength(12)]
        public string PayOrderingCustomer { get; set; }
        [Column("Pay_Payment_Details1")]
        [StringLength(35)]
        public string PayPaymentDetails1 { get; set; }
        [Column("Pay_Payment_Details2")]
        [StringLength(35)]
        public string PayPaymentDetails2 { get; set; }
        [Column("Pay_Payment_Details3")]
        [StringLength(35)]
        public string PayPaymentDetails3 { get; set; }
        [Column("Pay_Payment_Details4")]
        [StringLength(35)]
        public string PayPaymentDetails4 { get; set; }
        [StringLength(1)]
        public string BankToBankInf { get; set; }
        [Column("Pay_KIHYO_IRAI")]
        [StringLength(1)]
        public string PayKihyoIrai { get; set; }
        [Column("Pay_HO_FAVOR_MT202")]
        [StringLength(1)]
        public string PayHoFavorMt202 { get; set; }
        [Column("Pay_OTHER_METHOD")]
        [StringLength(2)]
        public string PayOtherMethod { get; set; }
        [Column("Pay_OTHER_RMT_FLG")]
        [StringLength(1)]
        public string PayOtherRmtFlg { get; set; }
        [Column("Pay_OTHER_DR")]
        [StringLength(48)]
        public string PayOtherDr { get; set; }
        [Column("Pay_OTHER_CR")]
        [StringLength(48)]
        public string PayOtherCr { get; set; }
        [Column("CONTRACT_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal ContractCcyAmt { get; set; }
        [Column("EQUIV_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal EquivCcyAmt { get; set; }
        [Column("OPERATION_ID")]
        public int? OperationId { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
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
        [Column("VERIFY_BY")]
        [StringLength(8)]
        public string VerifyBy { get; set; }
        [Column("VERIFY_ON", TypeName = "smalldatetime")]
        public DateTime? VerifyOn { get; set; }
        [Column("MODIFY_BY")]
        [StringLength(8)]
        public string ModifyBy { get; set; }
        [Column("MODIFY_ON", TypeName = "smalldatetime")]
        public DateTime? ModifyOn { get; set; }
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

        [ForeignKey(nameof(RefNo))]
        [InverseProperty(nameof(FxTransaction.FxSettlementInf))]
        public virtual FxTransaction RefNoNavigation { get; set; }
    }
}
