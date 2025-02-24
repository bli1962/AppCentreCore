using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("RACF_SYSTEM_ID_HISTORY", Schema = "dbo")]
    public partial class RacfSystemIdHistory
    {
        [Required]
        [Column("ID_TYPE")]
        [StringLength(25)]
        [Unicode(false)]
        public string IdType { get; set; }
        [Required]
        [Column("SYSTEM_ID")]
        [StringLength(8)]
        [Unicode(false)]
        public string SystemId { get; set; }
        [Required]
        [Column("PASSWORD")]
        [StringLength(68)]
        [Unicode(false)]
        public string Password { get; set; }
        [Column("PWD_CREATE_DATE", TypeName = "datetime")]
        public DateTime PwdCreateDate { get; set; }
    }
}
