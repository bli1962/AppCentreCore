using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("AREA_CODE")]
    public partial class AreaCode
    {
        [Key]
        [Column("AREA_CODE")]
        [StringLength(2)]
        public string AreaCode1 { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(20)]
        public string Description { get; set; }
    }
}
