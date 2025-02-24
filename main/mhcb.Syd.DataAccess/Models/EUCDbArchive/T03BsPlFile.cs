using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T03_BS_PL_FILE", Schema = "EUC")]
    public partial class T03BsPlFile
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("ON_MEMO_CD")]
        [StringLength(1)]
        public string OnMemoCd { get; set; }
        [Column("ACT_TYPE")]
        [StringLength(1)]
        public string ActType { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_NAME")]
        [StringLength(30)]
        public string ActName { get; set; }
        [Column("BS_CD")]
        [StringLength(5)]
        public string BsCd { get; set; }
        [Column("BS_NAME")]
        [StringLength(30)]
        public string BsName { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("BALANCE", TypeName = "decimal(18, 3)")]
        public decimal? Balance { get; set; }
        [Column("TODAYS_DR", TypeName = "decimal(18, 3)")]
        public decimal? TodaysDr { get; set; }
        [Column("TODAYS_CR", TypeName = "decimal(18, 3)")]
        public decimal? TodaysCr { get; set; }
        [Column("MONTH_ACM", TypeName = "decimal(20, 3)")]
        public decimal? MonthAcm { get; set; }
        [Column("MONTH_AVG", TypeName = "decimal(20, 3)")]
        public decimal? MonthAvg { get; set; }
        [Column("MONTH_ACM_DR", TypeName = "decimal(20, 3)")]
        public decimal? MonthAcmDr { get; set; }
        [Column("MONTH_ACM_CR", TypeName = "decimal(20, 3)")]
        public decimal? MonthAcmCr { get; set; }
        [Column("MONTH_ACM_VAL", TypeName = "decimal(20, 3)")]
        public decimal? MonthAcmVal { get; set; }
        [Column("MONTH_AVG_VAL", TypeName = "decimal(20, 3)")]
        public decimal? MonthAvgVal { get; set; }
        [Column("TERM_ACM", TypeName = "decimal(20, 3)")]
        public decimal? TermAcm { get; set; }
        [Column("TERM_AVG", TypeName = "decimal(20, 3)")]
        public decimal? TermAvg { get; set; }
        [Column("TERM_ACM_DR", TypeName = "decimal(20, 3)")]
        public decimal? TermAcmDr { get; set; }
        [Column("TERM_ACM_CR", TypeName = "decimal(20, 3)")]
        public decimal? TermAcmCr { get; set; }
        [Column("TERM_ACM_VAL", TypeName = "decimal(20, 3)")]
        public decimal? TermAcmVal { get; set; }
        [Column("TERM_AVG_VAL", TypeName = "decimal(20, 3)")]
        public decimal? TermAvgVal { get; set; }
        [Column("TERM_PA_BAL", TypeName = "decimal(18, 3)")]
        public decimal? TermPaBal { get; set; }
        [Column("MONTH_DAYS", TypeName = "decimal(2, 0)")]
        public decimal? MonthDays { get; set; }
        [Column("TERM_DAYS", TypeName = "decimal(3, 0)")]
        public decimal? TermDays { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
