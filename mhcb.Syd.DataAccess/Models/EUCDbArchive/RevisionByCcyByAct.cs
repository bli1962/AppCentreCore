using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("REVISION_BY_CCY_BY_ACT", Schema = "EUC")]
    public partial class RevisionByCcyByAct
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("ACCRUE_FLG")]
        [StringLength(1)]
        public string AccrueFlg { get; set; }
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
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("TRIAL_CLOSING_FLG")]
        [StringLength(1)]
        public string TrialClosingFlg { get; set; }
        [Column("CLOSING_DATE", TypeName = "datetime")]
        public DateTime? ClosingDate { get; set; }
        [Column("CLOSING_OPE_DATE", TypeName = "datetime")]
        public DateTime? ClosingOpeDate { get; set; }
        [Column("INT_BEFORE_REV", TypeName = "decimal(18, 3)")]
        public decimal? IntBeforeRev { get; set; }
        [Column("ACCRUE_THIS_TERM1", TypeName = "decimal(18, 3)")]
        public decimal? AccrueThisTerm1 { get; set; }
        [Column("ACCRUE_THIS_TERM2", TypeName = "decimal(18, 3)")]
        public decimal? AccrueThisTerm2 { get; set; }
        [Column("ACCRUE_PRE_TERM1", TypeName = "decimal(18, 3)")]
        public decimal? AccruePreTerm1 { get; set; }
        [Column("ACCRUE_PRE_TERM2", TypeName = "decimal(18, 3)")]
        public decimal? AccruePreTerm2 { get; set; }
        [Column("INT_AFTER_REV", TypeName = "decimal(18, 3)")]
        public decimal? IntAfterRev { get; set; }
        [Column("CONVERSION_RATE", TypeName = "decimal(9, 5)")]
        public decimal? ConversionRate { get; set; }
        [Column("ACCRUE1_AUTO", TypeName = "decimal(18, 3)")]
        public decimal? Accrue1Auto { get; set; }
        [Column("ACCRUE2_AUTO", TypeName = "decimal(18, 3)")]
        public decimal? Accrue2Auto { get; set; }
        [Column("MODIFIED_FLG")]
        [StringLength(1)]
        public string ModifiedFlg { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
