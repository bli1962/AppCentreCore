using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("TAX_CODE_TABLE", Schema = "EUC")]
    public partial class TaxCodeTable
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("TAX_ID")]
        [StringLength(1)]
        public string TaxId { get; set; }
        [Column("TAX_CD")]
        [StringLength(2)]
        public string TaxCd { get; set; }
        [Column("TAX_RATE", TypeName = "decimal(10, 7)")]
        public decimal? TaxRate { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
