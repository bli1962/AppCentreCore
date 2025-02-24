using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T07_MANUAL_REVISION_DETAILS", Schema = "EUC")]
    public partial class T07ManualRevisionDetail
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
        [Column("CLOSING_DATE", TypeName = "datetime")]
        public DateTime? ClosingDate { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("ACT_TYPE")]
        [StringLength(1)]
        public string ActType { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("DRAW_DOWN_NO")]
        [StringLength(3)]
        public string DrawDownNo { get; set; }
        [Column("ROLL_OVER_NO")]
        [StringLength(3)]
        public string RollOverNo { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("DEPT_CD")]
        [StringLength(4)]
        public string DeptCd { get; set; }
        [Column("OPE_INFO")]
        [StringLength(1)]
        public string OpeInfo { get; set; }
        [Column("ACCR_INT", TypeName = "decimal(18, 3)")]
        public decimal? AccrInt { get; set; }
        [Column("ACCR_DCRS_FLG")]
        [StringLength(1)]
        public string AccrDcrsFlg { get; set; }
        [Column("UNEARNED_INT", TypeName = "decimal(18, 3)")]
        public decimal? UnearnedInt { get; set; }
        [Column("UNEARNED_DCRS_FLG")]
        [StringLength(1)]
        public string UnearnedDcrsFlg { get; set; }
        [Column("ACCR_RETRACE", TypeName = "decimal(18, 3)")]
        public decimal? AccrRetrace { get; set; }
        [Column("ACCR_RETR_DCRS_FLG")]
        [StringLength(1)]
        public string AccrRetrDcrsFlg { get; set; }
        [Column("UNEARNED_RETRACE", TypeName = "decimal(18, 3)")]
        public decimal? UnearnedRetrace { get; set; }
        [Column("UNEARNED_RETR_DCRS_FLG")]
        [StringLength(1)]
        public string UnearnedRetrDcrsFlg { get; set; }
        [Column("ACCR_INTERNAL", TypeName = "decimal(18, 3)")]
        public decimal? AccrInternal { get; set; }
        [Column("UNEARNED_INTERNAL", TypeName = "decimal(18, 3)")]
        public decimal? UnearnedInternal { get; set; }
        [Column("OPE_DATE", TypeName = "datetime")]
        public DateTime? OpeDate { get; set; }
        [Column("MODIFIED_DATE", TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("REMARKS")]
        [StringLength(40)]
        public string Remarks { get; set; }
        [Column("REVISION_NO")]
        [StringLength(4)]
        public string RevisionNo { get; set; }
        [Column("LATEST_REVISION_NO")]
        [StringLength(4)]
        public string LatestRevisionNo { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
