using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("STATUS")]
    public partial class Status
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("CODE")]
        [StringLength(1)]
        public string Code { get; set; }
        [Required]
        [Column("SHORT_DES")]
        [StringLength(10)]
        public string ShortDes { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(30)]
        public string Description { get; set; }
    }
}
