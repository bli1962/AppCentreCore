using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.EDistribution
{
    [Table("Distributions", Schema = "dbo")]
    public partial class Distribution
    {
        [Key]
        public int Id { get; set; }
        public int DocumentId { get; set; }
        [Required]
        [Unicode(false)]
        public string DocumentLocation { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; }
        public short ChannelId { get; set; }
        [Required]
        [Unicode(false)]
        public string DeliveryAddress { get; set; }
        [Required]
        [StringLength(6)]
        [Unicode(false)]
        public string CustomerCode { get; set; }
        [Required]
        [Column("CUST_ABBR")]
        [StringLength(12)]
        [Unicode(false)]
        public string CustAbbr { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Reference { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateAdded { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateAvailable { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateSent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDeleted { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string AddedBy { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string SentBy { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string DeletedBy { get; set; }
        [StringLength(250)]
        public string AssociatedSubject { get; set; }
        [Column(TypeName = "text")]
        public string AssociatedBody { get; set; }

        [ForeignKey("ChannelId")]
        [InverseProperty("Distributions")]
        public virtual Channel Channel { get; set; }
        [ForeignKey("Status")]
        [InverseProperty("Distributions")]
        public virtual DistributionStatus StatusNavigation { get; set; }
    }
}
