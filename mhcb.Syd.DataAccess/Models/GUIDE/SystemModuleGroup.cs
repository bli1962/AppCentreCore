using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SYSTEM_MODULE_GROUPS")]
    public partial class SystemModuleGroup
    {
        [Key]
        [Column("SM_IDENTIFIER", TypeName = "decimal(8, 0)")]
        public decimal SmIdentifier { get; set; }
        [Key]
        [Column("SG_IDENTIFIER", TypeName = "decimal(8, 0)")]
        public decimal SgIdentifier { get; set; }
    }
}
