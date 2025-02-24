using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("BANK_INF_CORR", Schema = "dbo")]
    [Index("MmSettlBankId", Name = "IX_BANK_INF_CORR_SETTLE_BANK_ID")]
    [Index("SwiftId", Name = "IX_BANK_INF_CORR_SWIFT_id")]
    public partial class BankInfCorr
    {
        [Column("BANK_INF_ID")]
        public int BankInfId { get; set; }
        [Key]
        [Column("SWIFT_ID")]
        [StringLength(12)]
        [Unicode(false)]
        public string SwiftId { get; set; }
        [Key]
        [Column("CCY_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string CcyCd { get; set; }
        [Column("MM_SETTL_BANK_ID")]
        [StringLength(12)]
        [Unicode(false)]
        public string MmSettlBankId { get; set; }
        [Column("MM_SETTL_BANK_ACTNO")]
        [StringLength(34)]
        [Unicode(false)]
        public string MmSettlBankActno { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        [Unicode(false)]
        public string BranchNo { get; set; }
        [Key]
        [Column("SETTL_BRANCH_NO")]
        [StringLength(3)]
        [Unicode(false)]
        public string SettlBranchNo { get; set; }
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
        [Column("STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; }
        [Column("DELETION_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string DeletionStatus { get; set; }
        [Column("GIP_STATUS")]
        [StringLength(2)]
        [Unicode(false)]
        public string GipStatus { get; set; }
        [Column("TRAN_NO")]
        [StringLength(5)]
        [Unicode(false)]
        public string TranNo { get; set; }

        [ForeignKey("SwiftId,SettlBranchNo")]
        [InverseProperty("BankInfCorrs")]
        public virtual BankInf S { get; set; }
    }
}
