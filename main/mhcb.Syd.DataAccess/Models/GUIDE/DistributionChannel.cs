using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DISTRIBUTION_CHANNEL", Schema = "dbo")]
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
        [Unicode(false)]
        public string Channel { get; set; }

        [InverseProperty("DistributionChannelNavigation")]
        public virtual ICollection<DistributionPreference> DistributionPreferences { get; set; }
    }
}
