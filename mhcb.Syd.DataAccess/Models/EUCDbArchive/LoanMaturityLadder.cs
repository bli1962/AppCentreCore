using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("LOAN_MATURITY_LADDER", Schema = "EUC")]
    public partial class LoanMaturityLadder
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("DEPT_CD")]
        [StringLength(2)]
        public string DeptCd { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("BRANCH_NAME")]
        [StringLength(25)]
        public string BranchName { get; set; }
        [Column("ACT_NAME")]
        [StringLength(30)]
        public string ActName { get; set; }
        [Column("SIGNING_DATE", TypeName = "datetime")]
        public DateTime? SigningDate { get; set; }
        [Column("APPLICATION_DUE", TypeName = "datetime")]
        public DateTime? ApplicationDue { get; set; }
        [Column("PRIME_CCY_CD")]
        [StringLength(2)]
        public string PrimeCcyCd { get; set; }
        [Column("PRIME_CCY_ABBR")]
        [StringLength(4)]
        public string PrimeCcyAbbr { get; set; }
        [Column("BALANCE", TypeName = "decimal(18, 3)")]
        public decimal? Balance { get; set; }
        [Column("MONTH1", TypeName = "datetime")]
        public DateTime? Month1 { get; set; }
        [Column("MONTH_END_BAL1", TypeName = "decimal(18, 3)")]
        public decimal? MonthEndBal1 { get; set; }
        [Column("MONTH2", TypeName = "datetime")]
        public DateTime? Month2 { get; set; }
        [Column("MONTH_END_BAL2", TypeName = "decimal(18, 3)")]
        public decimal? MonthEndBal2 { get; set; }
        [Column("MONTH3", TypeName = "datetime")]
        public DateTime? Month3 { get; set; }
        [Column("MONTH_END_BAL3", TypeName = "decimal(18, 3)")]
        public decimal? MonthEndBal3 { get; set; }
        [Column("MONTH4", TypeName = "datetime")]
        public DateTime? Month4 { get; set; }
        [Column("MONTH_END_BAL4", TypeName = "decimal(18, 3)")]
        public decimal? MonthEndBal4 { get; set; }
        [Column("MONTH5", TypeName = "datetime")]
        public DateTime? Month5 { get; set; }
        [Column("MONTH_END_BAL5", TypeName = "decimal(18, 3)")]
        public decimal? MonthEndBal5 { get; set; }
        [Column("MONTH6", TypeName = "datetime")]
        public DateTime? Month6 { get; set; }
        [Column("MONTH_END_BAL6", TypeName = "decimal(18, 3)")]
        public decimal? MonthEndBal6 { get; set; }
        [Column("MONTH7", TypeName = "datetime")]
        public DateTime? Month7 { get; set; }
        [Column("MONTH_END_BAL7", TypeName = "decimal(18, 3)")]
        public decimal? MonthEndBal7 { get; set; }
        [Column("MONTH8", TypeName = "datetime")]
        public DateTime? Month8 { get; set; }
        [Column("MONTH_END_BAL8", TypeName = "decimal(18, 3)")]
        public decimal? MonthEndBal8 { get; set; }
        [Column("MONTH9", TypeName = "datetime")]
        public DateTime? Month9 { get; set; }
        [Column("MONTH_END_BAL9", TypeName = "decimal(18, 3)")]
        public decimal? MonthEndBal9 { get; set; }
        [Column("MONTH10", TypeName = "datetime")]
        public DateTime? Month10 { get; set; }
        [Column("MONTH_END_BAL10", TypeName = "decimal(18, 3)")]
        public decimal? MonthEndBal10 { get; set; }
        [Column("MONTH11", TypeName = "datetime")]
        public DateTime? Month11 { get; set; }
        [Column("MONTH_END_BAL11", TypeName = "decimal(18, 3)")]
        public decimal? MonthEndBal11 { get; set; }
        [Column("YEAR1", TypeName = "datetime")]
        public DateTime? Year1 { get; set; }
        [Column("YEAR_END_BAL1", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal1 { get; set; }
        [Column("YEAR2", TypeName = "datetime")]
        public DateTime? Year2 { get; set; }
        [Column("YEAR_END_BAL2", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal2 { get; set; }
        [Column("YEAR3", TypeName = "datetime")]
        public DateTime? Year3 { get; set; }
        [Column("YEAR_END_BAL3", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal3 { get; set; }
        [Column("YEAR4", TypeName = "datetime")]
        public DateTime? Year4 { get; set; }
        [Column("YEAR_END_BAL4", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal4 { get; set; }
        [Column("YEAR5", TypeName = "datetime")]
        public DateTime? Year5 { get; set; }
        [Column("YEAR_END_BAL5", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal5 { get; set; }
        [Column("YEAR6", TypeName = "datetime")]
        public DateTime? Year6 { get; set; }
        [Column("YEAR_END_BAL6", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal6 { get; set; }
        [Column("YEAR7", TypeName = "datetime")]
        public DateTime? Year7 { get; set; }
        [Column("YEAR_END_BAL7", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal7 { get; set; }
        [Column("YEAR8", TypeName = "datetime")]
        public DateTime? Year8 { get; set; }
        [Column("YEAR_END_BAL8", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal8 { get; set; }
        [Column("YEAR9", TypeName = "datetime")]
        public DateTime? Year9 { get; set; }
        [Column("YEAR_END_BAL9", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal9 { get; set; }
        [Column("YEAR10", TypeName = "datetime")]
        public DateTime? Year10 { get; set; }
        [Column("YEAR_END_BAL10", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal10 { get; set; }
        [Column("YEAR11", TypeName = "datetime")]
        public DateTime? Year11 { get; set; }
        [Column("YEAR_END_BAL11", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal11 { get; set; }
        [Column("YEAR12", TypeName = "datetime")]
        public DateTime? Year12 { get; set; }
        [Column("YEAR_END_BAL12", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal12 { get; set; }
        [Column("YEAR13", TypeName = "datetime")]
        public DateTime? Year13 { get; set; }
        [Column("YEAR_END_BAL13", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal13 { get; set; }
        [Column("YEAR14", TypeName = "datetime")]
        public DateTime? Year14 { get; set; }
        [Column("YEAR_END_BAL14", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal14 { get; set; }
        [Column("YEAR15", TypeName = "datetime")]
        public DateTime? Year15 { get; set; }
        [Column("YEAR_END_BAL15", TypeName = "decimal(18, 3)")]
        public decimal? YearEndBal15 { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
