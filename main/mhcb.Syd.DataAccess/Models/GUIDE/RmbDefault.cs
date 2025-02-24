using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("RMB_Default", Schema = "dbo")]
    public partial class RmbDefault
    {
        [Column("CCY")]
        [StringLength(3)]
        [Unicode(false)]
        public string Ccy { get; set; }
        [Column("defult_flg")]
        public bool? DefultFlg { get; set; }
        [Column("Rate_to_Use")]
        public bool? RateToUse { get; set; }
    }
}
