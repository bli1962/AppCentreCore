using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("SCHEME_PROF_ANALYSIS", Schema = "EUC")]
    public partial class SchemeProfAnalysis
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("DD_NO")]
        [StringLength(3)]
        public string DdNo { get; set; }
        [Column("PURPOSE_CD")]
        [StringLength(2)]
        public string PurposeCd { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("SELL_BUY")]
        [StringLength(1)]
        public string SellBuy { get; set; }
        [Column("CONTRACT_EQUIVAL")]
        [StringLength(1)]
        public string ContractEquival { get; set; }
        [Column("RECEIVE_PAY")]
        [StringLength(1)]
        public string ReceivePay { get; set; }
        [Column("BALANCE", TypeName = "decimal(18, 3)")]
        public decimal? Balance { get; set; }
        [Column("MONTH_AVE_BAL", TypeName = "decimal(18, 3)")]
        public decimal? MonthAveBal { get; set; }
        [Column("SPREAD", TypeName = "decimal(9, 6)")]
        public decimal? Spread { get; set; }
        [Column("SPREAD_AVG", TypeName = "decimal(9, 6)")]
        public decimal? SpreadAvg { get; set; }
        [Column("INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? IntIncome { get; set; }
        [Column("INT_SPREAD_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? IntSpreadIncome { get; set; }
        [Column("BOND_PL", TypeName = "decimal(18, 3)")]
        public decimal? BondPl { get; set; }
        [Column("FX_SPREAD", TypeName = "decimal(13, 8)")]
        public decimal? FxSpread { get; set; }
        [Column("FX_SPREAD_PL", TypeName = "decimal(18, 3)")]
        public decimal? FxSpreadPl { get; set; }
        [Column("FEE_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? FeeIncome { get; set; }
        [Column("PROFIT_TOT", TypeName = "decimal(18, 3)")]
        public decimal? ProfitTot { get; set; }
        [Column("CONTRACT_DATE_VALUE", TypeName = "datetime")]
        public DateTime? ContractDateValue { get; set; }
        [Column("DUE_DATE", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("FCBC_CD")]
        [StringLength(1)]
        public string FcbcCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
