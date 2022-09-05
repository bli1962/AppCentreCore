using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SETTLEMENT_CORP_CUST_DEFAULT")]
    [Index(nameof(BranchNo), nameof(RecordKind), nameof(CcyAbbr), nameof(RecSettlCode), nameof(DefaultFlg), Name = "IX_SETTLEMENT_CORP_CUST_DEFAULT", IsUnique = true)]
    public partial class SettlementCorpCustDefault
    {
        [Key]
        [Column("CORP_CUST_ID")]
        public int CorpCustId { get; set; }
        [Required]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Required]
        [Column("RECORD_KIND")]
        [StringLength(1)]
        public string RecordKind { get; set; }
        [Required]
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Required]
        [Column("REC_SETTL_CODE")]
        [StringLength(2)]
        public string RecSettlCode { get; set; }
        [Required]
        [Column("REC_ACT_CD")]
        [StringLength(5)]
        public string RecActCd { get; set; }
        [Required]
        [Column("REC_ACT_NO")]
        [StringLength(9)]
        public string RecActNo { get; set; }
        [Required]
        [Column("REC_RMT_FLG")]
        [StringLength(1)]
        public string RecRmtFlg { get; set; }
        [Required]
        [Column("REC_METHOD")]
        [StringLength(2)]
        public string RecMethod { get; set; }
        [Required]
        [Column("REC_MESSAGE_TYPE")]
        [StringLength(3)]
        public string RecMessageType { get; set; }
        [Required]
        [Column("PAY_SETTL_CODE")]
        [StringLength(2)]
        public string PaySettlCode { get; set; }
        [Required]
        [Column("PAY_ACT_CD")]
        [StringLength(5)]
        public string PayActCd { get; set; }
        [Required]
        [Column("PAY_ACT_NO")]
        [StringLength(9)]
        public string PayActNo { get; set; }
        [Required]
        [Column("PAY_RMT_FLG")]
        [StringLength(1)]
        public string PayRmtFlg { get; set; }
        [Required]
        [Column("PAY_METHOD")]
        [StringLength(2)]
        public string PayMethod { get; set; }
        [Required]
        [Column("PAY_MESSAGE_TYPE")]
        [StringLength(3)]
        public string PayMessageType { get; set; }
        [Required]
        [Column("ADVICE_REC_FLG")]
        [StringLength(1)]
        public string AdviceRecFlg { get; set; }
        [Column("ADVICE_REC_LIMIT", TypeName = "decimal(16, 3)")]
        public decimal AdviceRecLimit { get; set; }
        [Required]
        [Column("PRIORTY_FLG")]
        [StringLength(2)]
        public string PriortyFlg { get; set; }
        [Column("REC_BANK_ID")]
        [StringLength(12)]
        public string RecBankId { get; set; }
        [Column("INTERMEDIARY_BANK_ID")]
        [StringLength(12)]
        public string IntermediaryBankId { get; set; }
        [Column("ORDERING_CUSTOMER")]
        [StringLength(12)]
        public string OrderingCustomer { get; set; }
        [Column("ORDERING_BANK")]
        [StringLength(12)]
        public string OrderingBank { get; set; }
        [Column("BENE_BANK_ID")]
        [StringLength(12)]
        public string BeneBankId { get; set; }
        [Column("ACC_BANK_ID")]
        [StringLength(12)]
        public string AccBankId { get; set; }
        [Column("SENDER_CORRES")]
        [StringLength(12)]
        public string SenderCorres { get; set; }
        [Column("REC_CORRES")]
        [StringLength(12)]
        public string RecCorres { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Required]
        [Column("DEFAULT_FLG")]
        public bool? DefaultFlg { get; set; }
    }
}
