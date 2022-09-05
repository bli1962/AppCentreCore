using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GUIDE_DEPOSIT_RATE_TEMPL")]
    public partial class GuideDepositRateTempl
    {
        [Required]
        [Column("RIC")]
        [StringLength(20)]
        public string Ric { get; set; }
        [Required]
        [Column("CCY")]
        [StringLength(3)]
        public string Ccy { get; set; }
        [Required]
        [Column("PERIOD")]
        [StringLength(4)]
        public string Period { get; set; }
        [Column("ORDER_BY")]
        public int OrderBy { get; set; }
    }
}
