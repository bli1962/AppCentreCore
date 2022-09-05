using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("CCY_CODE_Table")]
    public partial class CcyCodeTable
    {
        [Key]
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("DECIMAL_POINT")]
        public short? DecimalPoint { get; set; }
        [Column("SETPS_CD")]
        [StringLength(2)]
        public string SetpsCd { get; set; }
        [Column("MARK3_CD")]
        [StringLength(4)]
        public string Mark3Cd { get; set; }
        [Column("SWIFT_CD")]
        [StringLength(3)]
        public string SwiftCd { get; set; }
        [Column("DKB_SPECIAL_RATE_USD", TypeName = "decimal(8, 6)")]
        public decimal? DkbSpecialRateUsd { get; set; }
        [Column("DKB_SPECIAL_RATE_JPY", TypeName = "decimal(9, 5)")]
        public decimal? DkbSpecialRateJpy { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
    }
}
