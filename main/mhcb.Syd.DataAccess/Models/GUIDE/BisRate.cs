using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("BIS_RATE", Schema = "dbo")]
    public partial class BisRate
    {
        [Key]
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime DataDate { get; set; }
        [Key]
        [Column("CCY")]
        [StringLength(3)]
        [Unicode(false)]
        public string Ccy { get; set; }
        [Key]
        [Column("DURATION")]
        public int Duration { get; set; }
        [Key]
        [Column("DURATION_UNIT")]
        [StringLength(5)]
        [Unicode(false)]
        public string DurationUnit { get; set; }
        [Column("BASE_RATE", TypeName = "decimal(16, 7)")]
        public decimal BaseRate { get; set; }
        [Required]
        [Column("IMPORTED_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string ImportedBy { get; set; }
        [Required]
        [Column("REC_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string RecStatus { get; set; }
        [Column("IMPORTED_TIME", TypeName = "datetime")]
        public DateTime ImportedTime { get; set; }
    }
}
