using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M03_SYSTEM_REVISION_DETAILS", Schema = "EUC")]
    public partial class M03SystemRevisionDetail
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("SYSTEM_CODE")]
        [StringLength(2)]
        public string SystemCode { get; set; }
        [Column("SEGMENT_TYPE")]
        [StringLength(3)]
        public string SegmentType { get; set; }
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
        [Column("PARTICIPANT_ABBR")]
        [StringLength(12)]
        public string ParticipantAbbr { get; set; }
        [Column("PARTICIPANT_SUB_NO")]
        [StringLength(2)]
        public string ParticipantSubNo { get; set; }
        [Column("DRAW_DOWN_NO")]
        [StringLength(3)]
        public string DrawDownNo { get; set; }
        [Column("ROLL_OVER_NO")]
        [StringLength(3)]
        public string RollOverNo { get; set; }
        [Column("COMMITMENT_FEE_FLG")]
        [StringLength(1)]
        public string CommitmentFeeFlg { get; set; }
        [Column("FEE_NO")]
        [StringLength(3)]
        public string FeeNo { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("INT_COLLECT_CODE")]
        [StringLength(1)]
        public string IntCollectCode { get; set; }
        [Column("CLOSING_DATE", TypeName = "datetime")]
        public DateTime? ClosingDate { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("DUE_DATE", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("PL_ACT_CD")]
        [StringLength(5)]
        public string PlActCd { get; set; }
        [Column("INT_ACCR", TypeName = "decimal(18, 3)")]
        public decimal? IntAccr { get; set; }
        [Column("INT_ACCR_BC", TypeName = "decimal(18, 3)")]
        public decimal? IntAccrBc { get; set; }
        [Column("INT_PAYABLE", TypeName = "decimal(18, 3)")]
        public decimal? IntPayable { get; set; }
        [Column("INT_PAYABLE_BC", TypeName = "decimal(18, 3)")]
        public decimal? IntPayableBc { get; set; }
        [Column("INT_UNEARNED", TypeName = "decimal(18, 3)")]
        public decimal? IntUnearned { get; set; }
        [Column("INT_UNEARNED_BC", TypeName = "decimal(18, 3)")]
        public decimal? IntUnearnedBc { get; set; }
        [Column("INT_PREPAID", TypeName = "decimal(18, 3)")]
        public decimal? IntPrepaid { get; set; }
        [Column("INT_PREPAID_BC", TypeName = "decimal(18, 3)")]
        public decimal? IntPrepaidBc { get; set; }
        [Column("OVERDUE_FLG")]
        [StringLength(1)]
        public string OverdueFlg { get; set; }
        [Column("DELAYED_FLG")]
        [StringLength(1)]
        public string DelayedFlg { get; set; }
        [Column("MARGIN_FLG")]
        [StringLength(1)]
        public string MarginFlg { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
        [Column("FIXED_FLOAT")]
        [StringLength(1)]
        public string FixedFloat { get; set; }
        [Column("INTERNAL_RATE_TYPE")]
        [StringLength(1)]
        public string InternalRateType { get; set; }
        [Column("INTERNAL_RATE", TypeName = "decimal(9, 6)")]
        public decimal? InternalRate { get; set; }
        [Column("COLLECT_DATE", TypeName = "datetime")]
        public DateTime? CollectDate { get; set; }
        [Column("CALCULATED_INT", TypeName = "decimal(18, 3)")]
        public decimal? CalculatedInt { get; set; }
        [Column("CALCULATED_INT_BC", TypeName = "decimal(18, 3)")]
        public decimal? CalculatedIntBc { get; set; }
        [Column("REALIZED_INT", TypeName = "decimal(18, 3)")]
        public decimal? RealizedInt { get; set; }
        [Column("REALIZED_INT_BC", TypeName = "decimal(18, 3)")]
        public decimal? RealizedIntBc { get; set; }
        [Column("NON_ACCR", TypeName = "decimal(18, 3)")]
        public decimal? NonAccr { get; set; }
        [Column("NON_ACCR_BC", TypeName = "decimal(18, 3)")]
        public decimal? NonAccrBc { get; set; }
        [Column("INT_PART_GIVEN_UP", TypeName = "decimal(18, 3)")]
        public decimal? IntPartGivenUp { get; set; }
        [Column("INT_PART_GIVEN_UP_BC", TypeName = "decimal(18, 3)")]
        public decimal? IntPartGivenUpBc { get; set; }
        [Column("INT_WRITTEN_OFF", TypeName = "decimal(18, 3)")]
        public decimal? IntWrittenOff { get; set; }
        [Column("INT_WRITTEN_OFF_BC", TypeName = "decimal(18, 3)")]
        public decimal? IntWrittenOffBc { get; set; }
        [Column("ON_MEMO_FLG")]
        [StringLength(1)]
        public string OnMemoFlg { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
