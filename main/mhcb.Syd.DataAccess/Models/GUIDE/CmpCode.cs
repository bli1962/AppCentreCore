using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("CMP_CODE", Schema = "dbo")]
    public partial class CmpCode
    {
        [Key]
        [Column("CMP_CODE")]
        public short CmpCode1 { get; set; }
        [Column("CMP_ABBR")]
        [StringLength(10)]
        [Unicode(false)]
        public string CmpAbbr { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(50)]
        [Unicode(false)]
        public string Description { get; set; }
    }
}
