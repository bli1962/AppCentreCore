using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GUIDE_REVALUATION_RATE_TEMPL", Schema = "dbo")]
    public partial class GuideRevaluationRateTempl
    {
        [Column("RIC")]
        [StringLength(20)]
        [Unicode(false)]
        public string Ric { get; set; }
        [Required]
        [Column("CCY")]
        [StringLength(3)]
        [Unicode(false)]
        public string Ccy { get; set; }
        [Column("DURATION")]
        public int Duration { get; set; }
        [Column("ORDER_BY")]
        public int OrderBy { get; set; }
        public bool IsGbaseUpload { get; set; }
        [Column("MUREX_LABLE")]
        [StringLength(30)]
        [Unicode(false)]
        public string MurexLable { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string Type { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Generator { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Market { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string Maturity { get; set; }
    }
}
