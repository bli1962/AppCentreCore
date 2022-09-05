using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("HEDGE_ACCOUNT_DETAIL", Schema = "EUC")]
    public partial class HedgeAccountDetail
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("REF_SUB_NO")]
        [StringLength(2)]
        public string RefSubNo { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("HEDGE_RE_CD")]
        [StringLength(1)]
        public string HedgeReCd { get; set; }
        [Column("POST_TYPE")]
        [StringLength(1)]
        public string PostType { get; set; }
        [Column("POST_AMT", TypeName = "decimal(18, 3)")]
        public decimal? PostAmt { get; set; }
        [Column("DR_ACT_CD")]
        [StringLength(5)]
        public string DrActCd { get; set; }
        [Column("CR_ACT_CD")]
        [StringLength(5)]
        public string CrActCd { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("DELETE_DATE", TypeName = "datetime")]
        public DateTime? DeleteDate { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
