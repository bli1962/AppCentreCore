using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M_BK_FX_LENDING_LMT_CLASSIFMIN", Schema = "EUC")]
    public partial class MBkFxLendingLmtClassifmin
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("ACM_METHOD")]
        [StringLength(3)]
        public string AcmMethod { get; set; }
        [Column("BANK_GRP_ABBR")]
        [StringLength(12)]
        public string BankGrpAbbr { get; set; }
        [Column("BANK_GRP_GRADE_CD")]
        [StringLength(2)]
        public string BankGrpGradeCd { get; set; }
        [Column("BANK_GRP_EXPIRY", TypeName = "datetime")]
        public DateTime? BankGrpExpiry { get; set; }
        [Column("BANK_GRP_BR_GRADE_CD")]
        [StringLength(2)]
        public string BankGrpBrGradeCd { get; set; }
        [Column("BANK_GRP_BR_EXPIRY", TypeName = "datetime")]
        public DateTime? BankGrpBrExpiry { get; set; }
        [Column("SUBLIMIT_BANK_ABBR")]
        [StringLength(12)]
        public string SublimitBankAbbr { get; set; }
        [Column("SUBLIMIT_HO_GRADE_CD")]
        [StringLength(2)]
        public string SublimitHoGradeCd { get; set; }
        [Column("SUBLIMIT_BR_GRADE_CD")]
        [StringLength(2)]
        public string SublimitBrGradeCd { get; set; }
        [Column("S_TERM_COMMENT")]
        [StringLength(9)]
        public string STermComment { get; set; }
        [Column("S_START_DATE", TypeName = "datetime")]
        public DateTime? SStartDate { get; set; }
        [Column("BANK_GRP_S_HO_FX_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpSHoFxLimit { get; set; }
        [Column("BANK_GRP_S_BR_FX_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpSBrFxLimit { get; set; }
        [Column("BANK_GRP_S_MIN_DATE", TypeName = "datetime")]
        public DateTime? BankGrpSMinDate { get; set; }
        [Column("BANK_GRP_S_AMT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpSAmt { get; set; }
        [Column("SUBLIMIT_S_HO_FX", TypeName = "decimal(18, 3)")]
        public decimal? SublimitSHoFx { get; set; }
        [Column("SUBLIMIT_S_BR_FX", TypeName = "decimal(18, 3)")]
        public decimal? SublimitSBrFx { get; set; }
        [Column("SUBLIMIT_S_MIN_DATE", TypeName = "datetime")]
        public DateTime? SublimitSMinDate { get; set; }
        [Column("SUBLIMIT_S_AMT", TypeName = "decimal(18, 3)")]
        public decimal? SublimitSAmt { get; set; }
        [Column("SHRT_TERM_COMMENT")]
        [StringLength(9)]
        public string ShrtTermComment { get; set; }
        [Column("SHRT_START_DATE", TypeName = "datetime")]
        public DateTime? ShrtStartDate { get; set; }
        [Column("BANK_GRP_SHRT_HO_FX_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpShrtHoFxLimit { get; set; }
        [Column("BANK_GRP_SHRT_BR_FX_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpShrtBrFxLimit { get; set; }
        [Column("BANK_GRP_SHRT_MIN_DATE", TypeName = "datetime")]
        public DateTime? BankGrpShrtMinDate { get; set; }
        [Column("BANK_GRP_SHRT_AMT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpShrtAmt { get; set; }
        [Column("SUBLIMIT_SHRT_HO_FX", TypeName = "decimal(18, 3)")]
        public decimal? SublimitShrtHoFx { get; set; }
        [Column("SUBLIMIT_SHRT_BR_FX", TypeName = "decimal(18, 3)")]
        public decimal? SublimitShrtBrFx { get; set; }
        [Column("SUBLIMIT_SHRT_MIN_DATE", TypeName = "datetime")]
        public DateTime? SublimitShrtMinDate { get; set; }
        [Column("SUBLIMIT_SHRT_AMT", TypeName = "decimal(18, 3)")]
        public decimal? SublimitShrtAmt { get; set; }
        [Column("SHRT_MID_TERM_COMMENT")]
        [StringLength(9)]
        public string ShrtMidTermComment { get; set; }
        [Column("SHRT_MID_START_DATE", TypeName = "datetime")]
        public DateTime? ShrtMidStartDate { get; set; }
        [Column("BANK_GRP_SHRT_MID_HO_FX_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpShrtMidHoFxLimit { get; set; }
        [Column("BANK_GRP_SHRT_MID_BR_FX_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpShrtMidBrFxLimit { get; set; }
        [Column("BANK_GRP_SHRT_MID_MIN_DATE", TypeName = "datetime")]
        public DateTime? BankGrpShrtMidMinDate { get; set; }
        [Column("BANK_GRP_SHRT_MID_AMT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpShrtMidAmt { get; set; }
        [Column("SUBLIMIT_SHRT_MID_HO_FX", TypeName = "decimal(18, 3)")]
        public decimal? SublimitShrtMidHoFx { get; set; }
        [Column("SUBLIMIT_SHRT_MID_BR_FX", TypeName = "decimal(18, 3)")]
        public decimal? SublimitShrtMidBrFx { get; set; }
        [Column("SUBLIMIT_SHRT_MID_MIN_DATE", TypeName = "datetime")]
        public DateTime? SublimitShrtMidMinDate { get; set; }
        [Column("SUBLIMIT_SHRT_MID_AMT", TypeName = "decimal(18, 3)")]
        public decimal? SublimitShrtMidAmt { get; set; }
        [Column("MID_COMMENT")]
        [StringLength(9)]
        public string MidComment { get; set; }
        [Column("MID_START_DATE", TypeName = "datetime")]
        public DateTime? MidStartDate { get; set; }
        [Column("BANK_GRP_MID_HO_FX_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpMidHoFxLimit { get; set; }
        [Column("BANK_GRP_MID_BR_FX_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpMidBrFxLimit { get; set; }
        [Column("BANK_GRP_MID_MIN_DATE", TypeName = "datetime")]
        public DateTime? BankGrpMidMinDate { get; set; }
        [Column("BANK_GRP_MID_AMT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpMidAmt { get; set; }
        [Column("SUBLIMIT_MID_HO_FX", TypeName = "decimal(18, 3)")]
        public decimal? SublimitMidHoFx { get; set; }
        [Column("SUBLIMIT_MID_BR_FX", TypeName = "decimal(18, 3)")]
        public decimal? SublimitMidBrFx { get; set; }
        [Column("SUBLIMIT_MID_MIN_DATE", TypeName = "datetime")]
        public DateTime? SublimitMidMinDate { get; set; }
        [Column("SUBLIMIT_MID_AMT", TypeName = "decimal(18, 3)")]
        public decimal? SublimitMidAmt { get; set; }
        [Column("MID_LNG_COMMENT")]
        [StringLength(9)]
        public string MidLngComment { get; set; }
        [Column("MID_LNG_START_DATE", TypeName = "datetime")]
        public DateTime? MidLngStartDate { get; set; }
        [Column("BANK_GRP_MID_LNG_HO_FX_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpMidLngHoFxLimit { get; set; }
        [Column("BANK_GRP_MID_LNG_BR_FX_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpMidLngBrFxLimit { get; set; }
        [Column("BANK_GRP_MID_LNG_MIN_DATE", TypeName = "datetime")]
        public DateTime? BankGrpMidLngMinDate { get; set; }
        [Column("BANK_GRP_MID_LNG_AMT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpMidLngAmt { get; set; }
        [Column("SUBLIMIT_MID_LNG_HO_FX", TypeName = "decimal(18, 3)")]
        public decimal? SublimitMidLngHoFx { get; set; }
        [Column("SUBLIMIT_MID_LNG_BR_FX", TypeName = "decimal(18, 3)")]
        public decimal? SublimitMidLngBrFx { get; set; }
        [Column("SUBLIMIT_MID_LNG_MIN_DATE", TypeName = "datetime")]
        public DateTime? SublimitMidLngMinDate { get; set; }
        [Column("SUBLIMIT_MID_LNG_AMT", TypeName = "decimal(18, 3)")]
        public decimal? SublimitMidLngAmt { get; set; }
        [Column("LNG_COMMENT")]
        [StringLength(9)]
        public string LngComment { get; set; }
        [Column("LNG_START_DATE", TypeName = "datetime")]
        public DateTime? LngStartDate { get; set; }
        [Column("BANK_GRP_LNG_HO_FX_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpLngHoFxLimit { get; set; }
        [Column("BANK_GRP_LNG_BR_FX_LIMIT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpLngBrFxLimit { get; set; }
        [Column("BANK_GRP_LNG_MIN_DATE", TypeName = "datetime")]
        public DateTime? BankGrpLngMinDate { get; set; }
        [Column("BANK_GRP_LNG_AMT", TypeName = "decimal(18, 3)")]
        public decimal? BankGrpLngAmt { get; set; }
        [Column("SUBLIMIT_LNG_HO_FX_", TypeName = "decimal(18, 3)")]
        public decimal? SublimitLngHoFx { get; set; }
        [Column("SUBLIMIT_LNG_BR_FX", TypeName = "decimal(18, 3)")]
        public decimal? SublimitLngBrFx { get; set; }
        [Column("SUBLIMIT_LNG_MIN_DATE", TypeName = "datetime")]
        public DateTime? SublimitLngMinDate { get; set; }
        [Column("SUBLIMIT_LNG_AMT", TypeName = "decimal(18, 3)")]
        public decimal? SublimitLngAmt { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
