using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DISTRIBUTION_PREFERENCE", Schema = "dbo")]
    public partial class DistributionPreference
    {
        [Key]
        public int Id { get; set; }
        [StringLength(6)]
        [Unicode(false)]
        public string CustomerCode { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string CustomerBranch { get; set; }
        [StringLength(12)]
        [Unicode(false)]
        public string CustomerAbbr { get; set; }
        public int DistributionType { get; set; }
        public int DistributionChannel { get; set; }
        [Required]
        [StringLength(500)]
        public string Address { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; }
        [Required]
        [StringLength(8)]
        [Unicode(false)]
        public string AddedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime AddedOn { get; set; }
        [StringLength(8)]
        [Unicode(false)]
        public string AuthorisedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AuthorisedOn { get; set; }
        [StringLength(8)]
        [Unicode(false)]
        public string ModifiedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifiedOn { get; set; }

        [ForeignKey("DistributionChannel")]
        [InverseProperty("DistributionPreferences")]
        public virtual DistributionChannel DistributionChannelNavigation { get; set; }
        [ForeignKey("DistributionType")]
        [InverseProperty("DistributionPreferences")]
        public virtual DistributionType DistributionTypeNavigation { get; set; }
    }
}
