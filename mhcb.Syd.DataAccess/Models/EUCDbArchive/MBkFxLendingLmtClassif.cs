using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M_BK_FX_LENDING_LMT_CLASSIF", Schema = "EUC")]
    public partial class MBkFxLendingLmtClassif
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("ACM_METHOD")]
        [StringLength(3)]
        public string AcmMethod { get; set; }
        [Column("TERM_BASE")]
        [StringLength(3)]
        public string TermBase { get; set; }
        [Column("BANK_GRP_ABBR")]
        [StringLength(12)]
        public string BankGrpAbbr { get; set; }
        [Column("HO_GRADE_CD")]
        [StringLength(2)]
        public string HoGradeCd { get; set; }
        [Column("HO_EXPIRY", TypeName = "datetime")]
        public DateTime? HoExpiry { get; set; }
        [Column("HO_S_SHRT_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? HoSShrtLimit { get; set; }
        [Column("HO_SHRT_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? HoShrtLimit { get; set; }
        [Column("HO_SHRT_MID_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? HoShrtMidLimit { get; set; }
        [Column("HO_MID_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? HoMidLimit { get; set; }
        [Column("HO_MID_LNG_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? HoMidLngLimit { get; set; }
        [Column("HO_LNG_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? HoLngLimit { get; set; }
        [Column("BR_GRADE_CD")]
        [StringLength(2)]
        public string BrGradeCd { get; set; }
        [Column("BR_EXPIRY", TypeName = "datetime")]
        public DateTime? BrExpiry { get; set; }
        [Column("BR_S_SHRT_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BrSShrtLimit { get; set; }
        [Column("BR_SHRT_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BrShrtLimit { get; set; }
        [Column("BR_SHRT_MID_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BrShrtMidLimit { get; set; }
        [Column("BR_MID_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BrMidLimit { get; set; }
        [Column("BR_MID_LNG_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BrMidLngLimit { get; set; }
        [Column("BR_LNG_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BrLngLimit { get; set; }
        [Column("S_SHRT_BAL", TypeName = "decimal(18, 3)")]
        public decimal? SShrtBal { get; set; }
        [Column("SHRT_BAL", TypeName = "decimal(18, 3)")]
        public decimal? ShrtBal { get; set; }
        [Column("SHRT_MID_BAL", TypeName = "decimal(18, 3)")]
        public decimal? ShrtMidBal { get; set; }
        [Column("MID_BAL", TypeName = "decimal(18, 3)")]
        public decimal? MidBal { get; set; }
        [Column("MID_LNG_BAL", TypeName = "decimal(18, 3)")]
        public decimal? MidLngBal { get; set; }
        [Column("LNG_BAL", TypeName = "decimal(18, 3)")]
        public decimal? LngBal { get; set; }
        [Column("SUBLIMIT_BANK_ABBR")]
        [StringLength(12)]
        public string SublimitBankAbbr { get; set; }
        [Column("SUBLIMIT_HO_GRADE_CD")]
        [StringLength(2)]
        public string SublimitHoGradeCd { get; set; }
        [Column("SUBLIMIT_HO_S_SHRT", TypeName = "decimal(18, 3)")]
        public decimal? SublimitHoSShrt { get; set; }
        [Column("SUBLIMIT_HO_SHRT", TypeName = "decimal(18, 3)")]
        public decimal? SublimitHoShrt { get; set; }
        [Column("SUBLIMIT_HO_SHRT_MID", TypeName = "decimal(18, 3)")]
        public decimal? SublimitHoShrtMid { get; set; }
        [Column("SUBLIMIT_HO_MID", TypeName = "decimal(18, 3)")]
        public decimal? SublimitHoMid { get; set; }
        [Column("SUBLIMIT_HO_MID_LNG", TypeName = "decimal(18, 3)")]
        public decimal? SublimitHoMidLng { get; set; }
        [Column("SUBLIMIT_HO_LNG", TypeName = "decimal(18, 3)")]
        public decimal? SublimitHoLng { get; set; }
        [Column("SUBLIMIT_BR_GRADE_CD")]
        [StringLength(2)]
        public string SublimitBrGradeCd { get; set; }
        [Column("SUBLIMIT_BR_S_SHRT", TypeName = "decimal(18, 3)")]
        public decimal? SublimitBrSShrt { get; set; }
        [Column("SUBLIMIT_BR_SHRT", TypeName = "decimal(18, 3)")]
        public decimal? SublimitBrShrt { get; set; }
        [Column("SUBLIMIT_BR_SHRT_MID", TypeName = "decimal(18, 3)")]
        public decimal? SublimitBrShrtMid { get; set; }
        [Column("SUBLIMIT_BR_MID", TypeName = "decimal(18, 3)")]
        public decimal? SublimitBrMid { get; set; }
        [Column("SUBLIMIT_BR_MID_LNG", TypeName = "decimal(18, 3)")]
        public decimal? SublimitBrMidLng { get; set; }
        [Column("SUBLIMIT_BR_LNG", TypeName = "decimal(18, 3)")]
        public decimal? SublimitBrLng { get; set; }
        [Column("SUBLIMIT_S_SHRT_BAL", TypeName = "decimal(18, 3)")]
        public decimal? SublimitSShrtBal { get; set; }
        [Column("SUBLIMIT_SHRT_BAL", TypeName = "decimal(18, 3)")]
        public decimal? SublimitShrtBal { get; set; }
        [Column("SUBLIMIT_SHRT_MID_BAL", TypeName = "decimal(18, 3)")]
        public decimal? SublimitShrtMidBal { get; set; }
        [Column("SUBLIMIT_MID_BAL", TypeName = "decimal(18, 3)")]
        public decimal? SublimitMidBal { get; set; }
        [Column("SUBLIMIT_MID_LNG_BAL", TypeName = "decimal(18, 3)")]
        public decimal? SublimitMidLngBal { get; set; }
        [Column("SUBLIMIT_LNG_BAL", TypeName = "decimal(18, 3)")]
        public decimal? SublimitLngBal { get; set; }
        [Column("S_SHRT_COMMENT")]
        [StringLength(9)]
        public string SShrtComment { get; set; }
        [Column("SHRT_COMMENT")]
        [StringLength(9)]
        public string ShrtComment { get; set; }
        [Column("SHRT_MID_COMMENT")]
        [StringLength(9)]
        public string ShrtMidComment { get; set; }
        [Column("MID_COMMENT")]
        [StringLength(9)]
        public string MidComment { get; set; }
        [Column("MID_LNG_COMMENT")]
        [StringLength(9)]
        public string MidLngComment { get; set; }
        [Column("LNG_COMMENT")]
        [StringLength(9)]
        public string LngComment { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
