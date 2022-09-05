using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    public partial class ViewRatesGuideDepositRate
    {
        [Required]
        [Column("CCY")]
        [StringLength(3)]
        public string Ccy { get; set; }
        [Required]
        [Column("PERIOD")]
        [StringLength(4)]
        public string Period { get; set; }
        [Column("RATE", TypeName = "decimal(23, 6)")]
        public decimal? Rate { get; set; }
        [Column("ORDER_BY")]
        public int OrderBy { get; set; }
    }
}
