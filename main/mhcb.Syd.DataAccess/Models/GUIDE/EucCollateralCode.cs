using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("EUC_COLLATERAL_CODE", Schema = "dbo")]
    public partial class EucCollateralCode
    {
        [Key]
        [Column("COLLATERAL_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string CollateralCd { get; set; }
        [Column("COLLATERAL_NAME")]
        [StringLength(7)]
        [Unicode(false)]
        public string CollateralName { get; set; }
        [Column("COLLATERAL_RANK")]
        [StringLength(2)]
        [Unicode(false)]
        public string CollateralRank { get; set; }
        [Key]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        [Unicode(false)]
        public string BranchNo { get; set; }
    }
}
