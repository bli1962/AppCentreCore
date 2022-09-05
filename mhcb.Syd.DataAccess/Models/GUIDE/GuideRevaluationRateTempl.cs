using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GUIDE_REVALUATION_RATE_TEMPL")]
    public partial class GuideRevaluationRateTempl
    {
        [Column("RIC")]
        [StringLength(20)]
        public string Ric { get; set; }
        [Required]
        [Column("CCY")]
        [StringLength(3)]
        public string Ccy { get; set; }
        [Column("DURATION")]
        public int Duration { get; set; }
        [Column("ORDER_BY")]
        public int OrderBy { get; set; }
        public bool IsGbaseUpload { get; set; }
        [Column("MUREX_LABLE")]
        [StringLength(30)]
        public string MurexLable { get; set; }
        [StringLength(25)]
        public string Type { get; set; }
        [StringLength(30)]
        public string Generator { get; set; }
        [StringLength(30)]
        public string Market { get; set; }
        [StringLength(5)]
        public string Maturity { get; set; }
    }
}
