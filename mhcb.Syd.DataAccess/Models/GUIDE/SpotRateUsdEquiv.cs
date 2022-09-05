using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SPOT_RATE_USD_EQUIV")]
    public partial class SpotRateUsdEquiv
    {
        [Key]
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime DataDate { get; set; }
        [Key]
        [Column("CCY")]
        [StringLength(3)]
        public string Ccy { get; set; }
        [Column("RATE", TypeName = "decimal(16, 5)")]
        public decimal Rate { get; set; }
        [Column("IMPORTED_TIME", TypeName = "datetime")]
        public DateTime? ImportedTime { get; set; }
    }
}
