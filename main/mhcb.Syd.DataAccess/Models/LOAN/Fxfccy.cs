using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("FXFCCY")]
    public partial class Fxfccy
    {
        [Key]
        [Column("CCY")]
        [StringLength(3)]
        public string Ccy { get; set; }
        [Column("CCYDESC")]
        [StringLength(50)]
        public string Ccydesc { get; set; }
        [Column("DAYS")]
        public short? Days { get; set; }
        [Column("DIRECT")]
        public bool? Direct { get; set; }
        [Column("CCY_CD")]
        [StringLength(8)]
        public string CcyCd { get; set; }
    }
}
