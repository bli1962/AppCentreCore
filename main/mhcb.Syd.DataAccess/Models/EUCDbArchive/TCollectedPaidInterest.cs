using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T_COLLECTED_PAID_INTEREST", Schema = "EUC")]
    public partial class TCollectedPaidInterest
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("OPE_DATE", TypeName = "datetime")]
        public DateTime? OpeDate { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("DR_CR")]
        [StringLength(1)]
        public string DrCr { get; set; }
        [Column("AMOUNT_FC", TypeName = "decimal(19, 3)")]
        public decimal? AmountFc { get; set; }
        [Column("CONVERSION_RATE", TypeName = "decimal(9, 6)")]
        public decimal? ConversionRate { get; set; }
        [Column("AMOUNT_BC", TypeName = "decimal(19, 3)")]
        public decimal? AmountBc { get; set; }
        [Column("TRANS_CD")]
        [StringLength(1)]
        public string TransCd { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("DD_NO")]
        [StringLength(3)]
        public string DdNo { get; set; }
        [Column("ROLL_OVER_NO")]
        [StringLength(3)]
        public string RollOverNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("TRANS_NO")]
        [StringLength(5)]
        public string TransNo { get; set; }
        [Column("COMMENT_CD")]
        [StringLength(1)]
        public string CommentCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
