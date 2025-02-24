using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("GUARANTEE_FEE_TYPE")]
    public partial class GuaranteeFeeType
    {
        [Key]
        [Column("GUARANTEE_FEE_TYPE")]
        public short GuaranteeFeeType1 { get; set; }
        [Column("GUARANTEE_FEE_DESC")]
        [StringLength(10)]
        public string GuaranteeFeeDesc { get; set; }
    }
}
