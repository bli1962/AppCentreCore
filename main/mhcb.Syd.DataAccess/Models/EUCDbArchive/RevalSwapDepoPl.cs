using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("REVAL_SWAP_DEPO_PL", Schema = "EUC")]
    [Index(nameof(DataDate), Name = "IX_REVAL_SWAP_DEPO_PL")]
    public partial class RevalSwapDepoPl
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("SYSTEM_CODE")]
        [StringLength(2)]
        public string SystemCode { get; set; }
        [Column("ON_MEMO_FLG")]
        [StringLength(1)]
        public string OnMemoFlg { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("REF_SUB_NO")]
        [StringLength(2)]
        public string RefSubNo { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("RECORD_CD")]
        [StringLength(1)]
        public string RecordCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("PL_ACT_CD")]
        [StringLength(5)]
        public string PlActCd { get; set; }
        [Column("SPOT_POSITION", TypeName = "decimal(21, 3)")]
        public decimal? SpotPosition { get; set; }
        [Column("SPOT_REVAL_BC", TypeName = "decimal(22, 3)")]
        public decimal? SpotRevalBc { get; set; }
        [Column("FWD_POSITION", TypeName = "decimal(21, 3)")]
        public decimal? FwdPosition { get; set; }
        [Column("FWD_REVAL_RATE", TypeName = "decimal(14, 9)")]
        public decimal? FwdRevalRate { get; set; }
        [Column("FWD_PA_VALUE", TypeName = "decimal(11, 10)")]
        public decimal? FwdPaValue { get; set; }
        [Column("FWD_REVAL_FC", TypeName = "decimal(25, 3)")]
        public decimal? FwdRevalFc { get; set; }
        [Column("FWD_REVAL_BC", TypeName = "decimal(25, 3)")]
        public decimal? FwdRevalBc { get; set; }
        [Column("ACCR_PAYBLE_FC", TypeName = "decimal(21, 3)")]
        public decimal? AccrPaybleFc { get; set; }
        [Column("ACCR_PAYBLE_BC", TypeName = "decimal(22, 3)")]
        public decimal? AccrPaybleBc { get; set; }
        [Column("UNEARN_PREPAY_FC", TypeName = "decimal(21, 3)")]
        public decimal? UnearnPrepayFc { get; set; }
        [Column("UNEARN_PREPAY_BC", TypeName = "decimal(22, 3)")]
        public decimal? UnearnPrepayBc { get; set; }
        [Column("DEF_REVAL_FC", TypeName = "decimal(25, 3)")]
        public decimal? DefRevalFc { get; set; }
        [Column("DEF_REVAL_BC", TypeName = "decimal(25, 3)")]
        public decimal? DefRevalBc { get; set; }
        [Column("TTM_RATE", TypeName = "decimal(10, 6)")]
        public decimal? TtmRate { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
        [Column("CON_CD")]
        [StringLength(3)]
        public string ConCd { get; set; }
        [Column("HEDGE_TYPE")]
        [StringLength(1)]
        public string HedgeType { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
