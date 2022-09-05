using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("AUDIT_EVENTS")]
    public partial class AuditEvent
    {
        [Key]
        [Column("IDENTIFIER", TypeName = "decimal(5, 0)")]
        public decimal Identifier { get; set; }
        [Required]
        [Column("DESCRIPTION")]
        [StringLength(50)]
        public string Description { get; set; }
        [Column("EXCEPTION_FLAG")]
        [StringLength(1)]
        public string ExceptionFlag { get; set; }
    }
}
