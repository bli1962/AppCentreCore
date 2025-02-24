using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("OBS_Yield_Export_Mapping", Schema = "dbo")]
    public partial class ObsYieldExportMapping
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("OBS_CCY")]
        [StringLength(3)]
        [Unicode(false)]
        public string ObsCcy { get; set; }
        [Column("OBS_YIELD_CURVE_TYPE")]
        [StringLength(25)]
        [Unicode(false)]
        public string ObsYieldCurveType { get; set; }
        [Column("OBS_YIELD_MATURITY")]
        [StringLength(10)]
        [Unicode(false)]
        public string ObsYieldMaturity { get; set; }
        [Column("MUREX_CCY")]
        [StringLength(3)]
        [Unicode(false)]
        public string MurexCcy { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string Type { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Generator { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Market { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string Maturity { get; set; }
    }
}
