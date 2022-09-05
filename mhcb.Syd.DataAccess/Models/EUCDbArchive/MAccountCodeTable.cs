using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M_ACCOUNT_CODE_TABLE", Schema = "EUC")]
    public partial class MAccountCodeTable
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_NAME")]
        [StringLength(30)]
        public string ActName { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("ACT_TYPE")]
        [StringLength(1)]
        public string ActType { get; set; }
        [Column("REVISION_FLG")]
        [StringLength(1)]
        public string RevisionFlg { get; set; }
        [Column("SEGMENT_TYPE")]
        [StringLength(2)]
        public string SegmentType { get; set; }
        [Column("FC_HC")]
        [StringLength(1)]
        public string FcHc { get; set; }
        [Column("OD_FLG")]
        [StringLength(1)]
        public string OdFlg { get; set; }
        [Column("JOURNALIZING")]
        [StringLength(1)]
        public string Journalizing { get; set; }
        [Column("RELATED_ACT")]
        [StringLength(5)]
        public string RelatedAct { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("REGISTERED", TypeName = "datetime")]
        public DateTime? Registered { get; set; }
        [Column("MODIFIED", TypeName = "datetime")]
        public DateTime? Modified { get; set; }
        [Column("DEPOSIT_KIND")]
        [StringLength(2)]
        public string DepositKind { get; set; }
        [Column("DEPT_CD")]
        [StringLength(2)]
        public string DeptCd { get; set; }
        [Column("BS_CD")]
        [StringLength(5)]
        public string BsCd { get; set; }
        [Column("BS_NAME")]
        [StringLength(30)]
        public string BsName { get; set; }
        [Column("RELATED_ACT_2")]
        [StringLength(5)]
        public string RelatedAct2 { get; set; }
        [Column("RELATED_ACT_3")]
        [StringLength(5)]
        public string RelatedAct3 { get; set; }
        [Column("RELATED_ACT_4")]
        [StringLength(5)]
        public string RelatedAct4 { get; set; }
        [Column("SECTOR_CD")]
        [StringLength(2)]
        public string SectorCd { get; set; }
        [Column("ASFI_ACCRUAL_ACT")]
        [StringLength(1)]
        public string AsfiAccrualAct { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
