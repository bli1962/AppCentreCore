using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("TREASURY_PROFIT_BY_TRANS", Schema = "EUC")]
    public partial class TreasuryProfitByTran
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("REF_KIND")]
        [StringLength(3)]
        public string RefKind { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("DD_NO")]
        [StringLength(3)]
        public string DdNo { get; set; }
        [Column("RO_NO")]
        [StringLength(3)]
        public string RoNo { get; set; }
        [Column("PART_NO")]
        [StringLength(3)]
        public string PartNo { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("SHADOW_ID")]
        [StringLength(1)]
        public string ShadowId { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("VALDATE", TypeName = "datetime")]
        public DateTime? Valdate { get; set; }
        [Column("DUEDATE", TypeName = "datetime")]
        public DateTime? Duedate { get; set; }
        [Column("PL_TOTAL_CURR_M_FC", TypeName = "decimal(18, 3)")]
        public decimal? PlTotalCurrMFc { get; set; }
        [Column("PL_TOTAL_CURR_M_BC", TypeName = "decimal(18, 3)")]
        public decimal? PlTotalCurrMBc { get; set; }
        [Column("BALANCE_FC", TypeName = "decimal(18, 3)")]
        public decimal? BalanceFc { get; set; }
        [Column("RATE", TypeName = "decimal(11, 6)")]
        public decimal? Rate { get; set; }
        [Column("RATE_CD")]
        [StringLength(1)]
        public string RateCd { get; set; }
        [Column("DAYS_A_YEAR_CD")]
        [StringLength(1)]
        public string DaysAYearCd { get; set; }
        [Column("DAYS_ID")]
        [StringLength(1)]
        public string DaysId { get; set; }
        [Column("BASERATE_CD")]
        [StringLength(2)]
        public string BaserateCd { get; set; }
        [Column("BASERATE", TypeName = "decimal(11, 7)")]
        public decimal? Baserate { get; set; }
        [Column("RCD_CD")]
        [StringLength(1)]
        public string RcdCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
