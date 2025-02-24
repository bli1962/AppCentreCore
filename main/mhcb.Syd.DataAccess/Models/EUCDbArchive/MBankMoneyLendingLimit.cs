using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M_BANK_MONEY_LENDING_LIMIT", Schema = "EUC")]
    public partial class MBankMoneyLendingLimit
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("TERM_BASE")]
        [StringLength(3)]
        public string TermBase { get; set; }
        [Column("BANK_GROUP_ABBR")]
        [StringLength(12)]
        public string BankGroupAbbr { get; set; }
        [Column("BANK_GROUP_SH_LIMT", TypeName = "decimal(20, 3)")]
        public decimal? BankGroupShLimt { get; set; }
        [Column("BANK_GROUP_LG_LIMT", TypeName = "decimal(20, 3)")]
        public decimal? BankGroupLgLimt { get; set; }
        [Column("SUBLIMIT_BANK_ABBR")]
        [StringLength(12)]
        public string SublimitBankAbbr { get; set; }
        [Column("SUBLMT_BANK_SH_LIMT", TypeName = "decimal(20, 3)")]
        public decimal? SublmtBankShLimt { get; set; }
        [Column("SUBLMT_BANK_LG_LIMT", TypeName = "decimal(20, 3)")]
        public decimal? SublmtBankLgLimt { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_KIND")]
        [StringLength(3)]
        public string RefKind { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("SH_LG_TYPE")]
        [StringLength(1)]
        public string ShLgType { get; set; }
        [Column("TODAY", TypeName = "datetime")]
        public DateTime? Today { get; set; }
        [Column("TODAY_BAL", TypeName = "decimal(22, 3)")]
        public decimal? TodayBal { get; set; }
        [Column("TOMORROW", TypeName = "datetime")]
        public DateTime? Tomorrow { get; set; }
        [Column("TOMORROW_BAL", TypeName = "decimal(22, 3)")]
        public decimal? TomorrowBal { get; set; }
        [Column("SPOT_DATE", TypeName = "datetime")]
        public DateTime? SpotDate { get; set; }
        [Column("SPOT_BAL", TypeName = "decimal(22, 3)")]
        public decimal? SpotBal { get; set; }
        [Column("SPOT_NEXT_DATE", TypeName = "datetime")]
        public DateTime? SpotNextDate { get; set; }
        [Column("SPOT_NEXT_BAL", TypeName = "decimal(22, 3)")]
        public decimal? SpotNextBal { get; set; }
        [Column("BALANCE", TypeName = "decimal(22, 3)")]
        public decimal? Balance { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
