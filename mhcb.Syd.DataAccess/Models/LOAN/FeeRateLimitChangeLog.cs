using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("FEE_RATE_LIMIT_CHANGE_LOG")]
    public partial class FeeRateLimitChangeLog
    {
        [Key]
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Key]
        [Column("FEE_TRANS_NO")]
        public short FeeTransNo { get; set; }
        [Column("LIMIT", TypeName = "decimal(18, 4)")]
        public decimal Limit { get; set; }
        [Column("FEE_KIND_ID")]
        public byte? FeeKindId { get; set; }
        [Column("FEE_RATE", TypeName = "decimal(18, 6)")]
        public decimal FeeRate { get; set; }
        [Column("EFFECTIVE_DATE", TypeName = "smalldatetime")]
        public DateTime EffectiveDate { get; set; }
        [Required]
        [Column("PROC_BY")]
        [StringLength(6)]
        public string ProcBy { get; set; }
        [Column("PROC_ON", TypeName = "smalldatetime")]
        public DateTime? ProcOn { get; set; }
        [Column("APPR_BY")]
        [StringLength(6)]
        public string ApprBy { get; set; }
        [Column("APPR_ON", TypeName = "smalldatetime")]
        public DateTime? ApprOn { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }

        [ForeignKey(nameof(FeeKindId))]
        [InverseProperty("FeeRateLimitChangeLogs")]
        public virtual FeeKind FeeKind { get; set; }
        [ForeignKey(nameof(RefNo))]
        [InverseProperty(nameof(FacilityMaster.FeeRateLimitChangeLogs))]
        public virtual FacilityMaster RefNoNavigation { get; set; }
    }
}
