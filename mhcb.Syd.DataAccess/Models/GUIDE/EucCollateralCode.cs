using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("EUC_COLLATERAL_CODE")]
    public partial class EucCollateralCode
    {
        [Key]
        [Column("COLLATERAL_CD")]
        [StringLength(2)]
        public string CollateralCd { get; set; }
        [Column("COLLATERAL_NAME")]
        [StringLength(7)]
        public string CollateralName { get; set; }
        [Column("COLLATERAL_RANK")]
        [StringLength(2)]
        public string CollateralRank { get; set; }
        [Key]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
    }
}
