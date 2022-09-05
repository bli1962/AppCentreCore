using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxInboundEventLog")]
    public partial class MxInboundEventLog
    {
        [Key]
        public int LogId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Required]
        [StringLength(20)]
        public string LogLevel { get; set; }
        [Required]
        [StringLength(50)]
        public string Logger { get; set; }
        [StringLength(20)]
        public string EventId { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        public string Description { get; set; }
        public string Exception { get; set; }
    }
}
