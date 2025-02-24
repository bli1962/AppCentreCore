using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("AREA_CODE", Schema = "dbo")]
    public partial class AreaCode
    {
        [Key]
        [Column("AREA_CODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string AreaCode1 { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(20)]
        [Unicode(false)]
        public string Description { get; set; }
    }
}
