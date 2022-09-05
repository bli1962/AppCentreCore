using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M05_SWAP_CURRENT_EXP_LMT", Schema = "EUC")]
    public partial class M05SwapCurrentExpLmt
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(9)]
        public string RefNo { get; set; }
        [Column("REPL_USD", TypeName = "decimal(19, 3)")]
        public decimal? ReplUsd { get; set; }
        [Column("NMNL_AMT", TypeName = "decimal(19, 3)")]
        public decimal? NmnlAmt { get; set; }
        [Column("ADD_RATE", TypeName = "decimal(9, 6)")]
        public decimal? AddRate { get; set; }
        [Column("RSK_USD", TypeName = "decimal(16, 3)")]
        public decimal? RskUsd { get; set; }
        [Column("INTBANK")]
        [StringLength(1)]
        public string Intbank { get; set; }
        [Column("LINE_AMT", TypeName = "decimal(16, 3)")]
        public decimal? LineAmt { get; set; }
        [Column("EXPIRY_DATE", TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [Column("COMMODITY_CD")]
        [StringLength(1)]
        public string CommodityCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
