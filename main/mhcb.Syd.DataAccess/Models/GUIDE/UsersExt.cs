using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("USERS_Ext", Schema = "dbo")]
    public partial class UsersExt
    {
        [Key]
        [Column("USER_ID")]
        [StringLength(20)]
        [Unicode(false)]
        public string UserId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string NetworkId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("UsersExt")]
        public virtual User User { get; set; }
    }
}
