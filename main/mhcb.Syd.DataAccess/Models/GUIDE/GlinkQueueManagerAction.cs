using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("GlinkQueueManagerAction", Schema = "dbo")]
    public partial class GlinkQueueManagerAction
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionDate { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string ActionType { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string ActionObject { get; set; }
        [Required]
        [StringLength(255)]
        [Unicode(false)]
        public string ActionDescription { get; set; }
    }
}
