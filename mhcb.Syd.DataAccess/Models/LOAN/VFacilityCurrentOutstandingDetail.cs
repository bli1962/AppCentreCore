using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    public partial class VFacilityCurrentOutstandingDetail
    {
        [Required]
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("TRANS_NO")]
        public int TransNo { get; set; }
        [Column("ccy_code")]
        [StringLength(3)]
        public string CcyCode { get; set; }
        [Column("DRAW_AMT", TypeName = "decimal(27, 4)")]
        public decimal? DrawAmt { get; set; }
        [Column("REPAY_AMT", TypeName = "decimal(27, 4)")]
        public decimal? RepayAmt { get; set; }
        [Column("exch_ind")]
        [StringLength(1)]
        public string ExchInd { get; set; }
        [Column("exch_rate", TypeName = "decimal(38, 13)")]
        public decimal? ExchRate { get; set; }
        [Column("Start_Date", TypeName = "datetime")]
        public DateTime StartDate { get; set; }
    }
}
