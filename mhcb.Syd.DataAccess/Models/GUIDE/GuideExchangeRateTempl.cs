using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GUIDE_EXCHANGE_RATE_TEMPL")]
    public partial class GuideExchangeRateTempl
    {
        [Required]
        [Column("CCY")]
        [StringLength(3)]
        public string Ccy { get; set; }
        [Column("MUREX_LABLE")]
        [StringLength(15)]
        public string MurexLable { get; set; }
        public bool? Direction { get; set; }
    }
}
