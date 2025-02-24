using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.EDistribution
{
    [Table("DistributionStatus", Schema = "dbo")]
    public partial class DistributionStatus
    {
        public DistributionStatus()
        {
            Distributions = new HashSet<Distribution>();
        }

        [Key]
        [StringLength(1)]
        [Unicode(false)]
        public string Id { get; set; }
        [Required]
        [StringLength(25)]
        [Unicode(false)]
        public string Description { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string Notes { get; set; }

        [InverseProperty("StatusNavigation")]
        public virtual ICollection<Distribution> Distributions { get; set; }
    }
}
