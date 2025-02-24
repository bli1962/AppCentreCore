using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DISTRIBUTION_TYPE", Schema = "dbo")]
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
        [Unicode(false)]
        public string DistributionType1 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string VisableToSystem { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string DefaultDistributionStatus { get; set; }
        [Unicode(false)]
        public string TemplateName { get; set; }

        [InverseProperty("DistributionTypeNavigation")]
        public virtual ICollection<DistributionPreference> DistributionPreferences { get; set; }
    }
}
