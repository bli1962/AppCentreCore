using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SETTLEMENT_INTERBANK_DEFAULT")]
    [Index(nameof(RecordKind), nameof(CcyCd), nameof(DefaultFlg), Name = "IX_SETTLEMENT_INTERBANK_DEFAULT", IsUnique = true)]
    public partial class SettlementInterbankDefault
    {
        [Key]
        [Column("INTERBANK_ID")]
        public int InterbankId { get; set; }
        [Column("RECORD_KIND")]
        [StringLength(1)]
        public string RecordKind { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Required]
        [Column("REC_SETTL_CODE")]
        [StringLength(2)]
        public string RecSettlCode { get; set; }
        [Column("REC_ACT_CD")]
        [StringLength(5)]
        public string RecActCd { get; set; }
        [Column("REC_RMT_FLG")]
        [StringLength(1)]
        public string RecRmtFlg { get; set; }
        [Column("REC_METHOD")]
        [StringLength(2)]
        public string RecMethod { get; set; }
        [Column("REC_MESSAGE_TYPE")]
        [StringLength(3)]
        public string RecMessageType { get; set; }
        [Required]
        [Column("PAY_SETTL_CODE")]
        [StringLength(2)]
        public string PaySettlCode { get; set; }
        [Column("PAY_ACT_CD")]
        [StringLength(5)]
        public string PayActCd { get; set; }
        [Column("PAY_RMT_FLG")]
        [StringLength(1)]
        public string PayRmtFlg { get; set; }
        [Column("PAY_METHOD")]
        [StringLength(2)]
        public string PayMethod { get; set; }
        [Column("PAY_MESSAGE_TYPE")]
        [StringLength(3)]
        public string PayMessageType { get; set; }
        [Column("PRIORTY_FLG")]
        [StringLength(2)]
        public string PriortyFlg { get; set; }
        [Column("BANK_FLG")]
        [StringLength(1)]
        public string BankFlg { get; set; }
        [Column("COVER_PO_FLG")]
        [StringLength(1)]
        public string CoverPoFlg { get; set; }
        [Column("ADVICE_REC_FLG")]
        [StringLength(1)]
        public string AdviceRecFlg { get; set; }
        [Column("ADVICE_REC_LIMIT", TypeName = "decimal(16, 3)")]
        public decimal AdviceRecLimit { get; set; }
        [Column("REC_BANK_ID")]
        [StringLength(12)]
        public string RecBankId { get; set; }
        [Column("ACCOUNT_NO")]
        [StringLength(10)]
        public string AccountNo { get; set; }
        [Column("OBU_ACCOUNT_NO")]
        [StringLength(10)]
        public string ObuAccountNo { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Required]
        [Column("DEFAULT_FLG")]
        public bool? DefaultFlg { get; set; }
    }
}
