using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("RAM_RECON_SUMMARY")]
    public partial class RamReconSummary
    {
        [Required]
        [Column("KIND")]
        [StringLength(5)]
        public string Kind { get; set; }
        [Required]
        [Column("CCY")]
        [StringLength(4)]
        public string Ccy { get; set; }
        [Column("GUIDE_NOS")]
        public int? GuideNos { get; set; }
        [Column("GUIDE_AMOUNT", TypeName = "decimal(18, 5)")]
        public decimal? GuideAmount { get; set; }
        [Column("GUIDE_FORMATTED_AMT")]
        [StringLength(30)]
        public string GuideFormattedAmt { get; set; }
        [Required]
        [Column("RAM_TYPE_CODE")]
        [StringLength(15)]
        public string RamTypeCode { get; set; }
        [Column("GBASE_TOTAL")]
        public int? GbaseTotal { get; set; }
        [Column("DEPARTMENT")]
        [StringLength(100)]
        public string Department { get; set; }
        [Column("BRANCH")]
        [StringLength(8)]
        public string Branch { get; set; }
        [Column("GBASE_APPROVED_AMT", TypeName = "decimal(18, 5)")]
        public decimal? GbaseApprovedAmt { get; set; }
        [Column("GBASE_FORMATTED_AMT")]
        [StringLength(30)]
        public string GbaseFormattedAmt { get; set; }
        [Column("GBASE_DELETE_TOTAL")]
        public int? GbaseDeleteTotal { get; set; }
        [Column("FXALM_COUNT")]
        public int? FxalmCount { get; set; }
        [Column("FXALM_AMT", TypeName = "decimal(18, 5)")]
        public decimal? FxalmAmt { get; set; }
        [Column("FXALM_FORMATTED_AMT")]
        [StringLength(30)]
        public string FxalmFormattedAmt { get; set; }
        [Column("COMPARERKEY")]
        [StringLength(15)]
        public string Comparerkey { get; set; }
        [Column("COMPAREFKEY")]
        [StringLength(15)]
        public string Comparefkey { get; set; }
    }
}
