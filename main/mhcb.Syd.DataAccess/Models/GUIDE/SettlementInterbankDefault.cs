using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SETTLEMENT_INTERBANK_DEFAULT", Schema = "dbo")]
    [Index("RecordKind", "CcyCd", "DefaultFlg", Name = "IX_SETTLEMENT_INTERBANK_DEFAULT", IsUnique = true)]
    public partial class SettlementInterbankDefault
    {
        [Key]
        [Column("INTERBANK_ID")]
        public int InterbankId { get; set; }
        [Column("RECORD_KIND")]
        [StringLength(1)]
        [Unicode(false)]
        public string RecordKind { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string CcyCd { get; set; }
        [Required]
        [Column("REC_SETTL_CODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string RecSettlCode { get; set; }
        [Column("REC_ACT_CD")]
        [StringLength(5)]
        [Unicode(false)]
        public string RecActCd { get; set; }
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
        [Required]
        [Column("PAY_SETTL_CODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string PaySettlCode { get; set; }
        [Column("PAY_ACT_CD")]
        [StringLength(5)]
        [Unicode(false)]
        public string PayActCd { get; set; }
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
        public decimal AdviceRecLimit { get; set; }
        [Column("REC_BANK_ID")]
        [StringLength(12)]
        [Unicode(false)]
        public string RecBankId { get; set; }
        [Column("ACCOUNT_NO")]
        [StringLength(10)]
        [Unicode(false)]
        public string AccountNo { get; set; }
        [Column("OBU_ACCOUNT_NO")]
        [StringLength(10)]
        [Unicode(false)]
        public string ObuAccountNo { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; }
        [Column("DEFAULT_FLG")]
        public bool? DefaultFlg { get; set; }
    }
}
