using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SYSTEM_FUNCTIONS")]
    public partial class SystemFunction
    {
        [Key]
        [Column("IDENTIFIER", TypeName = "decimal(5, 0)")]
        public decimal Identifier { get; set; }
        [Required]
        [Column("DESCRIPTION")]
        [StringLength(255)]
        public string Description { get; set; }
    }
}
