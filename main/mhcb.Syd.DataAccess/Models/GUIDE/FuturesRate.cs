using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FUTURES_RATE", Schema = "dbo")]
    public partial class FuturesRate
    {
        [Key]
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime DataDate { get; set; }
        [Key]
        [Column("CCY")]
        [StringLength(4)]
        [Unicode(false)]
        public string Ccy { get; set; }
        [Key]
        [Column("PERIOD", TypeName = "datetime")]
        public DateTime Period { get; set; }
        [Column("RATE", TypeName = "decimal(16, 9)")]
        public decimal Rate { get; set; }
        [Required]
        [Column("IMPORTED_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string ImportedBy { get; set; }
        [Column("REC_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string RecStatus { get; set; }
    }
}
