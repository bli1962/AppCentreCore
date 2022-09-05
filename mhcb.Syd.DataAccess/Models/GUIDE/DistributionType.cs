using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DISTRIBUTION_TYPE")]
    public partial class DistributionType
    {
        public DistributionType()
        {
            DistributionPreferences = new HashSet<DistributionPreference>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [Column("DistributionType")]
        [StringLength(50)]
        public string DistributionType1 { get; set; }
        [StringLength(50)]
        public string VisableToSystem { get; set; }
        [StringLength(1)]
        public string DefaultDistributionStatus { get; set; }
        public string TemplateName { get; set; }

        [InverseProperty(nameof(DistributionPreference.DistributionTypeNavigation))]
        public virtual ICollection<DistributionPreference> DistributionPreferences { get; set; }
    }
}
