//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mhcb.syd.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class FX_SETTLEMENT_INF
    {
        public int ID { get; set; }
        public string REF_NO { get; set; }
        public string BRANCH_NO { get; set; }
        public string CUST_ABBR { get; set; }
        public string REC_SETTL_CODE { get; set; }
        public string REC_CCY_CD { get; set; }
        public string REC_ACT_CD { get; set; }
        public string REC_ACT_NO { get; set; }
        public string REC_CUST_ABBR { get; set; }
        public string REC_METHOD { get; set; }
        public string REC_MESSAGE_TYPE { get; set; }
        public string REC_RMT_FLG { get; set; }
        public string REC_ADVICE_REC_FLG { get; set; }
        public string REC_PRIORTY_FLG { get; set; }
        public string PRIORTY_FLG { get; set; }
        public string PAY_SETTL_CODE { get; set; }
        public string PAY_CCY_CD { get; set; }
        public string PAY_ACT_CD { get; set; }
        public string PAY_ACT_NO { get; set; }
        public string PAY_CUST_ABBR { get; set; }
        public string PAY_METHOD { get; set; }
        public string PAY_MESSAGE_TYPE { get; set; }
        public string PAY_RMT_FLG { get; set; }
        public string PAY_ADVICE_REC_FLG { get; set; }
        public string PAY_PRIORTY_FLG { get; set; }
        public string BANK_FLG { get; set; }
        public string COVER_PO_FLG { get; set; }
        public Nullable<decimal> ADVICE_REC_LIMIT { get; set; }
        public string Rec_Ordering_Customer { get; set; }
        public string Rec_REC_BANK { get; set; }
        public string Rec_Ordering_Bank { get; set; }
        public string Rec_INTERMEDIARY_BANK { get; set; }
        public string Rec_KIHYO_IRAI { get; set; }
        public string Rec_HO_FAVOR_MT202 { get; set; }
        public string Rec_OTHER_METHOD { get; set; }
        public string Rec_OTHER_RMT_FLG { get; set; }
        public string Rec_OTHER_DR { get; set; }
        public string Rec_OTHER_CR { get; set; }
        public string Pay_REC_BANK { get; set; }
        public string Pay_Sender_Corres { get; set; }
        public string Pay_INTERMEDIARY_BANK { get; set; }
        public string Pay_Receiver_Corres { get; set; }
        public string Pay_ACC_Bank { get; set; }
        public string Pay_Beneficiary { get; set; }
        public string Pay_Ordering_Customer { get; set; }
        public string Pay_Payment_Details1 { get; set; }
        public string Pay_Payment_Details2 { get; set; }
        public string Pay_Payment_Details3 { get; set; }
        public string Pay_Payment_Details4 { get; set; }
        public string BankToBankInf { get; set; }
        public string Pay_KIHYO_IRAI { get; set; }
        public string Pay_HO_FAVOR_MT202 { get; set; }
        public string Pay_OTHER_METHOD { get; set; }
        public string Pay_OTHER_RMT_FLG { get; set; }
        public string Pay_OTHER_DR { get; set; }
        public string Pay_OTHER_CR { get; set; }
        public decimal CONTRACT_CCY_AMT { get; set; }
        public decimal EQUIV_CCY_AMT { get; set; }
        public Nullable<int> OPERATION_ID { get; set; }
        public string STATUS_CD { get; set; }
        public string ADD_BY { get; set; }
        public System.DateTime ADD_ON { get; set; }
        public string AUTHORIZE_BY { get; set; }
        public System.DateTime AUTHORIZE_ON { get; set; }
        public string VERIFY_BY { get; set; }
        public Nullable<System.DateTime> VERIFY_ON { get; set; }
        public string MODIFY_BY { get; set; }
        public Nullable<System.DateTime> MODIFY_ON { get; set; }
        public string DELETE_BY { get; set; }
        public Nullable<System.DateTime> DELETE_ON { get; set; }
        public string STATUS { get; set; }
        public string DELETION_STATUS { get; set; }
        public string GIP_STATUS { get; set; }
        public string GIP_DESCRIPTION { get; set; }
        public string TRAN_NO { get; set; }
    
        public virtual FX_TRANSACTION FX_TRANSACTION { get; set; }
    }
}