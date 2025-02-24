using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("PROFIT_DETAIL_BY_TRANS", Schema = "EUC")]
    public partial class ProfitDetailByTran
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("SCHEDULED_DIVISION")]
        [StringLength(2)]
        public string ScheduledDivision { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("DD_NO")]
        [StringLength(3)]
        public string DdNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("DEPT_CD")]
        [StringLength(2)]
        public string DeptCd { get; set; }
        [Column("OFFICER_CD")]
        [StringLength(4)]
        public string OfficerCd { get; set; }
        [Column("SECTION_CD")]
        [StringLength(2)]
        public string SectionCd { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("TOT_PROFIT_M", TypeName = "decimal(16, 3)")]
        public decimal? TotProfitM { get; set; }
        [Column("TOT_INCOME_M", TypeName = "decimal(16, 3)")]
        public decimal? TotIncomeM { get; set; }
        [Column("OUT_ACTUAL_INCOME_M", TypeName = "decimal(16, 3)")]
        public decimal? OutActualIncomeM { get; set; }
        [Column("OUT_REVISION_INCOME_M", TypeName = "decimal(16, 3)")]
        public decimal? OutRevisionIncomeM { get; set; }
        [Column("IN_ACTUAL_INCOME_M", TypeName = "decimal(16, 3)")]
        public decimal? InActualIncomeM { get; set; }
        [Column("IN_REVISION_INCOME_M", TypeName = "decimal(16, 3)")]
        public decimal? InRevisionIncomeM { get; set; }
        [Column("LENDING_PROF_M", TypeName = "decimal(16, 3)")]
        public decimal? LendingProfM { get; set; }
        [Column("FEE_M", TypeName = "decimal(16, 3)")]
        public decimal? FeeM { get; set; }
        [Column("TOT_FOREX_M", TypeName = "decimal(16, 3)")]
        public decimal? TotForexM { get; set; }
        [Column("OUT_FOREX_M", TypeName = "decimal(16, 3)")]
        public decimal? OutForexM { get; set; }
        [Column("IN_FOREX_M", TypeName = "decimal(16, 3)")]
        public decimal? InForexM { get; set; }
        [Column("PL_RELATED_BOND_M", TypeName = "decimal(16, 3)")]
        public decimal? PlRelatedBondM { get; set; }
        [Column("TOT_PROFIT_T", TypeName = "decimal(16, 3)")]
        public decimal? TotProfitT { get; set; }
        [Column("TOT_INCOME_T", TypeName = "decimal(16, 3)")]
        public decimal? TotIncomeT { get; set; }
        [Column("OUT_ACTUAL_INCOME_T", TypeName = "decimal(16, 3)")]
        public decimal? OutActualIncomeT { get; set; }
        [Column("OUT_REVISION_INCOME_T", TypeName = "decimal(16, 3)")]
        public decimal? OutRevisionIncomeT { get; set; }
        [Column("IN_ACTUAL_INCOME_T", TypeName = "decimal(16, 3)")]
        public decimal? InActualIncomeT { get; set; }
        [Column("IN_REVISION_INCOME_T", TypeName = "decimal(16, 3)")]
        public decimal? InRevisionIncomeT { get; set; }
        [Column("LENDING_PROF_T", TypeName = "decimal(16, 3)")]
        public decimal? LendingProfT { get; set; }
        [Column("FEE_T", TypeName = "decimal(16, 3)")]
        public decimal? FeeT { get; set; }
        [Column("TOT_FOREX_T", TypeName = "decimal(16, 3)")]
        public decimal? TotForexT { get; set; }
        [Column("OUT_FOREX_T", TypeName = "decimal(16, 3)")]
        public decimal? OutForexT { get; set; }
        [Column("IN_FOREX_T", TypeName = "decimal(16, 3)")]
        public decimal? InForexT { get; set; }
        [Column("PL_RELATED_BOND_T", TypeName = "decimal(16, 3)")]
        public decimal? PlRelatedBondT { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
