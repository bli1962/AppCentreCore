using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("TRANCHE_MARGIN")]
    public partial class TrancheMargin
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TRANCHE_NO")]
        public int TrancheNo { get; set; }
        [Required]
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Required]
        [Column("RATIO_TYPE")]
        [StringLength(25)]
        public string RatioType { get; set; }
        [Column("RATIO_RANGE")]
        [StringLength(20)]
        public string RatioRange { get; set; }
        [Column("RATIO_MARGIN", TypeName = "decimal(12, 6)")]
        public decimal? RatioMargin { get; set; }
        [Column("LINE_FEE", TypeName = "decimal(12, 6)")]
        public decimal? LineFee { get; set; }
        [Column("COMMITMENT_FEE", TypeName = "decimal(12, 6)")]
        public decimal? CommitmentFee { get; set; }
        [Column("PERFOMANCE_GNTEE", TypeName = "decimal(12, 6)")]
        public decimal? PerfomanceGntee { get; set; }
        [Column("FINANCIAL_GNTEE", TypeName = "decimal(12, 6)")]
        public decimal? FinancialGntee { get; set; }
        [Column("OTHER", TypeName = "decimal(12, 6)")]
        public decimal? Other { get; set; }
        [Column("SELECTED")]
        public bool Selected { get; set; }
        [Column("REMARK")]
        [StringLength(200)]
        public string Remark { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }

        [ForeignKey(nameof(TrancheNo))]
        [InverseProperty(nameof(TrancheMaster.TrancheMargins))]
        public virtual TrancheMaster TrancheNoNavigation { get; set; }
    }
}
