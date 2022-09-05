using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("ONDEMAND_SWAP_FX_LMT", Schema = "EUC_ONDM")]
    public partial class OndemandSwapFxLmt
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("INTSWAP_AMOUNT", TypeName = "decimal(15, 0)")]
        public decimal? IntswapAmount { get; set; }
        [Column("INTSWAP_EXPDT")]
        [StringLength(8)]
        public string IntswapExpdt { get; set; }
        [Column("CCYSWAP_AMOUNT", TypeName = "decimal(15, 0)")]
        public decimal? CcyswapAmount { get; set; }
        [Column("CCYSWAP_EXPDT")]
        [StringLength(8)]
        public string CcyswapExpdt { get; set; }
        [Column("FXDEX_AMOUNT", TypeName = "decimal(15, 0)")]
        public decimal? FxdexAmount { get; set; }
        [Column("FXDEX_EXPDT")]
        [StringLength(8)]
        public string FxdexExpdt { get; set; }
        [Column("REV1")]
        [StringLength(52)]
        public string Rev1 { get; set; }
        [Column("CRT_DATE")]
        [StringLength(19)]
        public string CrtDate { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
        [Column("BATCH_NUMBER")]
        public int? BatchNumber { get; set; }
    }
}
