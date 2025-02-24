using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    public partial class ViewEucLoantrans2
    {
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("TRANS_NO")]
        [StringLength(3)]
        public string TransNo { get; set; }
        [Column("DD_DATE", TypeName = "datetime")]
        public DateTime? DdDate { get; set; }
        [Column("START_DATE", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Required]
        [Column("APPR_BY1")]
        [StringLength(6)]
        public string ApprBy1 { get; set; }
        [Required]
        [Column("APPR_BY2")]
        [StringLength(6)]
        public string ApprBy2 { get; set; }
        [Required]
        [Column("PROC_BY1")]
        [StringLength(6)]
        public string ProcBy1 { get; set; }
        [Column("DRAW_CCY")]
        [StringLength(4000)]
        public string DrawCcy { get; set; }
        [Column("DRAW_AMT", TypeName = "decimal(18, 3)")]
        public decimal? DrawAmt { get; set; }
        [Column("DRAW_EQUIV", TypeName = "decimal(18, 3)")]
        public decimal? DrawEquiv { get; set; }
        [Column("REPAY_CCY")]
        [StringLength(4000)]
        public string RepayCcy { get; set; }
        [Column("REPAY_AMT")]
        public int RepayAmt { get; set; }
        [Column("REPAY_EQUIV")]
        public int RepayEquiv { get; set; }
        [Column("DUE_DATE", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("DAYS")]
        public int? Days { get; set; }
        [Column("INT RATE", TypeName = "decimal(9, 6)")]
        public decimal? IntRate { get; set; }
        [Column("BASE_RATE", TypeName = "decimal(9, 6)")]
        public decimal? BaseRate { get; set; }
        [Column("BAL_AMT", TypeName = "decimal(18, 3)")]
        public decimal? BalAmt { get; set; }
        [Column("BAL_EQUIV")]
        public int BalEquiv { get; set; }
        [Required]
        [Column("DRAW_EXCH_RATE_IND")]
        [StringLength(1)]
        public string DrawExchRateInd { get; set; }
        [Column("DRAW_EXCH_RATE", TypeName = "decimal(38, 20)")]
        public decimal? DrawExchRate { get; set; }
        [Required]
        [Column("REPAY_EXCH_RATE_IND")]
        [StringLength(1)]
        public string RepayExchRateInd { get; set; }
        [Column("REPAY_EXCH_RATE", TypeName = "decimal(38, 20)")]
        public decimal? RepayExchRate { get; set; }
        [Column("INT_AMT", TypeName = "decimal(18, 3)")]
        public decimal? IntAmt { get; set; }
        [Column("INT_AMT_CALC", TypeName = "decimal(18, 3)")]
        public decimal? IntAmtCalc { get; set; }
        [Required]
        [Column("INT_RECV_DATE")]
        [StringLength(1)]
        public string IntRecvDate { get; set; }
        [Required]
        [Column("INT_RECV_BY")]
        [StringLength(1)]
        public string IntRecvBy { get; set; }
        [Required]
        [Column("REMARKS")]
        [StringLength(1)]
        public string Remarks { get; set; }
        [Required]
        [Column("PROC_BY2")]
        [StringLength(6)]
        public string ProcBy2 { get; set; }
        [Required]
        [Column("CHK_BY")]
        [StringLength(6)]
        public string ChkBy { get; set; }
        [Column("INC_DUE_DATE")]
        public int IncDueDate { get; set; }
    }
}
