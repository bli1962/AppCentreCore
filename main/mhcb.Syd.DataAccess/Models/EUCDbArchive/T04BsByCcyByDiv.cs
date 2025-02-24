using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T04_BS_BY_CCY_BY_DIV", Schema = "EUC")]
    public partial class T04BsByCcyByDiv
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("FUNC_BASE_CD")]
        [StringLength(1)]
        public string FuncBaseCd { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
        [Column("DIVISION_NAME")]
        [StringLength(25)]
        public string DivisionName { get; set; }
        [Column("ON_MEMO_CD")]
        [StringLength(1)]
        public string OnMemoCd { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("ACT_TYPE")]
        [StringLength(1)]
        public string ActType { get; set; }
        [Column("SHADOW_ID")]
        [StringLength(1)]
        public string ShadowId { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("ACT_NAME")]
        [StringLength(30)]
        public string ActName { get; set; }
        [Column("PREV_BALANCE_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? PrevBalanceAmount { get; set; }
        [Column("DR_AMOUNT_TOT", TypeName = "decimal(20, 3)")]
        public decimal? DrAmountTot { get; set; }
        [Column("CR_AMOUNT_TOT", TypeName = "decimal(20, 3)")]
        public decimal? CrAmountTot { get; set; }
        [Column("BALANCE", TypeName = "decimal(18, 3)")]
        public decimal? Balance { get; set; }
        [Column("BASE_BALANCE_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? BaseBalanceAmount { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
