using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    public partial class VLoanTransLive
    {
        [Required]
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("TRANS_NO")]
        public int TransNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("Base_CCY")]
        [StringLength(3)]
        public string BaseCcy { get; set; }
        [Column("DRAW_CCY")]
        [StringLength(3)]
        public string DrawCcy { get; set; }
        [Column("DRAW_AMT", TypeName = "decimal(27, 4)")]
        public decimal? DrawAmt { get; set; }
        [Column("DRAW_EQUIV", TypeName = "decimal(38, 6)")]
        public decimal? DrawEquiv { get; set; }
        [Column("DRAW_EXCH_RATE_IND")]
        [StringLength(1)]
        public string DrawExchRateInd { get; set; }
        [Column("DRAW_EXCH_RATE", TypeName = "decimal(38, 13)")]
        public decimal? DrawExchRate { get; set; }
        [Column("REPAY_CCY")]
        [StringLength(3)]
        public string RepayCcy { get; set; }
        [Column("REPAY_AMT", TypeName = "decimal(27, 4)")]
        public decimal? RepayAmt { get; set; }
        [Column("REPAY_EQUIV", TypeName = "decimal(38, 6)")]
        public decimal? RepayEquiv { get; set; }
        [Column("REPAY_EXCH_RATE_IND")]
        [StringLength(1)]
        public string RepayExchRateInd { get; set; }
        [Column("REPAY_EXCH_RATE", TypeName = "decimal(38, 13)")]
        public decimal? RepayExchRate { get; set; }
        [Column("Original_DRAW_EQUIV", TypeName = "decimal(27, 4)")]
        public decimal? OriginalDrawEquiv { get; set; }
        [Column("Original_DRAW_EXCH_RATE", TypeName = "decimal(18, 6)")]
        public decimal? OriginalDrawExchRate { get; set; }
        [Column("Original_DRAW_EXCH_IND")]
        [StringLength(1)]
        public string OriginalDrawExchInd { get; set; }
        [Column("Original_REPAY_EQUIV", TypeName = "decimal(27, 4)")]
        public decimal? OriginalRepayEquiv { get; set; }
        [Column("Original_REPAY_EXCH_RATE", TypeName = "decimal(18, 6)")]
        public decimal? OriginalRepayExchRate { get; set; }
        [Column("Original_REPAY_EXCH_IND")]
        [StringLength(1)]
        public string OriginalRepayExchInd { get; set; }
        [Column("RO_NO")]
        public int? RoNo { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("START_DATE", TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column("DUE_DATE", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("DAYS")]
        public int? Days { get; set; }
        [Column("BAL_AMT", TypeName = "decimal(27, 4)")]
        public decimal? BalAmt { get; set; }
        [Column("INT_RATE", TypeName = "decimal(18, 6)")]
        public decimal? IntRate { get; set; }
        [Column("BASE_RATE", TypeName = "decimal(18, 6)")]
        public decimal? BaseRate { get; set; }
        [Column("INT_AMT", TypeName = "decimal(27, 4)")]
        public decimal? IntAmt { get; set; }
        [Column("INT_AMT_CALC", TypeName = "decimal(27, 4)")]
        public decimal? IntAmtCalc { get; set; }
        [Column("INC_START_DATE")]
        public bool? IncStartDate { get; set; }
        [Column("INC_DUE_DATE")]
        public bool? IncDueDate { get; set; }
        [Column("INT_RECV_DATE")]
        [StringLength(10)]
        public string IntRecvDate { get; set; }
        [Column("INT_RECV_BY")]
        [StringLength(6)]
        public string IntRecvBy { get; set; }
        [Column("REMARKS")]
        [StringLength(100)]
        public string Remarks { get; set; }
        [Column("CREATE_DATE", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("PROC_BY1")]
        [StringLength(6)]
        public string ProcBy1 { get; set; }
        [Column("PROC_BY2")]
        [StringLength(6)]
        public string ProcBy2 { get; set; }
        [Column("CHK_BY")]
        [StringLength(6)]
        public string ChkBy { get; set; }
        [Column("APPR_BY1")]
        [StringLength(6)]
        public string ApprBy1 { get; set; }
        [Column("APPR_BY2")]
        [StringLength(6)]
        public string ApprBy2 { get; set; }
        [Column("FLAG_DEL_BY")]
        [StringLength(6)]
        public string FlagDelBy { get; set; }
        [Column("MRU")]
        public int Mru { get; set; }
    }
}
