using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("PROF_BAL_BY_CUST_BY_PROD", Schema = "EUC")]
    public partial class ProfBalByCustByProd
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("PURPOSE_CD")]
        [StringLength(2)]
        public string PurposeCd { get; set; }
        [Column("ACT_CD_BS")]
        [StringLength(5)]
        public string ActCdBs { get; set; }
        [Column("RECORD_ID")]
        [StringLength(2)]
        public string RecordId { get; set; }
        [Column("SEGMENT_TYPE")]
        [StringLength(2)]
        public string SegmentType { get; set; }
        [Column("GRT_ID")]
        [StringLength(1)]
        public string GrtId { get; set; }
        [Column("TRANS_KIND")]
        [StringLength(3)]
        public string TransKind { get; set; }
        [Column("TERM_ID")]
        [StringLength(1)]
        public string TermId { get; set; }
        [Column("SHADOW_ID")]
        [StringLength(1)]
        public string ShadowId { get; set; }
        [Column("ACT_CD_PL")]
        [StringLength(5)]
        public string ActCdPl { get; set; }
        [Column("PL_ACT_TYPE")]
        [StringLength(1)]
        public string PlActType { get; set; }
        [Column("REVISION_FLG")]
        [StringLength(1)]
        public string RevisionFlg { get; set; }
        [Column("EXPENSES_CD")]
        [StringLength(2)]
        public string ExpensesCd { get; set; }
        [Column("EXPENSES_NAME")]
        [StringLength(30)]
        public string ExpensesName { get; set; }
        [Column("PROD_CLASS_NAME")]
        [StringLength(50)]
        public string ProdClassName { get; set; }
        [Column("PROD_NAME")]
        [StringLength(50)]
        public string ProdName { get; set; }
        [Column("ACT_NAME_BS")]
        [StringLength(30)]
        public string ActNameBs { get; set; }
        [Column("ACT_NAME_PL")]
        [StringLength(30)]
        public string ActNamePl { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("BALANCE", TypeName = "decimal(18, 3)")]
        public decimal? Balance { get; set; }
        [Column("AVERAGE", TypeName = "decimal(18, 3)")]
        public decimal? Average { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
