using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxInboundMessageStatus", Schema = "dbo")]
    public partial class MxInboundMessageStatus
    {
        [Key]
        public int StatusId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string StatusName { get; set; }
    }
}
