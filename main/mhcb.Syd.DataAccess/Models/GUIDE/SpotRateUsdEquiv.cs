using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SPOT_RATE_USD_EQUIV", Schema = "dbo")]
    public partial class SpotRateUsdEquiv
    {
        [Key]
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime DataDate { get; set; }
        [Key]
        [Column("CCY")]
        [StringLength(3)]
        [Unicode(false)]
        public string Ccy { get; set; }
        [Column("RATE", TypeName = "decimal(16, 5)")]
        public decimal Rate { get; set; }
        [Column("IMPORTED_TIME", TypeName = "datetime")]
        public DateTime? ImportedTime { get; set; }
    }
}
