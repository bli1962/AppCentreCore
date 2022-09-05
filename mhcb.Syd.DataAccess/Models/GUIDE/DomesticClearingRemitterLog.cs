using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_RemitterLog")]
    public partial class DomesticClearingRemitterLog
    {
        [Key]
        public int RemitterLogId { get; set; }
        public int RemitterId { get; set; }
        [StringLength(1024)]
        public string Type { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }

        [ForeignKey(nameof(RemitterId))]
        [InverseProperty(nameof(DomesticClearingRemitter.DomesticClearingRemitterLogs))]
        public virtual DomesticClearingRemitter Remitter { get; set; }
    }
}
