using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("FEE_TYPE")]
    public partial class FeeType
    {
        [Key]
        [Column("FEE_TYPE")]
        public int FeeType1 { get; set; }
        [Column("FEE_DESC")]
        [StringLength(50)]
        public string FeeDesc { get; set; }
    }
}
