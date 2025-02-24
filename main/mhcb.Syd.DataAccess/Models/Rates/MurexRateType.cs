using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Keyless]
    [Table("Murex_Rate_Types")]
    public partial class MurexRateType
    {
        [Column("RateID")]
        public int RateId { get; set; }
        [StringLength(10)]
        public string MurexRateCode { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        public bool? Active { get; set; }
    }
}
