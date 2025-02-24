using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    public partial class ViewEucCustomerAccountNo
    {
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Required]
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Required]
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Required]
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Required]
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Required]
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
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
    }
}
