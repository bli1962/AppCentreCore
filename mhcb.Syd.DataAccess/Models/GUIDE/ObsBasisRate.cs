using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("OBS_BASIS_RATE")]
    public partial class ObsBasisRate
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("OBS_CCY")]
        [StringLength(3)]
        public string ObsCcy { get; set; }
        [Column("OBS_YIELD_MATURITY")]
        [StringLength(5)]
        public string ObsYieldMaturity { get; set; }
        [Column("BID", TypeName = "decimal(16, 5)")]
        public decimal? Bid { get; set; }
        [Column("ASK", TypeName = "decimal(16, 5)")]
        public decimal? Ask { get; set; }
        [Column("MID", TypeName = "decimal(16, 5)")]
        public decimal? Mid { get; set; }
        [Column("DATE", TypeName = "datetime")]
        public DateTime? Date { get; set; }
    }
}
