﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GUIDE_SWAP_RATE_TEMPL", Schema = "dbo")]
    public partial class GuideSwapRateTempl
    {
        [Column("RIC")]
        [StringLength(20)]
        public string Ric { get; set; }
        [Required]
        [Column("CCY")]
        [StringLength(3)]
        [Unicode(false)]
        public string Ccy { get; set; }
        [Column("DURATION")]
        public int Duration { get; set; }
        [Required]
        [Column("DURATION_UNIT")]
        [StringLength(5)]
        [Unicode(false)]
        public string DurationUnit { get; set; }
        [Column("ORDER_BY")]
        public int OrderBy { get; set; }
    }
}
