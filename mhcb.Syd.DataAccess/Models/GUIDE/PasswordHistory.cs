using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PASSWORD_HISTORY")]
    public partial class PasswordHistory
    {
        [Key]
        [Column("USER_ID")]
        [StringLength(8)]
        public string UserId { get; set; }
        [Key]
        [Column("PASSWORD")]
        [StringLength(68)]
        public string Password { get; set; }
        [Key]
        [Column("PWD_CHANGE_DT", TypeName = "datetime")]
        public DateTime PwdChangeDt { get; set; }
        [Column("SECURITY_FLAG")]
        [StringLength(1)]
        public string SecurityFlag { get; set; }
    }
}
