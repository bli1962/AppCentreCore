using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    public partial class VRsDetOutstandingBalAndAccruedInt
    {
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        public short? Product { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("CUST_NAME")]
        [StringLength(40)]
        public string CustName { get; set; }
        [Column("Base Ccy")]
        [StringLength(3)]
        public string BaseCcy { get; set; }
        [Required]
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [StringLength(3)]
        public string Ccy { get; set; }
        [Column(TypeName = "decimal(28, 4)")]
        public decimal? Amount { get; set; }
        [Column("Equiv Amount", TypeName = "decimal(38, 6)")]
        public decimal? EquivAmount { get; set; }
        [Column("DRAW_AMT", TypeName = "decimal(27, 4)")]
        public decimal? DrawAmt { get; set; }
        [Column("REPAY_AMT", TypeName = "decimal(27, 4)")]
        public decimal? RepayAmt { get; set; }
        [Column("TRANS_NO")]
        public int TransNo { get; set; }
        [Column("START_DATE", TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column("DUE_DATE", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("DAYS")]
        public int? Days { get; set; }
        [Column("RO_NO")]
        public int? RoNo { get; set; }
        [Column("Accrued Int", TypeName = "decimal(27, 4)")]
        public decimal? AccruedInt { get; set; }
        [Column("INT_RATE", TypeName = "decimal(18, 6)")]
        public decimal? IntRate { get; set; }
    }
}
