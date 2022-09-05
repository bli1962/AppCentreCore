using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DISTRIBUTION_PREFERENCE")]
    public partial class DistributionPreference
    {
        [Key]
        public int Id { get; set; }
        [StringLength(6)]
        public string CustomerCode { get; set; }
        [StringLength(3)]
        public string CustomerBranch { get; set; }
        [StringLength(12)]
        public string CustomerAbbr { get; set; }
        public int DistributionType { get; set; }
        public int DistributionChannel { get; set; }
        [Required]
        [StringLength(500)]
        public string Address { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        [Required]
        [StringLength(8)]
        public string AddedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime AddedOn { get; set; }
        [StringLength(8)]
        public string AuthorisedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AuthorisedOn { get; set; }
        [StringLength(8)]
        public string ModifiedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifiedOn { get; set; }

        [ForeignKey(nameof(DistributionChannel))]
        [InverseProperty("DistributionPreferences")]
        public virtual DistributionChannel DistributionChannelNavigation { get; set; }
        [ForeignKey(nameof(DistributionType))]
        [InverseProperty("DistributionPreferences")]
        public virtual DistributionType DistributionTypeNavigation { get; set; }
    }
}
