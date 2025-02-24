using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("RptGlobalTradeFinanceLCR_Summary")]
    public partial class RptGlobalTradeFinanceLcrSummary
    {
        [Column("RPT_GTF_LCR_Summary_ID")]
        public int RptGtfLcrSummaryId { get; set; }
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime DataDate { get; set; }
        [Column("UPLOAD_DATE", TypeName = "datetime")]
        public DateTime UploadDate { get; set; }
        [Required]
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Required]
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal SumOfBalance { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal MonthlyBalanceMovement { get; set; }
    }
}
