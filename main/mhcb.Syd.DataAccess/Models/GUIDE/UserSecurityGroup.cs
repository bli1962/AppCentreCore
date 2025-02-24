using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("USER_SECURITY_GROUPS", Schema = "dbo")]
    public partial class UserSecurityGroup
    {
        [Key]
        [Column("USER_ID")]
        [StringLength(8)]
        [Unicode(false)]
        public string UserId { get; set; }
        [Key]
        [Column("SG_IDENTIFIER", TypeName = "decimal(8, 0)")]
        public decimal SgIdentifier { get; set; }
    }
}
