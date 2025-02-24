using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FXFCUSTThreshold", Schema = "dbo")]
    public partial class Fxfcustthreshold
    {
        [Key]
        [StringLength(6)]
        [Unicode(false)]
        public string Code { get; set; }
        [Required]
        [Column("CCY")]
        [StringLength(3)]
        [Unicode(false)]
        public string Ccy { get; set; }
        [Required]
        [StringLength(12)]
        [Unicode(false)]
        public string AccountNo { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Amount { get; set; }
    }
}
