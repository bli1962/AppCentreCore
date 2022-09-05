using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("GlinkQueueManagerAction")]
    public partial class GlinkQueueManagerAction
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionDate { get; set; }
        [Required]
        [StringLength(20)]
        public string ActionType { get; set; }
        [Required]
        [StringLength(20)]
        public string ActionObject { get; set; }
        [Required]
        [StringLength(255)]
        public string ActionDescription { get; set; }
    }
}
