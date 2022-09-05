using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    public partial class MxInboundEvent
    {
        [Key]
        public int MessageId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Required]
        public string MessageXml { get; set; }
        [Required]
        [StringLength(50)]
        public string SendingSystem { get; set; }
        [Required]
        [StringLength(50)]
        public string Category { get; set; }
        [Required]
        [StringLength(50)]
        public string EventType { get; set; }
        [Column(TypeName = "date")]
        public DateTime EventDate { get; set; }
        public int StatusId { get; set; }
        public string Details { get; set; }
    }
}
