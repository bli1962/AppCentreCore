using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("REPAY_TYPE")]
    public partial class RepayType
    {
        [Key]
        [Column("REPAY_TYPE")]
        public short RepayType1 { get; set; }
        [Column("REPAY_DESC")]
        [StringLength(20)]
        public string RepayDesc { get; set; }
    }
}
