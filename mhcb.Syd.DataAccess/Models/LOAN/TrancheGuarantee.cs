using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("TRANCHE_GUARANTEE")]
    public partial class TrancheGuarantee
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TRANCHE_NO")]
        public int TrancheNo { get; set; }
        [Required]
        [Column("GUARANTEE_NO")]
        [StringLength(15)]
        public string GuaranteeNo { get; set; }
        [Column("GBASE_GUARANTEE_NO")]
        [StringLength(15)]
        public string GbaseGuaranteeNo { get; set; }
        [Column("BORROWER")]
        [StringLength(100)]
        public string Borrower { get; set; }
        [Column("MULTI_BORROWERS")]
        [StringLength(100)]
        public string MultiBorrowers { get; set; }
        [Column("BENEFICIARY")]
        [StringLength(100)]
        public string Beneficiary { get; set; }
        [Column("CCY")]
        [StringLength(3)]
        public string Ccy { get; set; }
        [Column("ORIGINAL_AMOUNT", TypeName = "decimal(18, 2)")]
        public decimal? OriginalAmount { get; set; }
        [Column("OUTSTANDING_AMOUNT", TypeName = "decimal(18, 2)")]
        public decimal? OutstandingAmount { get; set; }
        [Column("BG_ISSUE_DATE", TypeName = "smalldatetime")]
        public DateTime? BgIssueDate { get; set; }
        [Column("BG_CANCEL_DATE", TypeName = "smalldatetime")]
        public DateTime? BgCancelDate { get; set; }
        [Column("BG_EXPIRY_DATE", TypeName = "smalldatetime")]
        public DateTime? BgExpiryDate { get; set; }
        [Column("BG_REMARK")]
        [StringLength(200)]
        public string BgRemark { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }

        [ForeignKey(nameof(TrancheNo))]
        [InverseProperty(nameof(TrancheMaster.TrancheGuarantees))]
        public virtual TrancheMaster TrancheNoNavigation { get; set; }
    }
}
