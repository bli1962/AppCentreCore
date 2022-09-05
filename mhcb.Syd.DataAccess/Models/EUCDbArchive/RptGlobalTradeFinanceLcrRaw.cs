using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("RptGlobalTradeFinanceLCR_Raw")]
    public partial class RptGlobalTradeFinanceLcrRaw
    {
        [Column("RPT_GTF_LCR_ID")]
        public int RptGtfLcrId { get; set; }
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime DataDate { get; set; }
        [Column("UPLOAD_DATE", TypeName = "datetime")]
        public DateTime UploadDate { get; set; }
        [Required]
        [Column("Gbase_RefType")]
        [StringLength(3)]
        public string GbaseRefType { get; set; }
        [Required]
        [Column("Ref_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
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
    }
}
