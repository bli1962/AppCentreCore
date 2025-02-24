using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.EDistribution
{
    [Table("GenericFtpLog", Schema = "dbo")]
    public partial class GenericFtpLog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Client { get; set; }
        [Required]
        [Unicode(false)]
        public string SourceLocation { get; set; }
        [Required]
        [Unicode(false)]
        public string DestinationLocation { get; set; }
        [Required]
        [StringLength(1000)]
        [Unicode(false)]
        public string Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateAdded { get; set; }
        public int DirectionId { get; set; }

        [ForeignKey("DirectionId")]
        [InverseProperty("GenericFtpLogs")]
        public virtual GenericFtpDirection Direction { get; set; }
    }
}
