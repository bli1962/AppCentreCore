using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M04_PROF_BY_ACC_CD_BY_ACC_NO", Schema = "EUC")]
    public partial class M04ProfByAccCdByAccNo
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
        [Column("SHADOW_ID")]
        [StringLength(1)]
        public string ShadowId { get; set; }
        [Column("ACT_TYPE")]
        [StringLength(1)]
        public string ActType { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("ACT_NO")]
        [StringLength(12)]
        public string ActNo { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("AVE_BALANCE", TypeName = "decimal(20, 3)")]
        public decimal? AveBalance { get; set; }
        [Column("RISK_ASSET", TypeName = "decimal(18, 3)")]
        public decimal? RiskAsset { get; set; }
        [Column("INT_PROFIT", TypeName = "decimal(18, 3)")]
        public decimal? IntProfit { get; set; }
        [Column("INT_ORDINARY", TypeName = "decimal(18, 3)")]
        public decimal? IntOrdinary { get; set; }
        [Column("INTERNAL_INT", TypeName = "decimal(18, 3)")]
        public decimal? InternalInt { get; set; }
        [Column("SPREAD_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? SpreadIncome { get; set; }
        [Column("FEE_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? FeeIncome { get; set; }
        [Column("FOREX_PROFIT", TypeName = "decimal(18, 3)")]
        public decimal? ForexProfit { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
