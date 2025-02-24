using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("EXCH_OPERATOR")]
    public partial class ExchOperator
    {
        [Key]
        [Column("CCY1")]
        [StringLength(3)]
        public string Ccy1 { get; set; }
        [Key]
        [Column("CCY2")]
        [StringLength(3)]
        public string Ccy2 { get; set; }
        [Column("OPERATOR")]
        [StringLength(1)]
        public string Operator { get; set; }
        [Column("RULES")]
        [StringLength(5)]
        public string Rules { get; set; }
    }
}
