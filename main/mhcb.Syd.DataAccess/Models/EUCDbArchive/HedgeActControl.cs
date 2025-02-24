using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("HEDGE_ACT_CONTROL", Schema = "EUC")]
    public partial class HedgeActControl
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("HEDGE_RATE", TypeName = "decimal(9, 7)")]
        public decimal? HedgeRate { get; set; }
        [Column("NON_HEDGE_RATE", TypeName = "decimal(9, 7)")]
        public decimal? NonHedgeRate { get; set; }
        [Column("HEDGE_FLG")]
        [StringLength(1)]
        public string HedgeFlg { get; set; }
        [Column("ADJ_SUB_NO")]
        [StringLength(2)]
        public string AdjSubNo { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
