using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("AUDIT_MUREX_GUIDE_RATE_CHANGE", Schema = "dbo")]
    public partial class AuditMurexGuideRateChange
    {
        [Key]
        [Column("IDENTIFIER")]
        public int Identifier { get; set; }
        [Column("LOGDATE", TypeName = "datetime")]
        public DateTime? Logdate { get; set; }
        [Column("RATE_TYPE")]
        [StringLength(30)]
        [Unicode(false)]
        public string RateType { get; set; }
        [Column("DETAIL")]
        [StringLength(1500)]
        [Unicode(false)]
        public string Detail { get; set; }
    }
}
