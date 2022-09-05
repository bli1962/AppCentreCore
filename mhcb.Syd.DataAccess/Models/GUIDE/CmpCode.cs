using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("CMP_CODE")]
    public partial class CmpCode
    {
        [Key]
        [Column("CMP_CODE")]
        public short CmpCode1 { get; set; }
        [Column("CMP_ABBR")]
        [StringLength(10)]
        public string CmpAbbr { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
