using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.EDistribution
{
    [Table("Channel", Schema = "dbo")]
    public partial class Channel
    {
        public Channel()
        {
            Distributions = new HashSet<Distribution>();
        }

        [Key]
        public short Id { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Description { get; set; }
        public bool Active { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Notes { get; set; }

        [InverseProperty("Channel")]
        public virtual ICollection<Distribution> Distributions { get; set; }
    }
}
