﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    public partial class ViewGipFxTransaction
    {
        [Column("REF_NO")]
        [StringLength(12)]
        [Unicode(false)]
        public string RefNo { get; set; }
        [Column("DEALNO")]
        [StringLength(15)]
        [Unicode(false)]
        public string Dealno { get; set; }
        [Column("TRANSCODE")]
        public short? Transcode { get; set; }
        [Column("DEALTYPE")]
        [StringLength(3)]
        [Unicode(false)]
        public string Dealtype { get; set; }
        [Column("SUBTYPE")]
        [StringLength(3)]
        [Unicode(false)]
        public string Subtype { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        [Unicode(false)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        [Unicode(false)]
        public string ActAbbr { get; set; }
        [Column("CUST_CODE")]
        [StringLength(6)]
        [Unicode(false)]
        public string CustCode { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        [Unicode(false)]
        public string CustAbbr { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        [Unicode(false)]
        public string BranchNo { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string DivisionCd { get; set; }
        [Column("IBF_ID")]
        [StringLength(2)]
        [Unicode(false)]
        public string IbfId { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        [Unicode(false)]
        public string SchemeNo { get; set; }
        [Column("AUTHORIZED")]
        [StringLength(1)]
        [Unicode(false)]
        public string Authorized { get; set; }
        [Column("REVISE")]
        [StringLength(1)]
        [Unicode(false)]
        public string Revise { get; set; }
        [Column("COVER_PO_FLG")]
        [StringLength(1)]
        [Unicode(false)]
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
        [Column("CCY_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string CcyCd { get; set; }
        [Column("CONTRACT_CCY_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string ContractCcyCd { get; set; }
        [Column("CONTRACT_CCY_ABBR")]
        [StringLength(4)]
        [Unicode(false)]
        public string ContractCcyAbbr { get; set; }
        [Column("CONTRACT_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal? ContractCcyAmt { get; set; }
        [Column("CONTRACT_CCY_BAL", TypeName = "decimal(16, 3)")]
        public decimal? ContractCcyBal { get; set; }
        [Column("CONTRACT_CCY_TTB", TypeName = "decimal(16, 8)")]
        public decimal? ContractCcyTtb { get; set; }
        [Column("EQUIV_CCY_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string EquivCcyCd { get; set; }
        [Column("EQUIV_CCY_ABBR")]
        [StringLength(4)]
        [Unicode(false)]
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
        [Unicode(false)]
        public string AccountEntry { get; set; }
        [Column("BROKER")]
        [StringLength(12)]
        [Unicode(false)]
        public string Broker { get; set; }
        [Column("REMARKS")]
        [StringLength(30)]
        [Unicode(false)]
        public string Remarks { get; set; }
        [Column("SWAP_REF_NO")]
        [StringLength(12)]
        [Unicode(false)]
        public string SwapRefNo { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        [Unicode(false)]
        public string StatusCd { get; set; }
        [Column("ADDRESSEE")]
        [StringLength(50)]
        [Unicode(false)]
        public string Addressee { get; set; }
        [Column("CODE56")]
        [StringLength(50)]
        [Unicode(false)]
        public string Code56 { get; set; }
        [Column("CODE57")]
        [StringLength(50)]
        [Unicode(false)]
        public string Code57 { get; set; }
        [Column("CODE57A")]
        [StringLength(50)]
        [Unicode(false)]
        public string Code57a { get; set; }
        [Column("CODE58")]
        [StringLength(50)]
        [Unicode(false)]
        public string Code58 { get; set; }
        [Column("SETINSTRUCTION")]
        [StringLength(100)]
        [Unicode(false)]
        public string Setinstruction { get; set; }
        [Column("DEALER")]
        [StringLength(6)]
        [Unicode(false)]
        public string Dealer { get; set; }
        [Column("OPTIONSFLAG")]
        public int? Optionsflag { get; set; }
        [Column("ADD_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string AddBy { get; set; }
        [Column("ADD_ON", TypeName = "smalldatetime")]
        public DateTime? AddOn { get; set; }
        [Column("AUTHORIZE_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string AuthorizeBy { get; set; }
        [Column("AUTHORIZE_ON", TypeName = "smalldatetime")]
        public DateTime? AuthorizeOn { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; }
        [Column("GIP_STATUS")]
        [StringLength(2)]
        [Unicode(false)]
        public string GipStatus { get; set; }
        [Column("GIP_DESCRIPTION")]
        [StringLength(100)]
        [Unicode(false)]
        public string GipDescription { get; set; }
        [Column("TRAN_NO")]
        [StringLength(5)]
        [Unicode(false)]
        public string TranNo { get; set; }
        [Column("EXECUTIONREFNO")]
        public int? Executionrefno { get; set; }
        [Column("SETTLEMENT_VALUE_DATE", TypeName = "smalldatetime")]
        public DateTime? SettlementValueDate { get; set; }
        [Column("REC_SETTL_CODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string RecSettlCode { get; set; }
        [Column("REC_CUST_ABBR")]
        [StringLength(12)]
        [Unicode(false)]
        public string RecCustAbbr { get; set; }
        [Column("REC_ACT_CD")]
        [StringLength(5)]
        [Unicode(false)]
        public string RecActCd { get; set; }
        [Column("REC_ACT_NO")]
        [StringLength(9)]
        [Unicode(false)]
        public string RecActNo { get; set; }
        [Column("REC_ADVICE_REC_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string RecAdviceRecFlg { get; set; }
        [Column("REC_METHOD")]
        [StringLength(2)]
        [Unicode(false)]
        public string RecMethod { get; set; }
        [Column("REC_MESSAGE_TYPE")]
        [StringLength(3)]
        [Unicode(false)]
        public string RecMessageType { get; set; }
        [Column("REC_PRIORTY_FLG")]
        [StringLength(2)]
        [Unicode(false)]
        public string RecPriortyFlg { get; set; }
        [Column("REC_RMT_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string RecRmtFlg { get; set; }
        [Column("REC_RELATED_REF")]
        [StringLength(14)]
        [Unicode(false)]
        public string RecRelatedRef { get; set; }
        [Column("REC_ORDERING_CUSTOMER")]
        [StringLength(12)]
        [Unicode(false)]
        public string RecOrderingCustomer { get; set; }
        [Column("REC_REC_BANK")]
        [StringLength(12)]
        [Unicode(false)]
        public string RecRecBank { get; set; }
        [Column("REC_ORDERING_BANK")]
        [StringLength(12)]
        [Unicode(false)]
        public string RecOrderingBank { get; set; }
        [Column("REC_INTERMEDIARY_BANK")]
        [StringLength(12)]
        [Unicode(false)]
        public string RecIntermediaryBank { get; set; }
        [Column("REC_KIHYO_IRAI")]
        [StringLength(1)]
        [Unicode(false)]
        public string RecKihyoIrai { get; set; }
        [Column("REC_HO_FAVOR_MT202")]
        [StringLength(1)]
        [Unicode(false)]
        public string RecHoFavorMt202 { get; set; }
        [Column("REC_OTHER_METHOD")]
        [StringLength(2)]
        [Unicode(false)]
        public string RecOtherMethod { get; set; }
        [Column("REC_OTHER_RMT_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string RecOtherRmtFlg { get; set; }
        [Column("REC_OTHER_DR")]
        [StringLength(48)]
        [Unicode(false)]
        public string RecOtherDr { get; set; }
        [Column("REC_OTHER_CR")]
        [StringLength(48)]
        [Unicode(false)]
        public string RecOtherCr { get; set; }
        [Column("PAY_SETTL_CODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string PaySettlCode { get; set; }
        [Column("PAY_ACT_CD")]
        [StringLength(5)]
        [Unicode(false)]
        public string PayActCd { get; set; }
        [Column("PAY_CUST_ABBR")]
        [StringLength(12)]
        [Unicode(false)]
        public string PayCustAbbr { get; set; }
        [Column("PAY_ACT_NO")]
        [StringLength(9)]
        [Unicode(false)]
        public string PayActNo { get; set; }
        [Column("PAY_METHOD")]
        [StringLength(2)]
        [Unicode(false)]
        public string PayMethod { get; set; }
        [Column("PAY_MESSAGE_TYPE")]
        [StringLength(3)]
        [Unicode(false)]
        public string PayMessageType { get; set; }
        [Column("PAY_PRIORTY_FLG")]
        [StringLength(2)]
        [Unicode(false)]
        public string PayPriortyFlg { get; set; }
        [Column("PAY_RMT_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string PayRmtFlg { get; set; }
        [Column("PAY_ADVICE_REC_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string PayAdviceRecFlg { get; set; }
        [Column("PAY_REC_BANK")]
        [StringLength(12)]
        [Unicode(false)]
        public string PayRecBank { get; set; }
        [Column("PAY_SENDER_CORRES")]
        [StringLength(12)]
        [Unicode(false)]
        public string PaySenderCorres { get; set; }
        [Column("PAY_INTERMEDIARY_BANK")]
        [StringLength(12)]
        [Unicode(false)]
        public string PayIntermediaryBank { get; set; }
        [Column("PAY_RECEIVER_CORRES")]
        [StringLength(12)]
        [Unicode(false)]
        public string PayReceiverCorres { get; set; }
        [Column("PAY_ACC_BANK")]
        [StringLength(12)]
        [Unicode(false)]
        public string PayAccBank { get; set; }
        [Column("PAY_BENEFICIARY")]
        [StringLength(12)]
        [Unicode(false)]
        public string PayBeneficiary { get; set; }
        [Column("PAY_ORDERING_CUSTOMER")]
        [StringLength(12)]
        [Unicode(false)]
        public string PayOrderingCustomer { get; set; }
        [Column("PAY_PAYMENT_DETAILS1")]
        [StringLength(35)]
        [Unicode(false)]
        public string PayPaymentDetails1 { get; set; }
        [Column("PAY_PAYMENT_DETAILS2")]
        [StringLength(35)]
        [Unicode(false)]
        public string PayPaymentDetails2 { get; set; }
        [Column("PAY_PAYMENT_DETAILS3")]
        [StringLength(35)]
        [Unicode(false)]
        public string PayPaymentDetails3 { get; set; }
        [Column("PAY_PAYMENT_DETAILS4")]
        [StringLength(35)]
        [Unicode(false)]
        public string PayPaymentDetails4 { get; set; }
        [Column("BANKTOBANKINF")]
        [StringLength(1)]
        [Unicode(false)]
        public string Banktobankinf { get; set; }
        [Column("PAY_KIHYO_IRAI")]
        [StringLength(1)]
        [Unicode(false)]
        public string PayKihyoIrai { get; set; }
        [Column("PAY_HO_FAVOR_MT202")]
        [StringLength(1)]
        [Unicode(false)]
        public string PayHoFavorMt202 { get; set; }
        [Column("PAY_OTHER_METHOD")]
        [StringLength(2)]
        [Unicode(false)]
        public string PayOtherMethod { get; set; }
        [Column("PAY_OTHER_RMT_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string PayOtherRmtFlg { get; set; }
        [Column("PAY_OTHER_DR")]
        [StringLength(48)]
        [Unicode(false)]
        public string PayOtherDr { get; set; }
        [Column("PAY_OTHER_CR")]
        [StringLength(48)]
        [Unicode(false)]
        public string PayOtherCr { get; set; }
        [Column("OPERATION_ID")]
        public int? OperationId { get; set; }
        [Column("SETTLE_TRAN_NO")]
        [StringLength(5)]
        [Unicode(false)]
        public string SettleTranNo { get; set; }
        [Column("SETTLEMENT_AUTHORIZE_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string SettlementAuthorizeBy { get; set; }
        [Column("GBASE_CONTRACT_AMT")]
        [StringLength(30)]
        [Unicode(false)]
        public string GbaseContractAmt { get; set; }
        [Column("GBASE_EQUIV_CCY_AMT")]
        [StringLength(30)]
        [Unicode(false)]
        public string GbaseEquivCcyAmt { get; set; }
        [Column("GBASE_DELIVERY_CONTRACT_AMT")]
        [StringLength(30)]
        [Unicode(false)]
        public string GbaseDeliveryContractAmt { get; set; }
        [Column("bank")]
        public int Bank { get; set; }
        [Column("EXECUTION_REF_NO")]
        [StringLength(12)]
        [Unicode(false)]
        public string ExecutionRefNo1 { get; set; }
    }
}
