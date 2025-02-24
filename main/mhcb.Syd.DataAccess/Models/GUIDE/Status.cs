using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("STATUS", Schema = "dbo")]
    public partial class Status
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("CODE")]
        [StringLength(1)]
        [Unicode(false)]
        public string Code { get; set; }
        [Required]
        [Column("SHORT_DES")]
        [StringLength(10)]
        [Unicode(false)]
        public string ShortDes { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(30)]
        [Unicode(false)]
        public string Description { get; set; }
    }
}
