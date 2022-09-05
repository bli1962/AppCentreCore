using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M03_AGENT_GUARANTEE", Schema = "EUC")]
    public partial class M03AgentGuarantee
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("FINAL_MATURITY", TypeName = "datetime")]
        public DateTime? FinalMaturity { get; set; }
        [Column("PARTICIPANT_ABBR")]
        [StringLength(12)]
        public string ParticipantAbbr { get; set; }
        [Column("PARTICIPANT_SUB_NO")]
        [StringLength(2)]
        public string ParticipantSubNo { get; set; }
        [Column("PARTICIPANT_STATUS")]
        [StringLength(4)]
        public string ParticipantStatus { get; set; }
        [Column("PARTICIPANT_ACT_CD")]
        [StringLength(5)]
        public string ParticipantActCd { get; set; }
        [Column("PARTICIPANT_ACT_ABBR")]
        [StringLength(15)]
        public string ParticipantActAbbr { get; set; }
        [Column("APPLIED_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? AppliedAmount { get; set; }
        [Column("USED_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? UsedAmount { get; set; }
        [Column("COMMIT_AVAIL")]
        [StringLength(1)]
        public string CommitAvail { get; set; }
        [Column("BALANCE_IN_PRM_CCY", TypeName = "decimal(18, 3)")]
        public decimal? BalanceInPrmCcy { get; set; }
        [Column("FEE_CALC_CD_1")]
        [StringLength(1)]
        public string FeeCalcCd1 { get; set; }
        [Column("FEE_CALC_CD_2")]
        [StringLength(1)]
        public string FeeCalcCd2 { get; set; }
        [Column("FEE_CALC_CD_3")]
        [StringLength(2)]
        public string FeeCalcCd3 { get; set; }
        [Column("FEE_CALC_CD_4")]
        [StringLength(1)]
        public string FeeCalcCd4 { get; set; }
        [Column("FEE_RCV_ID_1")]
        [StringLength(1)]
        public string FeeRcvId1 { get; set; }
        [Column("FEE_RCV_ID_2")]
        [StringLength(1)]
        public string FeeRcvId2 { get; set; }
        [Column("MULTI_CCY")]
        [StringLength(1)]
        public string MultiCcy { get; set; }
        [Column("FEE_RATE", TypeName = "decimal(9, 6)")]
        public decimal? FeeRate { get; set; }
        [Column("SPO_UNDISCLOSED")]
        [StringLength(1)]
        public string SpoUndisclosed { get; set; }
        [Column("SPO_WITH_RECOURSE")]
        [StringLength(1)]
        public string SpoWithRecourse { get; set; }
        [Column("SPO_GRT_BOOKED")]
        [StringLength(1)]
        public string SpoGrtBooked { get; set; }
        [Column("SPO_REPURCHASE", TypeName = "datetime")]
        public DateTime? SpoRepurchase { get; set; }
        [Column("GRT_BK")]
        [StringLength(1)]
        public string GrtBk { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
