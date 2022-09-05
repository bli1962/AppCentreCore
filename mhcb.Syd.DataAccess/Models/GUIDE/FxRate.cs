using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FX_RATE")]
    public partial class FxRate
    {
        [Key]
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime DataDate { get; set; }
        [Key]
        [Column("CCY")]
        [StringLength(3)]
        public string Ccy { get; set; }
        [Column("BID", TypeName = "decimal(16, 5)")]
        public decimal Bid { get; set; }
        [Column("OFFER", TypeName = "decimal(16, 5)")]
        public decimal Offer { get; set; }
        [Column("RATE", TypeName = "decimal(16, 5)")]
        public decimal Rate { get; set; }
        [Required]
        [Column("IMPORTED_BY")]
        [StringLength(8)]
        public string ImportedBy { get; set; }
        [Column("REC_STATUS")]
        [StringLength(1)]
        public string RecStatus { get; set; }
        [Column("IMPORTED_TIME", TypeName = "datetime")]
        public DateTime? ImportedTime { get; set; }
    }
}
