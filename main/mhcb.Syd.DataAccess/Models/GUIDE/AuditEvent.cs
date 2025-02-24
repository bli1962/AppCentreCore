using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("AUDIT_EVENTS", Schema = "dbo")]
    public partial class AuditEvent
    {
        [Key]
        [Column("IDENTIFIER", TypeName = "decimal(5, 0)")]
        public decimal Identifier { get; set; }
        [Required]
        [Column("DESCRIPTION")]
        [StringLength(50)]
        [Unicode(false)]
        public string Description { get; set; }
        [Column("EXCEPTION_FLAG")]
        [StringLength(1)]
        [Unicode(false)]
        public string ExceptionFlag { get; set; }
    }
}
