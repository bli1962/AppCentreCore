using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("RACF_SYSTEM_ID_HISTORY")]
    public partial class RacfSystemIdHistory
    {
        [Required]
        [Column("ID_TYPE")]
        [StringLength(25)]
        public string IdType { get; set; }
        [Required]
        [Column("SYSTEM_ID")]
        [StringLength(8)]
        public string SystemId { get; set; }
        [Required]
        [Column("PASSWORD")]
        [StringLength(68)]
        public string Password { get; set; }
        [Column("PWD_CREATE_DATE", TypeName = "datetime")]
        public DateTime PwdCreateDate { get; set; }
    }
}
