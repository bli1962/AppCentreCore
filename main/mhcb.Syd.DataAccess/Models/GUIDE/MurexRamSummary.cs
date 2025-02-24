using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("MUREX_RAM_SUMMARY", Schema = "dbo")]
    public partial class MurexRamSummary
    {
        [Required]
        [Column("KIND")]
        [StringLength(3)]
        [Unicode(false)]
        public string Kind { get; set; }
        [Required]
        [Column("CCY")]
        [StringLength(3)]
        [Unicode(false)]
        public string Ccy { get; set; }
        [Column("NOS")]
        public int Nos { get; set; }
        [Column("AMOUNT", TypeName = "decimal(27, 4)")]
        public decimal Amount { get; set; }
    }
}
