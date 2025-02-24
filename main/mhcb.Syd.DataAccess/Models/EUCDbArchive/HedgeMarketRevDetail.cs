using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("HEDGE_MARKET_REV_DETAIL", Schema = "EUC")]
    public partial class HedgeMarketRevDetail
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("REF_SUB_NO")]
        [StringLength(2)]
        public string RefSubNo { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("MARKET_REV_DATA_DATE", TypeName = "datetime")]
        public DateTime? MarketRevDataDate { get; set; }
        [Column("SYSTEM_MARKET_VALUE", TypeName = "decimal(18, 3)")]
        public decimal? SystemMarketValue { get; set; }
        [Column("SYSTEM_REVALUE", TypeName = "decimal(18, 3)")]
        public decimal? SystemRevalue { get; set; }
        [Column("SYSTEM_DEF_REVALUE", TypeName = "decimal(18, 3)")]
        public decimal? SystemDefRevalue { get; set; }
        [Column("MANUAL_MARKET_VALUE", TypeName = "decimal(18, 3)")]
        public decimal? ManualMarketValue { get; set; }
        [Column("MANUAL_REVALUE", TypeName = "decimal(18, 3)")]
        public decimal? ManualRevalue { get; set; }
        [Column("MANUAL_DEF_REVALUE", TypeName = "decimal(18, 3)")]
        public decimal? ManualDefRevalue { get; set; }
        [Column("DISCONTINUED_HEDGE_RATE", TypeName = "decimal(9, 7)")]
        public decimal? DiscontinuedHedgeRate { get; set; }
        [Column("DISCONTINUED_ADJ_SUB_NO")]
        [StringLength(2)]
        public string DiscontinuedAdjSubNo { get; set; }
        [Column("TERMINATED_HEDGE_RATE", TypeName = "decimal(9, 7)")]
        public decimal? TerminatedHedgeRate { get; set; }
        [Column("TERMINATED_ADJ_SUB_NO")]
        [StringLength(2)]
        public string TerminatedAdjSubNo { get; set; }
        [Column("REDESIGNED_HEDGE_RATE", TypeName = "decimal(9, 7)")]
        public decimal? RedesignedHedgeRate { get; set; }
        [Column("REDESIGNED_ADJ_SUB_NO")]
        [StringLength(2)]
        public string RedesignedAdjSubNo { get; set; }
        [Column("MONTH_END_OPE_FLG")]
        [StringLength(1)]
        public string MonthEndOpeFlg { get; set; }
        [Column("LAST_UPDATE", TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
