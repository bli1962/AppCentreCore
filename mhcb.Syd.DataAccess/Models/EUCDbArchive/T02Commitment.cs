using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T02_COMMITMENT", Schema = "EUC")]
    public partial class T02Commitment
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("BANK_ABBR")]
        [StringLength(12)]
        public string BankAbbr { get; set; }
        [Column("SUB_NO")]
        [StringLength(2)]
        public string SubNo { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("COMMIT_KIND")]
        [StringLength(6)]
        public string CommitKind { get; set; }
        [Column("REVOCABLE")]
        [StringLength(1)]
        public string Revocable { get; set; }
        [Column("TERM_REVOLV")]
        [StringLength(1)]
        public string TermRevolv { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("OD_FLG")]
        [StringLength(1)]
        public string OdFlg { get; set; }
        [Column("COMBINED_FLG")]
        [StringLength(1)]
        public string CombinedFlg { get; set; }
        [Column("AGENT_FLG")]
        [StringLength(1)]
        public string AgentFlg { get; set; }
        [Column("SUB_PARTOUT_FLG")]
        [StringLength(1)]
        public string SubPartoutFlg { get; set; }
        [Column("UNDISCLOSED_FLG")]
        [StringLength(1)]
        public string UndisclosedFlg { get; set; }
        [Column("WITH_RECOURSE_FLG")]
        [StringLength(1)]
        public string WithRecourseFlg { get; set; }
        [Column("CASH_FLOW_CD")]
        [StringLength(1)]
        public string CashFlowCd { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("COMMIT_START", TypeName = "datetime")]
        public DateTime? CommitStart { get; set; }
        [Column("COMMIT_END", TypeName = "datetime")]
        public DateTime? CommitEnd { get; set; }
        [Column("COMMIT_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? CommitAmount { get; set; }
        [Column("UNUSED_BAL", TypeName = "decimal(18, 3)")]
        public decimal? UnusedBal { get; set; }
        [Column("FEE_NO_1")]
        [StringLength(3)]
        public string FeeNo1 { get; set; }
        [Column("FEE_NO_2")]
        [StringLength(3)]
        public string FeeNo2 { get; set; }
        [Column("INITIAL_INPUT", TypeName = "datetime")]
        public DateTime? InitialInput { get; set; }
        [Column("UNUSED_BAL_ACM_M", TypeName = "decimal(20, 3)")]
        public decimal? UnusedBalAcmM { get; set; }
        [Column("UNUSED_BAL_ACM_T", TypeName = "decimal(20, 3)")]
        public decimal? UnusedBalAcmT { get; set; }
        [Column("UNUSED_BAL_PEAK_M", TypeName = "decimal(18, 3)")]
        public decimal? UnusedBalPeakM { get; set; }
        [Column("UNUSED_BAL_BOTTOM_M", TypeName = "decimal(18, 3)")]
        public decimal? UnusedBalBottomM { get; set; }
        [Column("UNUSED_BAL_PEAK_T", TypeName = "decimal(18, 3)")]
        public decimal? UnusedBalPeakT { get; set; }
        [Column("UNUSED_BAL_BOTTOM_T", TypeName = "decimal(18, 3)")]
        public decimal? UnusedBalBottomT { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
