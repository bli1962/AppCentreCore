using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("USERS_Ext")]
    public partial class UsersExt
    {
        [Key]
        [Column("USER_ID")]
        [StringLength(20)]
        public string UserId { get; set; }
        [StringLength(255)]
        public string NetworkId { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("UsersExt")]
        public virtual User User { get; set; }
    }
}
