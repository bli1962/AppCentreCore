using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Keyless]
    [Table("PrimeRevenue_Rate")]
    public partial class PrimeRevenueRate
    {
        public int PrimeRevenueRateId { get; set; }
        [Required]
        [StringLength(50)]
        public string Currency { get; set; }
        public int PricingProfileId { get; set; }
        [StringLength(50)]
        public string PricingProfileName { get; set; }
        [Column(TypeName = "decimal(20, 4)")]
        public decimal FiMarginOverBps { get; set; }
        [Column("RIC30Days")]
        [StringLength(50)]
        public string Ric30days { get; set; }
        [Column("RIC60Days")]
        [StringLength(50)]
        public string Ric60days { get; set; }
        [Column("RIC90Days")]
        [StringLength(50)]
        public string Ric90days { get; set; }
        [Column("RIC120Days")]
        [StringLength(50)]
        public string Ric120days { get; set; }
        [Column("RIC150Days")]
        [StringLength(50)]
        public string Ric150days { get; set; }
        [Column("RIC180Days")]
        [StringLength(50)]
        public string Ric180days { get; set; }
        [Column("RIC210Days")]
        [StringLength(50)]
        public string Ric210days { get; set; }
        [Column("RIC240Days")]
        [StringLength(50)]
        public string Ric240days { get; set; }
        [Column("RIC270Days")]
        [StringLength(50)]
        public string Ric270days { get; set; }
        [Column("RIC300Days")]
        [StringLength(50)]
        public string Ric300days { get; set; }
        [Column("RIC330Days")]
        [StringLength(50)]
        public string Ric330days { get; set; }
        [Column("RIC360Days")]
        [StringLength(50)]
        public string Ric360days { get; set; }
    }
}
