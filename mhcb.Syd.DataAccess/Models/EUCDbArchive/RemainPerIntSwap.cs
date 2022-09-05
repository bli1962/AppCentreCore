using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("REMAIN_PER_INT_SWAP", Schema = "EUC")]
    public partial class RemainPerIntSwap
    {
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CON_CD")]
        [StringLength(3)]
        public string ConCd { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("REF_SUB_NO")]
        [StringLength(2)]
        public string RefSubNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("DECIMAL_POINT")]
        [StringLength(1)]
        public string DecimalPoint { get; set; }
        [Column("FUNCTION_CD")]
        [StringLength(1)]
        public string FunctionCd { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("FIXED_FLOAT")]
        [StringLength(1)]
        public string FixedFloat { get; set; }
        [Column("TERM_CD")]
        [StringLength(1)]
        public string TermCd { get; set; }
        [Column("NMNL_1Y_FC", TypeName = "decimal(15, 3)")]
        public decimal? Nmnl1yFc { get; set; }
        [Column("NMNL_1Y_BC", TypeName = "decimal(15, 3)")]
        public decimal? Nmnl1yBc { get; set; }
        [Column("NMNL_1YOVER_FC", TypeName = "decimal(15, 3)")]
        public decimal? Nmnl1yoverFc { get; set; }
        [Column("NMNL_1YOVER_BC", TypeName = "decimal(15, 3)")]
        public decimal? Nmnl1yoverBc { get; set; }
        [Column("NMNL_3YOVER_FC", TypeName = "decimal(15, 3)")]
        public decimal? Nmnl3yoverFc { get; set; }
        [Column("NMNL_3YOVER_BC", TypeName = "decimal(15, 3)")]
        public decimal? Nmnl3yoverBc { get; set; }
        [Column("NMNL_5YOVER_FC", TypeName = "decimal(15, 3)")]
        public decimal? Nmnl5yoverFc { get; set; }
        [Column("NMNL_5YOVER_BC", TypeName = "decimal(15, 3)")]
        public decimal? Nmnl5yoverBc { get; set; }
        [Column("BT_CD")]
        [StringLength(1)]
        public string BtCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
