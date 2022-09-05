using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MUREX_RATE_EXPORT_CONTROL")]
    public partial class MurexRateExportControl
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("RUN")]
        public bool? Run { get; set; }
    }
}
