using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("COLLATERAL_CODE_TABLE", Schema = "EUC")]
    public partial class CollateralCodeTable
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("COLLATERAL_CD")]
        [StringLength(2)]
        public string CollateralCd { get; set; }
        [Column("COLLATERAL_NAME")]
        [StringLength(7)]
        public string CollateralName { get; set; }
        [Column("COLLATERAL_RANK")]
        [StringLength(2)]
        public string CollateralRank { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
