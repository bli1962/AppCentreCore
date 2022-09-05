using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("SWIFT_INF")]
    public partial class SwiftInf
    {
        [Key]
        [Column("CCY")]
        [StringLength(3)]
        public string Ccy { get; set; }
        [Column("PAY_TO")]
        [StringLength(50)]
        public string PayTo { get; set; }
        [Column("FOR_ACC_OF")]
        [StringLength(50)]
        public string ForAccOf { get; set; }
        [Column("SWIFT_CODE")]
        [StringLength(20)]
        public string SwiftCode { get; set; }
        [Column("SWIFT_NO")]
        [StringLength(20)]
        public string SwiftNo { get; set; }
        [Column("ACC_NO")]
        [StringLength(50)]
        public string AccNo { get; set; }
    }
}
