using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("BATCH_LOG_COMMON", Schema = "EUC")]
    public partial class BatchLogCommon
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("TRANS_NO")]
        [StringLength(5)]
        public string TransNo { get; set; }
        [Column("SEQ_NO")]
        [StringLength(2)]
        public string SeqNo { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("DEPARTMENT_CD")]
        [StringLength(2)]
        public string DepartmentCd { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("DD_NO")]
        [StringLength(3)]
        public string DdNo { get; set; }
        [Column("RO_NO")]
        [StringLength(3)]
        public string RoNo { get; set; }
        [Column("ONLINE_CD")]
        [StringLength(4)]
        public string OnlineCd { get; set; }
        [Column("OPE_KIND")]
        [StringLength(1)]
        public string OpeKind { get; set; }
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
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("IRREGULAR_TRANS_FLG")]
        [StringLength(2)]
        public string IrregularTransFlg { get; set; }
        [Column("REMARKS")]
        [StringLength(30)]
        public string Remarks { get; set; }
        [Column("TERMINAL_ID")]
        [StringLength(4)]
        public string TerminalId { get; set; }
        [Column("ORG_TRANS_OPE_DATE", TypeName = "datetime")]
        public DateTime? OrgTransOpeDate { get; set; }
        [Column("ORG_TRANS_NO")]
        [StringLength(5)]
        public string OrgTransNo { get; set; }
        [Column("ORG_TRANS_ONLINE_CD")]
        [StringLength(4)]
        public string OrgTransOnlineCd { get; set; }
        [Column("CORRECT_FLG")]
        [StringLength(2)]
        public string CorrectFlg { get; set; }
        [Column("TRANS_TIME")]
        [StringLength(6)]
        public string TransTime { get; set; }
        [Column("DELETE_TIME")]
        [StringLength(6)]
        public string DeleteTime { get; set; }
        [Column("APPROVE_TIME")]
        [StringLength(6)]
        public string ApproveTime { get; set; }
        [Column("APPROVE_FLG")]
        [StringLength(1)]
        public string ApproveFlg { get; set; }
        [Column("DELETE_FLG")]
        [StringLength(1)]
        public string DeleteFlg { get; set; }
        [Column("RECOVERY_FLG")]
        [StringLength(1)]
        public string RecoveryFlg { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("CONTRACT_DATE", TypeName = "datetime")]
        public DateTime? ContractDate { get; set; }
        [Column("DELIVERY_DATE", TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [Column("CCY_CODE")]
        [StringLength(2)]
        public string CcyCode { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? Amount { get; set; }
        [Column("DD_VALUE_DATE", TypeName = "datetime")]
        public DateTime? DdValueDate { get; set; }
        [Column("DUE_DATE", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("DAYS")]
        [StringLength(4)]
        public string Days { get; set; }
        [Column("INT_RATE", TypeName = "decimal(9, 6)")]
        public decimal? IntRate { get; set; }
        [Column("INT_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? IntAmount { get; set; }
        [Column("PREV_CCY_CODE")]
        [StringLength(2)]
        public string PrevCcyCode { get; set; }
        [Column("PREV_CCY_ABBR")]
        [StringLength(4)]
        public string PrevCcyAbbr { get; set; }
        [Column("PREV_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? PrevAmount { get; set; }
        [Column("PREV_VALUE_DATE", TypeName = "datetime")]
        public DateTime? PrevValueDate { get; set; }
        [Column("PREV_DUE_DATE", TypeName = "datetime")]
        public DateTime? PrevDueDate { get; set; }
        [Column("PREV_DAYS")]
        [StringLength(4)]
        public string PrevDays { get; set; }
        [Column("PREV_INT_RATE", TypeName = "decimal(9, 6)")]
        public decimal? PrevIntRate { get; set; }
        [Column("PREV_INT_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? PrevIntAmount { get; set; }
        [Column("DISCOUNT_FLG")]
        [StringLength(1)]
        public string DiscountFlg { get; set; }
        [Column("INT_PAYER_FLG")]
        [StringLength(1)]
        public string IntPayerFlg { get; set; }
        [Column("FINAL_DUE_DATE", TypeName = "datetime")]
        public DateTime? FinalDueDate { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
