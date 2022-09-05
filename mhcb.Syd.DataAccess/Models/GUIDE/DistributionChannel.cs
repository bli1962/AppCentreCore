using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DISTRIBUTION_CHANNEL")]
    public partial class DistributionChannel
    {
        public DistributionChannel()
        {
            DistributionPreferences = new HashSet<DistributionPreference>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Channel { get; set; }

        [InverseProperty(nameof(DistributionPreference.DistributionChannelNavigation))]
        public virtual ICollection<DistributionPreference> DistributionPreferences { get; set; }
    }
}
