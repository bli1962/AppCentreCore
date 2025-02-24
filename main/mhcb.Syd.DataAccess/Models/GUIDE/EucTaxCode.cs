using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("EUC_TAX_CODE", Schema = "dbo")]
    public partial class EucTaxCode
    {
        [Key]
        [Column("TAX_ID")]
        [StringLength(1)]
        [Unicode(false)]
        public string TaxId { get; set; }
        [Key]
        [Column("TAX_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string TaxCd { get; set; }
        [Column("TAX_RATE", TypeName = "decimal(10, 7)")]
        public decimal? TaxRate { get; set; }
        [Key]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        [Unicode(false)]
        public string BranchNo { get; set; }
    }
}
