using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("EXCH_RATE")]
    public partial class ExchRate
    {
        [Key]
        [Column("CCY_CODE")]
        [StringLength(3)]
        public string CcyCode { get; set; }
        [Column("DKB_SPECIAL_RATE_USD", TypeName = "decimal(18, 6)")]
        public decimal? DkbSpecialRateUsd { get; set; }
    }
}
