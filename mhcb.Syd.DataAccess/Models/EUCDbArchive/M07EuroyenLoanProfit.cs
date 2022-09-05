using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M07_EUROYEN_LOAN_PROFIT", Schema = "EUC")]
    public partial class M07EuroyenLoanProfit
    {
        [Column("MONTH_YEAR")]
        [StringLength(5)]
        public string MonthYear { get; set; }
        [Column("BOOK_BRANCH_NO")]
        [StringLength(3)]
        public string BookBranchNo { get; set; }
        [Column("APPL_BRANCH_NO")]
        [StringLength(3)]
        public string ApplBranchNo { get; set; }
        [Column("APPL_BRANCH_NAME")]
        [StringLength(40)]
        public string ApplBranchName { get; set; }
        [Column("SPREAD_INCOME_YEN", TypeName = "decimal(15, 0)")]
        public decimal? SpreadIncomeYen { get; set; }
        [Column("SPREAD_INCOME_US$", TypeName = "decimal(17, 2)")]
        public decimal? SpreadIncomeUs { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
