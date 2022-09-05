using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("INT_CALC_TYPE")]
    public partial class IntCalcType
    {
        [Key]
        [Column("INT_CALC_TYPE")]
        public short IntCalcType1 { get; set; }
        [Required]
        [Column("INT_CALC_DESC")]
        [StringLength(10)]
        public string IntCalcDesc { get; set; }
    }
}
