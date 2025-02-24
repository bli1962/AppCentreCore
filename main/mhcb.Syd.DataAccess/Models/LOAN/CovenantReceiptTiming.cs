using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("COVENANT_RECEIPT_TIMING")]
    public partial class CovenantReceiptTiming
    {
        [Key]
        [Column("TIMING_TYPE")]
        public byte TimingType { get; set; }
        [Required]
        [Column("TIMING_DESC")]
        [StringLength(10)]
        public string TimingDesc { get; set; }
        [Column("INTERVAL")]
        public byte Interval { get; set; }
        [Required]
        [Column("DATE_PART")]
        [StringLength(3)]
        public string DatePart { get; set; }
        [Column("ORDER")]
        public byte Order { get; set; }
    }
}
