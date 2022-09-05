using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("OUTGOING_REMITTANCE_MT360", Schema = "EUC")]
    public partial class OutgoingRemittanceMt360
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
        [Column("SEND_COR_BANK_1_ID")]
        [StringLength(12)]
        public string SendCorBank1Id { get; set; }
        [Column("SEND_COR_BANK_1_ACTNO")]
        [StringLength(35)]
        public string SendCorBank1Actno { get; set; }
        [Column("SENJD_COR_BANK_1_NAME")]
        [StringLength(35)]
        public string SenjdCorBank1Name { get; set; }
        [Column("SEND_COR_BANK_2_ID")]
        [StringLength(12)]
        public string SendCorBank2Id { get; set; }
        [Column("SEND_COR_BANK_2_ACTNO")]
        [StringLength(35)]
        public string SendCorBank2Actno { get; set; }
        [Column("SEND_COR_BANK_2_NAME")]
        [StringLength(35)]
        public string SendCorBank2Name { get; set; }
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
        [Column("INT_BANK_1_ID")]
        [StringLength(12)]
        public string IntBank1Id { get; set; }
        [Column("INT_BANK_1_NAME")]
        [StringLength(35)]
        public string IntBank1Name { get; set; }
        [Column("INT_BANK_2_ID")]
        [StringLength(12)]
        public string IntBank2Id { get; set; }
        [Column("INT_BANK_2_NAME")]
        [StringLength(35)]
        public string IntBank2Name { get; set; }
        [Column("ACC_BANK_1_ID")]
        [StringLength(12)]
        public string AccBank1Id { get; set; }
        [Column("ACC_BANK_1_NAME")]
        [StringLength(35)]
        public string AccBank1Name { get; set; }
        [Column("ACC_BANK_2_ID")]
        [StringLength(12)]
        public string AccBank2Id { get; set; }
        [Column("ACC_BANK_2_NAME")]
        [StringLength(35)]
        public string AccBank2Name { get; set; }
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
        [Column("CHARGE")]
        [StringLength(3)]
        public string Charge { get; set; }
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
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
