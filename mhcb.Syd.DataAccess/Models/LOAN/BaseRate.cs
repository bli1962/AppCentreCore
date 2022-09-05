using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("BASE_RATE")]
    public partial class BaseRate
    {
        [Key]
        [Column("RATE_TYPE")]
        [StringLength(10)]
        public string RateType { get; set; }
        [Column("RATE_DESC")]
        [StringLength(50)]
        public string RateDesc { get; set; }
    }
}
