using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.EDistribution
{
    [Table("GenericFtpDirection", Schema = "dbo")]
    public partial class GenericFtpDirection
    {
        public GenericFtpDirection()
        {
            GenericFtpConfigs = new HashSet<GenericFtpConfig>();
            GenericFtpLogs = new HashSet<GenericFtpLog>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        [Unicode(false)]
        public string Description { get; set; }

        [InverseProperty("Direction")]
        public virtual ICollection<GenericFtpConfig> GenericFtpConfigs { get; set; }
        [InverseProperty("Direction")]
        public virtual ICollection<GenericFtpLog> GenericFtpLogs { get; set; }
    }
}
