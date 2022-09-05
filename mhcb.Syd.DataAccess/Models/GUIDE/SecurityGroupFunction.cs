using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SECURITY_GROUP_FUNCTIONS")]
    public partial class SecurityGroupFunction
    {
        [Key]
        [Column("SG_IDENTIFIER", TypeName = "decimal(8, 0)")]
        public decimal SgIdentifier { get; set; }
        [Key]
        [Column("SF_IDENTIFIER", TypeName = "decimal(8, 0)")]
        public decimal SfIdentifier { get; set; }
    }
}
