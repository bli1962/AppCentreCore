using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxInboundEvents", Schema = "dbo")]
    public partial class MxInboundEvent
    {
        [Key]
        public int MessageId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Required]
        [Unicode(false)]
        public string MessageXml { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string SendingSystem { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Category { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string EventType { get; set; }
        [Column(TypeName = "date")]
        public DateTime EventDate { get; set; }
        public int StatusId { get; set; }
        [Unicode(false)]
        public string Details { get; set; }
    }
}
