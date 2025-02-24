using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("MONTHLY_CUSTOMER_BALANCE", Schema = "EUC")]
    public partial class MonthlyCustomerBalance
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("DEPT_CD")]
        [StringLength(2)]
        public string DeptCd { get; set; }
        [Column("OFFICER_CD")]
        [StringLength(4)]
        public string OfficerCd { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("MONTH01")]
        [StringLength(6)]
        public string Month01 { get; set; }
        [Column("MONTH01_AVG_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month01AvgBal { get; set; }
        [Column("MONTH01_BTM_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month01BtmBal { get; set; }
        [Column("MONTH01_PEAK_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month01PeakBal { get; set; }
        [Column("MONTH01_END_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month01EndBal { get; set; }
        [Column("MONTH02")]
        [StringLength(6)]
        public string Month02 { get; set; }
        [Column("MONTH02_AVG_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month02AvgBal { get; set; }
        [Column("MONTH02_BTM_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month02BtmBal { get; set; }
        [Column("MONTH02_PEAK_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month02PeakBal { get; set; }
        [Column("MONTH02_END_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month02EndBal { get; set; }
        [Column("MONTH03")]
        [StringLength(6)]
        public string Month03 { get; set; }
        [Column("MONTH03_AVG_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month03AvgBal { get; set; }
        [Column("MONTH03_BTM_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month03BtmBal { get; set; }
        [Column("MONTH03_PEAK_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month03PeakBal { get; set; }
        [Column("MONTH03_END_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month03EndBal { get; set; }
        [Column("MONTH04")]
        [StringLength(6)]
        public string Month04 { get; set; }
        [Column("MONTH04_AVG_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month04AvgBal { get; set; }
        [Column("MONTH04_BTM_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month04BtmBal { get; set; }
        [Column("MONTH04_PEAK_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month04PeakBal { get; set; }
        [Column("MONTH04_END_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month04EndBal { get; set; }
        [Column("MONTH05")]
        [StringLength(6)]
        public string Month05 { get; set; }
        [Column("MONTH05_AVG_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month05AvgBal { get; set; }
        [Column("MONTH05_BTM_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month05BtmBal { get; set; }
        [Column("MONTH05_PEAK_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month05PeakBal { get; set; }
        [Column("MONTH05_END_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month05EndBal { get; set; }
        [Column("MONTH06")]
        [StringLength(6)]
        public string Month06 { get; set; }
        [Column("MONTH06_AVG_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month06AvgBal { get; set; }
        [Column("MONTH06_BTM_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month06BtmBal { get; set; }
        [Column("MONTH06_PEAK_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month06PeakBal { get; set; }
        [Column("MONTH06_END_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month06EndBal { get; set; }
        [Column("MONTH07")]
        [StringLength(6)]
        public string Month07 { get; set; }
        [Column("MONTH07_AVG_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month07AvgBal { get; set; }
        [Column("MONTH07_BTM_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month07BtmBal { get; set; }
        [Column("MONTH07_PEAK_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month07PeakBal { get; set; }
        [Column("MONTH07_END_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month07EndBal { get; set; }
        [Column("MONTH08")]
        [StringLength(6)]
        public string Month08 { get; set; }
        [Column("MONTH08_AVG_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month08AvgBal { get; set; }
        [Column("MONTH08_BTM_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month08BtmBal { get; set; }
        [Column("MONTH08_PEAK_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month08PeakBal { get; set; }
        [Column("MONTH08_END_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month08EndBal { get; set; }
        [Column("MONTH09")]
        [StringLength(6)]
        public string Month09 { get; set; }
        [Column("MONTH09_AVG_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month09AvgBal { get; set; }
        [Column("MONTH09_BTM_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month09BtmBal { get; set; }
        [Column("MONTH09_PEAK_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month09PeakBal { get; set; }
        [Column("MONTH09_END_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month09EndBal { get; set; }
        [Column("MONTH10")]
        [StringLength(6)]
        public string Month10 { get; set; }
        [Column("MONTH10_AVG_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month10AvgBal { get; set; }
        [Column("MONTH10_BTM_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month10BtmBal { get; set; }
        [Column("MONTH10_PEAK_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month10PeakBal { get; set; }
        [Column("MONTH10_END_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month10EndBal { get; set; }
        [Column("MONTH11")]
        [StringLength(6)]
        public string Month11 { get; set; }
        [Column("MONTH11_AVG_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month11AvgBal { get; set; }
        [Column("MONTH11_BTM_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month11BtmBal { get; set; }
        [Column("MONTH11_PEAK_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month11PeakBal { get; set; }
        [Column("MONTH11_END_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month11EndBal { get; set; }
        [Column("MONTH12")]
        [StringLength(6)]
        public string Month12 { get; set; }
        [Column("MONTH12_AVG_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month12AvgBal { get; set; }
        [Column("MONTH12_BTM_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month12BtmBal { get; set; }
        [Column("MONTH12_PEAK_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month12PeakBal { get; set; }
        [Column("MONTH12_END_BAL", TypeName = "decimal(7, 0)")]
        public decimal? Month12EndBal { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
