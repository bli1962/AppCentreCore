using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("FEE_KIND")]
    public partial class FeeKind
    {
        public FeeKind()
        {
            FeeRateLimitChangeLogs = new HashSet<FeeRateLimitChangeLog>();
        }

        [Key]
        [Column("FEE_KIND_ID")]
        public byte FeeKindId { get; set; }
        [Required]
        [Column("FEE_KIND")]
        [StringLength(5)]
        public string FeeKind1 { get; set; }

        [InverseProperty(nameof(FeeRateLimitChangeLog.FeeKind))]
        public virtual ICollection<FeeRateLimitChangeLog> FeeRateLimitChangeLogs { get; set; }
    }
}
