using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T07_CCY_CONVERSION_RATE_TABLE", Schema = "EUC")]
    public partial class T07CcyConversionRateTable
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("QUOTATION")]
        [StringLength(1)]
        public string Quotation { get; set; }
        [Column("ODD_CONVERSION_RATE", TypeName = "decimal(9, 5)")]
        public decimal? OddConversionRate { get; set; }
        [Column("TTM", TypeName = "decimal(9, 5)")]
        public decimal? Ttm { get; set; }
        [Column("TTS", TypeName = "decimal(9, 5)")]
        public decimal? Tts { get; set; }
        [Column("TTB", TypeName = "decimal(9, 5)")]
        public decimal? Ttb { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
