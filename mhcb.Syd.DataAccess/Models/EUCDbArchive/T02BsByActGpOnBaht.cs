using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T02_BS_BY_ACT_GP_ON_BAHT", Schema = "EUC")]
    public partial class T02BsByActGpOnBaht
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("ACT_TYPE")]
        [StringLength(1)]
        public string ActType { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_NAME")]
        [StringLength(30)]
        public string ActName { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("TODAYS_DR", TypeName = "decimal(18, 3)")]
        public decimal? TodaysDr { get; set; }
        [Column("TODAYS_CR", TypeName = "decimal(18, 3)")]
        public decimal? TodaysCr { get; set; }
        [Column("BALANCE", TypeName = "decimal(18, 3)")]
        public decimal? Balance { get; set; }
        [Column("MONTH_ACM_DR", TypeName = "decimal(20, 3)")]
        public decimal? MonthAcmDr { get; set; }
        [Column("MONTH_ACM_CR", TypeName = "decimal(20, 3)")]
        public decimal? MonthAcmCr { get; set; }
        [Column("MONTH_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? MonthAcmBal { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
