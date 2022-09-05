using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    public partial class ViewRatesGuideBisRate
    {
        [Required]
        [Column("CCY")]
        [StringLength(3)]
        public string Ccy { get; set; }
        [Column("DURATION")]
        public int Duration { get; set; }
        [Required]
        [Column("DURATION_UNIT")]
        [StringLength(5)]
        public string DurationUnit { get; set; }
        [Column("BID_RATE", TypeName = "decimal(23, 6)")]
        public decimal? BidRate { get; set; }
        [Column("OFFER_RATE", TypeName = "decimal(23, 6)")]
        public decimal? OfferRate { get; set; }
        [Column("BASE_RATE", TypeName = "decimal(26, 8)")]
        public decimal? BaseRate { get; set; }
        [Column("ORDER_BY")]
        public int OrderBy { get; set; }
    }
}
