using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GBase_rate_conversion_by_CCY_pair", Schema = "dbo")]
    public partial class GbaseRateConversionByCcyPair
    {
        [Required]
        [Column("CCY1")]
        [StringLength(3)]
        [Unicode(false)]
        public string Ccy1 { get; set; }
        [Required]
        [Column("CCY2")]
        [StringLength(3)]
        [Unicode(false)]
        public string Ccy2 { get; set; }
        [Required]
        [Column("Deal_type")]
        [StringLength(30)]
        [Unicode(false)]
        public string DealType { get; set; }
    }
}
