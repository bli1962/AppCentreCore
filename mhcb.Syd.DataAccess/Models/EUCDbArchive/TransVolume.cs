using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("TRANS_VOLUME", Schema = "EUC")]
    public partial class TransVolume
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("DEPT_CD")]
        [StringLength(2)]
        public string DeptCd { get; set; }
        [Column("ONLINE_SYSTEM_CD")]
        [StringLength(2)]
        public string OnlineSystemCd { get; set; }
        [Column("ONLINE_FUNC_CD")]
        [StringLength(2)]
        public string OnlineFuncCd { get; set; }
        [Column("TRANS_KIND")]
        [StringLength(3)]
        public string TransKind { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("VOL_SYSTEM_CD")]
        [StringLength(2)]
        public string VolSystemCd { get; set; }
        [Column("VOL_FUNC_CD")]
        [StringLength(2)]
        public string VolFuncCd { get; set; }
        [Column("VOL_SERIAL_NO")]
        [StringLength(1)]
        public string VolSerialNo { get; set; }
        [Column("ONLINE_FUNC_NAME")]
        [StringLength(30)]
        public string OnlineFuncName { get; set; }
        [Column("UPDATE_DATE", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("VOL_APR", TypeName = "decimal(5, 0)")]
        public decimal? VolApr { get; set; }
        [Column("VOL_MAY", TypeName = "decimal(5, 0)")]
        public decimal? VolMay { get; set; }
        [Column("VOL_JUN", TypeName = "decimal(5, 0)")]
        public decimal? VolJun { get; set; }
        [Column("VOL_JUL", TypeName = "decimal(5, 0)")]
        public decimal? VolJul { get; set; }
        [Column("VOL_AUG", TypeName = "decimal(5, 0)")]
        public decimal? VolAug { get; set; }
        [Column("VOL_SEP", TypeName = "decimal(5, 0)")]
        public decimal? VolSep { get; set; }
        [Column("VOL_OCT", TypeName = "decimal(5, 0)")]
        public decimal? VolOct { get; set; }
        [Column("VOL_NOV", TypeName = "decimal(5, 0)")]
        public decimal? VolNov { get; set; }
        [Column("VOL_DEC", TypeName = "decimal(5, 0)")]
        public decimal? VolDec { get; set; }
        [Column("VOL_JAN", TypeName = "decimal(5, 0)")]
        public decimal? VolJan { get; set; }
        [Column("VOL_FEB", TypeName = "decimal(5, 0)")]
        public decimal? VolFeb { get; set; }
        [Column("VOL_MAR", TypeName = "decimal(5, 0)")]
        public decimal? VolMar { get; set; }
        [Column("VOL_PREV_1ST", TypeName = "decimal(7, 0)")]
        public decimal? VolPrev1st { get; set; }
        [Column("VOL_PREV_2ND", TypeName = "decimal(7, 0)")]
        public decimal? VolPrev2nd { get; set; }
        [Column("COUNT_TYPE_NAME")]
        [StringLength(30)]
        public string CountTypeName { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate1 { get; set; }
    }
}
