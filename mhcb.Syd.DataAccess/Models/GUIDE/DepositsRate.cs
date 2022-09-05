using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DEPOSITS_RATE")]
    public partial class DepositsRate
    {
        [Key]
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime DataDate { get; set; }
        [Key]
        [Column("CCY")]
        [StringLength(3)]
        public string Ccy { get; set; }
        [Key]
        [Column("PERIOD")]
        [StringLength(4)]
        public string Period { get; set; }
        [Column("BID", TypeName = "decimal(16, 9)")]
        public decimal? Bid { get; set; }
        [Column("OFFER", TypeName = "decimal(16, 9)")]
        public decimal? Offer { get; set; }
        [Column("RATE", TypeName = "decimal(16, 9)")]
        public decimal Rate { get; set; }
        [Required]
        [Column("IMPORTED_BY")]
        [StringLength(8)]
        public string ImportedBy { get; set; }
        [Required]
        [Column("REC_STATUS")]
        [StringLength(1)]
        public string RecStatus { get; set; }
        [Column("IMPORTED_TIME", TypeName = "datetime")]
        public DateTime ImportedTime { get; set; }
    }
}
