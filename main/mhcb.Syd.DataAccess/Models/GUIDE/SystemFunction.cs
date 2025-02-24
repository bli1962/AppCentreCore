using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SYSTEM_FUNCTIONS", Schema = "dbo")]
    public partial class SystemFunction
    {
        [Key]
        [Column("IDENTIFIER", TypeName = "decimal(5, 0)")]
        public decimal Identifier { get; set; }
        [Required]
        [Column("DESCRIPTION")]
        [StringLength(255)]
        [Unicode(false)]
        public string Description { get; set; }
    }
}
