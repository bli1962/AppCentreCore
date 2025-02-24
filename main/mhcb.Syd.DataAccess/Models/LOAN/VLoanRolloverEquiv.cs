using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    public partial class VLoanRolloverEquiv
    {
        [Required]
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("Repay_Amt", TypeName = "decimal(38, 4)")]
        public decimal? RepayAmt { get; set; }
        [Column("REPAY_EQUIV", TypeName = "decimal(38, 4)")]
        public decimal? RepayEquiv { get; set; }
        [Column("DRAW_AMT", TypeName = "decimal(38, 4)")]
        public decimal? DrawAmt { get; set; }
        [Column("DRAW_EQUIV", TypeName = "decimal(38, 4)")]
        public decimal? DrawEquiv { get; set; }
        [Column("RO_NO")]
        public int? RoNo { get; set; }
    }
}
