using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("OUTGOING_REMITTANCE_BAK", Schema = "EUC")]
    public partial class OutgoingRemittanceBak
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("DD_NO")]
        [StringLength(2)]
        public string DdNo { get; set; }
        [Column("RO_NO")]
        [StringLength(2)]
        public string RoNo { get; set; }
        [Column("MESSAGE_ID")]
        [StringLength(1)]
        public string MessageId { get; set; }
        [Column("OPE_DATE", TypeName = "datetime")]
        public DateTime? OpeDate { get; set; }
        [Column("TRANS_NO")]
        [StringLength(5)]
        public string TransNo { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("FILE_MAKE_TIME")]
        [StringLength(6)]
        public string FileMakeTime { get; set; }
        [Column("DELETE_FLG")]
        [StringLength(1)]
        public string DeleteFlg { get; set; }
        [Column("PROCESS_FLG")]
        [StringLength(1)]
        public string ProcessFlg { get; set; }
        [Column("PROCESS_DATE", TypeName = "datetime")]
        public DateTime? ProcessDate { get; set; }
        [Column("PROCESS_TIME")]
        [StringLength(6)]
        public string ProcessTime { get; set; }
        [Column("INPUT_EMP_CD")]
        [StringLength(4)]
        public string InputEmpCd { get; set; }
        [Column("INPUT_OPE_ID")]
        [StringLength(3)]
        public string InputOpeId { get; set; }
        [Column("APPROVE_EMP_CD")]
        [StringLength(4)]
        public string ApproveEmpCd { get; set; }
        [Column("APPROVE_OPE_ID")]
        [StringLength(3)]
        public string ApproveOpeId { get; set; }
        [Column("DEPARTMENT_CD")]
        [StringLength(2)]
        public string DepartmentCd { get; set; }
        [Column("PO_ISSUE_DATE", TypeName = "datetime")]
        public DateTime? PoIssueDate { get; set; }
        [Column("AUTO_REMIT_FLG")]
        [StringLength(1)]
        public string AutoRemitFlg { get; set; }
        [Column("SETTLE_CD")]
        [StringLength(2)]
        public string SettleCd { get; set; }
        [Column("NO_REMIT_FLG")]
        [StringLength(1)]
        public string NoRemitFlg { get; set; }
        [Column("NO_COMPLETE_FLG")]
        [StringLength(1)]
        public string NoCompleteFlg { get; set; }
        [Column("RMT_METHOD")]
        [StringLength(2)]
        public string RmtMethod { get; set; }
        [Column("MESSAGE_TYPE")]
        [StringLength(3)]
        public string MessageType { get; set; }
        [Column("PRIORITY")]
        [StringLength(2)]
        public string Priority { get; set; }
        [Column("REC_BANK_ID")]
        [StringLength(12)]
        public string RecBankId { get; set; }
        [Column("REC_BANK_NAME_1")]
        [StringLength(35)]
        public string RecBankName1 { get; set; }
        [Column("REC_BANK_NAME_2")]
        [StringLength(35)]
        public string RecBankName2 { get; set; }
        [Column("REC_BANK_NAME_3")]
        [StringLength(35)]
        public string RecBankName3 { get; set; }
        [Column("REC_BANK_NAME_4")]
        [StringLength(35)]
        public string RecBankName4 { get; set; }
        [Column("RELATED_REF_NO")]
        [StringLength(16)]
        public string RelatedRefNo { get; set; }
        [Column("SWIFT_CCY_CD")]
        [StringLength(3)]
        public string SwiftCcyCd { get; set; }
        [Column("AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? Amount { get; set; }
        [Column("ORDER_CUST_NAME_1")]
        [StringLength(35)]
        public string OrderCustName1 { get; set; }
        [Column("ORDER_CUST_NAME_2")]
        [StringLength(35)]
        public string OrderCustName2 { get; set; }
        [Column("ORDER_CUST_NAME_3")]
        [StringLength(35)]
        public string OrderCustName3 { get; set; }
        [Column("ORDER_CUST_NAME_4")]
        [StringLength(35)]
        public string OrderCustName4 { get; set; }
        [Column("ORD_BANK_ID")]
        [StringLength(12)]
        public string OrdBankId { get; set; }
        [Column("ORDER_BANK_NAME_1")]
        [StringLength(35)]
        public string OrderBankName1 { get; set; }
        [Column("ORDER_BANK_NAME_2")]
        [StringLength(35)]
        public string OrderBankName2 { get; set; }
        [Column("ORDER_BANK_NAME_3")]
        [StringLength(35)]
        public string OrderBankName3 { get; set; }
        [Column("ORDER_BANK_NAME_4")]
        [StringLength(35)]
        public string OrderBankName4 { get; set; }
        [Column("SEND_COR_BANK_ID")]
        [StringLength(12)]
        public string SendCorBankId { get; set; }
        [Column("SEND_COR_BANK_ACTNO")]
        [StringLength(35)]
        public string SendCorBankActno { get; set; }
        [Column("SEND_COR_BANK_NAME1")]
        [StringLength(35)]
        public string SendCorBankName1 { get; set; }
        [Column("SEND_COR_BANK_NAME2")]
        [StringLength(35)]
        public string SendCorBankName2 { get; set; }
        [Column("SEND_COR_BANK_NAME3")]
        [StringLength(35)]
        public string SendCorBankName3 { get; set; }
        [Column("SEND_COR_BANK_NAME4")]
        [StringLength(35)]
        public string SendCorBankName4 { get; set; }
        [Column("REC_COR_BANK_ID")]
        [StringLength(12)]
        public string RecCorBankId { get; set; }
        [Column("REC_COR_BANK_NAME1")]
        [StringLength(35)]
        public string RecCorBankName1 { get; set; }
        [Column("REC_COR_BANK_NAME2")]
        [StringLength(35)]
        public string RecCorBankName2 { get; set; }
        [Column("REC_COR_BANK_NAME3")]
        [StringLength(35)]
        public string RecCorBankName3 { get; set; }
        [Column("REC_COR_BANK_NAME4")]
        [StringLength(35)]
        public string RecCorBankName4 { get; set; }
        [Column("INT_BANK_ID")]
        [StringLength(12)]
        public string IntBankId { get; set; }
        [Column("INT_BANK_NAME1")]
        [StringLength(35)]
        public string IntBankName1 { get; set; }
        [Column("INT_BANK_NAME2")]
        [StringLength(35)]
        public string IntBankName2 { get; set; }
        [Column("INT_BANK_NAME3")]
        [StringLength(35)]
        public string IntBankName3 { get; set; }
        [Column("INT_BANK_NAME4")]
        [StringLength(35)]
        public string IntBankName4 { get; set; }
        [Column("ACC_BANK_ID")]
        [StringLength(12)]
        public string AccBankId { get; set; }
        [Column("ACC_BANK_NAME_1")]
        [StringLength(35)]
        public string AccBankName1 { get; set; }
        [Column("ACC_BANK_NAME_2")]
        [StringLength(35)]
        public string AccBankName2 { get; set; }
        [Column("ACC_BANK_NAME_3")]
        [StringLength(35)]
        public string AccBankName3 { get; set; }
        [Column("ACC_BANK_NAME_4")]
        [StringLength(35)]
        public string AccBankName4 { get; set; }
        [Column("BENE_BANK_ID")]
        [StringLength(12)]
        public string BeneBankId { get; set; }
        [Column("BENE_BANK_ACTNO")]
        [StringLength(35)]
        public string BeneBankActno { get; set; }
        [Column("BENE_BANK_NAME_1")]
        [StringLength(35)]
        public string BeneBankName1 { get; set; }
        [Column("BENE_BANK_NAME_2")]
        [StringLength(35)]
        public string BeneBankName2 { get; set; }
        [Column("BENE_BANK_NAME_3")]
        [StringLength(35)]
        public string BeneBankName3 { get; set; }
        [Column("BENE_BANK_NAME_4")]
        [StringLength(35)]
        public string BeneBankName4 { get; set; }
        [Column("PAYMENT_DETAIL_1")]
        [StringLength(35)]
        public string PaymentDetail1 { get; set; }
        [Column("PAYMENT_DETAIL_2")]
        [StringLength(35)]
        public string PaymentDetail2 { get; set; }
        [Column("PAYMENT_DETAIL_3")]
        [StringLength(35)]
        public string PaymentDetail3 { get; set; }
        [Column("PAYMENT_DETAIL_4")]
        [StringLength(35)]
        public string PaymentDetail4 { get; set; }
        [Column("CHARGE_DETAIL")]
        [StringLength(3)]
        public string ChargeDetail { get; set; }
        [Column("BANK_INF_1")]
        [StringLength(35)]
        public string BankInf1 { get; set; }
        [Column("BANK_INF_2")]
        [StringLength(35)]
        public string BankInf2 { get; set; }
        [Column("BANK_INF_3")]
        [StringLength(35)]
        public string BankInf3 { get; set; }
        [Column("BANK_INF_4")]
        [StringLength(35)]
        public string BankInf4 { get; set; }
        [Column("BANK_INF_5")]
        [StringLength(35)]
        public string BankInf5 { get; set; }
        [Column("BANK_INF_6")]
        [StringLength(35)]
        public string BankInf6 { get; set; }
        [Column("DR_HO_ACT")]
        [StringLength(2)]
        public string DrHoAct { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("MINIMUM_UNIT")]
        [StringLength(1)]
        public string MinimumUnit { get; set; }
        [Column("TESTKEY")]
        [StringLength(16)]
        public string Testkey { get; set; }
        [Column("TAG22_FLD_1")]
        [StringLength(8)]
        public string Tag22Fld1 { get; set; }
        [Column("TAG22_FLD_2")]
        [StringLength(16)]
        public string Tag22Fld2 { get; set; }
        [Column("TAG30_DATE", TypeName = "datetime")]
        public DateTime? Tag30Date { get; set; }
        [Column("TAG33_VALUE_DATE", TypeName = "datetime")]
        public DateTime? Tag33ValueDate { get; set; }
        [Column("TAG33_SWIFT_CCY_CD")]
        [StringLength(3)]
        public string Tag33SwiftCcyCd { get; set; }
        [Column("TAG33_CCY_CD")]
        [StringLength(2)]
        public string Tag33CcyCd { get; set; }
        [Column("TAG33_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? Tag33Amount { get; set; }
        [Column("TAG34_PAY_REC_FLG")]
        [StringLength(1)]
        public string Tag34PayRecFlg { get; set; }
        [Column("TAG34_VALUE_DATE", TypeName = "datetime")]
        public DateTime? Tag34ValueDate { get; set; }
        [Column("TAG34_SWIFT_CCY_CD")]
        [StringLength(3)]
        public string Tag34SwiftCcyCd { get; set; }
        [Column("TAG34_CCY_CD")]
        [StringLength(2)]
        public string Tag34CcyCd { get; set; }
        [Column("TAG34_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? Tag34Amount { get; set; }
        [Column("TAG36_RATE")]
        [StringLength(12)]
        public string Tag36Rate { get; set; }
        [Column("TAG37_DAYS_ID")]
        [StringLength(1)]
        public string Tag37DaysId { get; set; }
        [Column("TAG37_RATE")]
        [StringLength(12)]
        public string Tag37Rate { get; set; }
        [Column("TAG37_SUB_FLD1")]
        [StringLength(10)]
        public string Tag37SubFld1 { get; set; }
        [Column("TAG37_SUB_FLD2")]
        [StringLength(16)]
        public string Tag37SubFld2 { get; set; }
        [Column("ACT_NO")]
        [StringLength(35)]
        public string ActNo { get; set; }
        [Column("TAG23B_BK_OPCD")]
        [StringLength(4)]
        public string Tag23bBkOpcd { get; set; }
        [Column("TAG23E_INST_CODE1")]
        [StringLength(4)]
        public string Tag23eInstCode1 { get; set; }
        [Column("TAG23E_INST_INF1")]
        [StringLength(30)]
        public string Tag23eInstInf1 { get; set; }
        [Column("TAG23E_INST_CODE2")]
        [StringLength(4)]
        public string Tag23eInstCode2 { get; set; }
        [Column("TAG23E_INST_INF2")]
        [StringLength(30)]
        public string Tag23eInstInf2 { get; set; }
        [Column("TAG23E_INST_CODE3")]
        [StringLength(4)]
        public string Tag23eInstCode3 { get; set; }
        [Column("TAG23E_INST_INF3")]
        [StringLength(30)]
        public string Tag23eInstInf3 { get; set; }
        [Column("TAG23E_INST_CODE4")]
        [StringLength(4)]
        public string Tag23eInstCode4 { get; set; }
        [Column("TAG23E_INST_INF4")]
        [StringLength(30)]
        public string Tag23eInstInf4 { get; set; }
        [Column("TAG23E_INST_CODE5")]
        [StringLength(4)]
        public string Tag23eInstCode5 { get; set; }
        [Column("TAG23E_INST_INF5")]
        [StringLength(30)]
        public string Tag23eInstInf5 { get; set; }
        [Column("TAG23E_INST_CODE6")]
        [StringLength(4)]
        public string Tag23eInstCode6 { get; set; }
        [Column("TAG23E_INST_INF6")]
        [StringLength(30)]
        public string Tag23eInstInf6 { get; set; }
        [Column("TAG23E_INST_CODE7")]
        [StringLength(4)]
        public string Tag23eInstCode7 { get; set; }
        [Column("TAG23E_INST_INF7")]
        [StringLength(30)]
        public string Tag23eInstInf7 { get; set; }
        [Column("TAG23E_INST_CODE8")]
        [StringLength(4)]
        public string Tag23eInstCode8 { get; set; }
        [Column("TAG23E_INST_INF8")]
        [StringLength(30)]
        public string Tag23eInstInf8 { get; set; }
        [Column("TAG23E_INST_CODE9")]
        [StringLength(4)]
        public string Tag23eInstCode9 { get; set; }
        [Column("TAG23E_INST_INF9")]
        [StringLength(30)]
        public string Tag23eInstInf9 { get; set; }
        [Column("TAG26T_TRANS_TYPE")]
        [StringLength(3)]
        public string Tag26tTransType { get; set; }
        [Column("TAG50A_ORD_CST_ACT_NO")]
        [StringLength(35)]
        public string Tag50aOrdCstActNo { get; set; }
        [Column("TAG71F_SE_CHG_SW_CCY1")]
        [StringLength(3)]
        public string Tag71fSeChgSwCcy1 { get; set; }
        [Column("TAG71F_SE_CHG_CCY1")]
        [StringLength(2)]
        public string Tag71fSeChgCcy1 { get; set; }
        [Column("TAG71F_SE_CHG_AMT1", TypeName = "decimal(16, 3)")]
        public decimal? Tag71fSeChgAmt1 { get; set; }
        [Column("TAG71F_SE_CHG_SW_CCY2")]
        [StringLength(3)]
        public string Tag71fSeChgSwCcy2 { get; set; }
        [Column("TAG71F_SE_CHG_CCY2")]
        [StringLength(2)]
        public string Tag71fSeChgCcy2 { get; set; }
        [Column("TAG71F_SE_CHG_AMT2", TypeName = "decimal(16, 3)")]
        public decimal? Tag71fSeChgAmt2 { get; set; }
        [Column("TAG71F_SE_CHG_SW_CCY3")]
        [StringLength(3)]
        public string Tag71fSeChgSwCcy3 { get; set; }
        [Column("TAG71F_SE_CHG_CCY3")]
        [StringLength(2)]
        public string Tag71fSeChgCcy3 { get; set; }
        [Column("TAG71F_SE_CHG_AMT3", TypeName = "decimal(16, 3)")]
        public decimal? Tag71fSeChgAmt3 { get; set; }
        [Column("TAG71F_SE_CHG_SW_CCY4")]
        [StringLength(3)]
        public string Tag71fSeChgSwCcy4 { get; set; }
        [Column("TAG71F_SE_CHG_CCY4")]
        [StringLength(2)]
        public string Tag71fSeChgCcy4 { get; set; }
        [Column("TAG71F_SE_CHG_AMT4", TypeName = "decimal(16, 3)")]
        public decimal? Tag71fSeChgAmt4 { get; set; }
        [Column("TAG71G_REC_CHG_SW_CCY")]
        [StringLength(3)]
        public string Tag71gRecChgSwCcy { get; set; }
        [Column("TAG71G_REC_CHG_CCY")]
        [StringLength(2)]
        public string Tag71gRecChgCcy { get; set; }
        [Column("TAG71G_REC_CHG_AMT", TypeName = "decimal(16, 3)")]
        public decimal? Tag71gRecChgAmt { get; set; }
        [Column("TAG77B_REGULATORY1")]
        [StringLength(35)]
        public string Tag77bRegulatory1 { get; set; }
        [Column("TAG77B_REGULATORY2")]
        [StringLength(35)]
        public string Tag77bRegulatory2 { get; set; }
        [Column("TAG77B_REGULATORY3")]
        [StringLength(35)]
        public string Tag77bRegulatory3 { get; set; }
        [Column("REMARKS_EUC")]
        [StringLength(20)]
        public string RemarksEuc { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
