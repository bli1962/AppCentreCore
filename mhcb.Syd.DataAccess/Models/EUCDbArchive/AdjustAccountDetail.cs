using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("ADJUST_ACCOUNT_DETAIL", Schema = "EUC")]
    public partial class AdjustAccountDetail
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("FROM_DATE", TypeName = "datetime")]
        public DateTime? FromDate { get; set; }
        [Column("TO_DATE", TypeName = "datetime")]
        public DateTime? ToDate { get; set; }
        [Column("IBF_ID")]
        [StringLength(8)]
        public string IbfId { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_NAME")]
        [StringLength(30)]
        public string ActName { get; set; }
        [Column("REF_NO")]
        [StringLength(14)]
        public string RefNo { get; set; }
        [Column("PREV_2M_START_DATE", TypeName = "datetime")]
        public DateTime? Prev2mStartDate { get; set; }
        [Column("PREV_2M_START_BAL", TypeName = "decimal(19, 3)")]
        public decimal? Prev2mStartBal { get; set; }
        [Column("OPE_DATE", TypeName = "datetime")]
        public DateTime? OpeDate { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("COMMENT_CD")]
        [StringLength(1)]
        public string CommentCd { get; set; }
        [Column("REASON")]
        [StringLength(15)]
        public string Reason { get; set; }
        [Column("REMARKS")]
        [StringLength(30)]
        public string Remarks { get; set; }
        [Column("BASE_FILE_NAME")]
        [StringLength(8)]
        public string BaseFileName { get; set; }
        [Column("SUPPLEMENT")]
        [StringLength(7)]
        public string Supplement { get; set; }
        [Column("FUND_CD")]
        [StringLength(1)]
        public string FundCd { get; set; }
        [Column("DR_AMOUNT", TypeName = "decimal(19, 3)")]
        public decimal? DrAmount { get; set; }
        [Column("CR_AMOUNT", TypeName = "decimal(19, 3)")]
        public decimal? CrAmount { get; set; }
        [Column("PREV_M_START_DATE", TypeName = "datetime")]
        public DateTime? PrevMStartDate { get; set; }
        [Column("PREV_M_START_BAL", TypeName = "decimal(19, 3)")]
        public decimal? PrevMStartBal { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
