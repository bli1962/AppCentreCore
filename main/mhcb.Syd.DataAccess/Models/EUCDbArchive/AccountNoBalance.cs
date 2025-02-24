using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Table("ACCOUNT_NO_BALANCE", Schema = "EUC")]
    [Index(nameof(DataDate), Name = "IX_ACCOUNT_NO_BALANCE")]
    [Index(nameof(DataDate), Name = "IX_ACCOUNT_NO_BALANCE_1")]
    public partial class AccountNoBalance
    {
        [Key]
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Key]
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Key]
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Key]
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Key]
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Key]
        [Column("ACT_NO")]
        [StringLength(12)]
        public string ActNo { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("ACT_NAME")]
        [StringLength(30)]
        public string ActName { get; set; }
        [Column("ACT_SHORT_NAME")]
        [StringLength(12)]
        public string ActShortName { get; set; }
        [Column("BAL_BOOK", TypeName = "decimal(16, 3)")]
        public decimal? BalBook { get; set; }
        [Column("BAL_AVAIL", TypeName = "decimal(16, 3)")]
        public decimal? BalAvail { get; set; }
        [Column("WARNING_CD")]
        [StringLength(1)]
        public string WarningCd { get; set; }
        [Column("OVERDRAFT_CD")]
        [StringLength(1)]
        public string OverdraftCd { get; set; }
        [Column("BASE_RATE_CD")]
        [StringLength(2)]
        public string BaseRateCd { get; set; }
        [Column("SPREAD", TypeName = "decimal(9, 7)")]
        public decimal? Spread { get; set; }
        [Column("BASE_RATE_CD_OD")]
        [StringLength(2)]
        public string BaseRateCdOd { get; set; }
        [Column("SPREAD_OD", TypeName = "decimal(9, 7)")]
        public decimal? SpreadOd { get; set; }
        [Column("REMARKS")]
        [StringLength(20)]
        public string Remarks { get; set; }
        [Column("OPENING_DATE", TypeName = "datetime")]
        public DateTime? OpeningDate { get; set; }
        [Column("CLOSING_DATE", TypeName = "datetime")]
        public DateTime? ClosingDate { get; set; }
        [Column("CALCULATION_CODE")]
        [StringLength(2)]
        public string CalculationCode { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("LAST_DR_CR_DATE", TypeName = "datetime")]
        public DateTime? LastDrCrDate { get; set; }
        [Column("DR_TOTAL", TypeName = "decimal(16, 3)")]
        public decimal? DrTotal { get; set; }
        [Column("CR_TOTAL", TypeName = "decimal(16, 3)")]
        public decimal? CrTotal { get; set; }
        [Column("BAL_BOOK_ACM_M", TypeName = "decimal(18, 3)")]
        public decimal? BalBookAcmM { get; set; }
        [Column("BAL_VALUE_ACM_M", TypeName = "decimal(18, 3)")]
        public decimal? BalValueAcmM { get; set; }
        [Column("BAL_BOOK_ACM_T", TypeName = "decimal(18, 3)")]
        public decimal? BalBookAcmT { get; set; }
        [Column("BAL_VALUE_ACM_T", TypeName = "decimal(18, 3)")]
        public decimal? BalValueAcmT { get; set; }
        [Column("BAL_PEAK_M", TypeName = "decimal(16, 3)")]
        public decimal? BalPeakM { get; set; }
        [Column("BAL_BOTTOM_M", TypeName = "decimal(16, 3)")]
        public decimal? BalBottomM { get; set; }
        [Column("BAL_PEAK_T", TypeName = "decimal(16, 3)")]
        public decimal? BalPeakT { get; set; }
        [Column("BAL_BOTTOM_T", TypeName = "decimal(16, 3)")]
        public decimal? BalBottomT { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
