using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxInboundEventLog", Schema = "dbo")]
    public partial class MxInboundEventLog
    {
        [Key]
        public int LogId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string LogLevel { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Logger { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string EventId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Status { get; set; }
        [Unicode(false)]
        public string Description { get; set; }
        [Unicode(false)]
        public string Exception { get; set; }
    }
}
