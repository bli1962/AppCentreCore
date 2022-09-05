using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("USER_SECURITY_GROUPS")]
    public partial class UserSecurityGroup
    {
        [Key]
        [Column("USER_ID")]
        [StringLength(8)]
        public string UserId { get; set; }
        [Key]
        [Column("SG_IDENTIFIER", TypeName = "decimal(8, 0)")]
        public decimal SgIdentifier { get; set; }
    }
}
