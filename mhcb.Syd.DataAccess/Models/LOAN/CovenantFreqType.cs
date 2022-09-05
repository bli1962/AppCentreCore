using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("COVENANT_FREQ_TYPE")]
    public partial class CovenantFreqType
    {
        [Key]
        [Column("FREQ_TYPE")]
        public byte FreqType { get; set; }
        [Column("FREQ_DESC")]
        [StringLength(20)]
        public string FreqDesc { get; set; }
        [Column("INTERVAL")]
        public byte? Interval { get; set; }
        [Column("DATE_PART")]
        [StringLength(3)]
        public string DatePart { get; set; }
    }
}
