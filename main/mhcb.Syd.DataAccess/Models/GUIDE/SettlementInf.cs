using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SETTLEMENT_INF", Schema = "dbo")]
    [Index("BranchNo", "CustAbbr", "CcyCd", "RecordKind", Name = "IX_SETTLEMENT_INF", IsUnique = true)]
    public partial class SettlementInf
    {
        [Key]
        [Column("SIF_ID")]
        public int SifId { get; set; }
        [Required]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        [Unicode(false)]
        public string BranchNo { get; set; }
        [Required]
        [Column("RECORD_KIND")]
        [StringLength(1)]
        [Unicode(false)]
        public string RecordKind { get; set; }
        [Required]
        [Column("CUST_ABBR")]
        [StringLength(12)]
        [Unicode(false)]
        public string CustAbbr { get; set; }
        [Required]
        [Column("CCY_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string CcyCd { get; set; }
        [Column("REC_SETTL_CODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string RecSettlCode { get; set; }
        [Column("REC_ACT_CD")]
        [StringLength(5)]
        [Unicode(false)]
        public string RecActCd { get; set; }
        [Column("REC_ACT_NO")]
        [StringLength(9)]
        [Unicode(false)]
        public string RecActNo { get; set; }
        [Column("REC_RMT_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string RecRmtFlg { get; set; }
        [Column("REC_METHOD")]
        [StringLength(2)]
        [Unicode(false)]
        public string RecMethod { get; set; }
        [Column("REC_MESSAGE_TYPE")]
        [StringLength(3)]
        [Unicode(false)]
        public string RecMessageType { get; set; }
        [Column("PAY_SETTL_CODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string PaySettlCode { get; set; }
        [Column("PAY_ACT_CD")]
        [StringLength(5)]
        [Unicode(false)]
        public string PayActCd { get; set; }
        [Column("PAY_ACT_NO")]
        [StringLength(9)]
        [Unicode(false)]
        public string PayActNo { get; set; }
        [Column("PAY_RMT_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string PayRmtFlg { get; set; }
        [Column("PAY_METHOD")]
        [StringLength(2)]
        [Unicode(false)]
        public string PayMethod { get; set; }
        [Column("PAY_MESSAGE_TYPE")]
        [StringLength(3)]
        [Unicode(false)]
        public string PayMessageType { get; set; }
        [Column("PRIORTY_FLG")]
        [StringLength(2)]
        [Unicode(false)]
        public string PriortyFlg { get; set; }
        [Column("BANK_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string BankFlg { get; set; }
        [Column("COVER_PO_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string CoverPoFlg { get; set; }
        [Column("ADVICE_REC_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string AdviceRecFlg { get; set; }
        [Column("ADVICE_REC_LIMIT", TypeName = "decimal(16, 3)")]
        public decimal? AdviceRecLimit { get; set; }
        [Column("REC_BANK_ID")]
        [StringLength(12)]
        [Unicode(false)]
        public string RecBankId { get; set; }
        [Column("REC_CUST_ABBR")]
        [StringLength(12)]
        [Unicode(false)]
        public string RecCustAbbr { get; set; }
        [Column("INTERMEDIARY_BANK_ID")]
        [StringLength(12)]
        [Unicode(false)]
        public string IntermediaryBankId { get; set; }
        [Column("ACC_BANK_ID")]
        [StringLength(12)]
        [Unicode(false)]
        public string AccBankId { get; set; }
        [Column("ACC_BANK_ACTNO")]
        [StringLength(34)]
        [Unicode(false)]
        public string AccBankActno { get; set; }
        [Column("BENE_BANK_ID")]
        [StringLength(12)]
        [Unicode(false)]
        public string BeneBankId { get; set; }
        [Column("BENE_BANK_ACTNO")]
        [StringLength(34)]
        [Unicode(false)]
        public string BeneBankActno { get; set; }
        [Column("CONFIRMATION_SWIFT_ID")]
        [StringLength(12)]
        [Unicode(false)]
        public string ConfirmationSwiftId { get; set; }
        [Column("CONFIRMATION_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string ConfirmationFlg { get; set; }
        [Column("REC_BANK_BR_ACTNO")]
        [StringLength(20)]
        [Unicode(false)]
        public string RecBankBrActno { get; set; }
        [Column("REC_BANK_HO_ACTNO")]
        [StringLength(20)]
        [Unicode(false)]
        public string RecBankHoActno { get; set; }
        [Column("BANK_INF_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string BankInfFlg { get; set; }
        [Column("BANK_INF")]
        [StringLength(35)]
        [Unicode(false)]
        public string BankInf { get; set; }
        [Column("OCNNECT_FLG")]
        [StringLength(1)]
        [Unicode(false)]
        public string OcnnectFlg { get; set; }
        [Column("OPE_DATE", TypeName = "smalldatetime")]
        public DateTime? OpeDate { get; set; }
        [Column("REMARKS")]
        [StringLength(70)]
        [Unicode(false)]
        public string Remarks { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        [Unicode(false)]
        public string StatusCd { get; set; }
        [Required]
        [Column("ADD_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string AddBy { get; set; }
        [Column("ADD_ON", TypeName = "smalldatetime")]
        public DateTime AddOn { get; set; }
        [Required]
        [Column("AUTHORIZE_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string AuthorizeBy { get; set; }
        [Column("AUTHORIZE_ON", TypeName = "smalldatetime")]
        public DateTime AuthorizeOn { get; set; }
        [Required]
        [Column("MODIFY_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string ModifyBy { get; set; }
        [Column("MODIFY_ON", TypeName = "smalldatetime")]
        public DateTime ModifyOn { get; set; }
        [Required]
        [Column("DELETE_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string DeleteBy { get; set; }
        [Column("DELETE_ON", TypeName = "smalldatetime")]
        public DateTime DeleteOn { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; }
        [Required]
        [Column("DELETION_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string DeletionStatus { get; set; }
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
    }
}
