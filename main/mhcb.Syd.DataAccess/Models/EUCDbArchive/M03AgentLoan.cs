using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M03_AGENT_LOAN", Schema = "EUC")]
    public partial class M03AgentLoan
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
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("FINAL_MATURITY", TypeName = "datetime")]
        public DateTime? FinalMaturity { get; set; }
        [Column("PARTICIPANT_ABBR")]
        [StringLength(12)]
        public string ParticipantAbbr { get; set; }
        [Column("PARTICIPANT_SUB_NO")]
        [StringLength(2)]
        public string ParticipantSubNo { get; set; }
        [Column("DD_NO")]
        [StringLength(4)]
        public string DdNo { get; set; }
        [Column("RO_NO")]
        [StringLength(5)]
        public string RoNo { get; set; }
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
        [Column("INT_CALC_CD_1")]
        [StringLength(1)]
        public string IntCalcCd1 { get; set; }
        [Column("INT_CALC_CD_2")]
        [StringLength(1)]
        public string IntCalcCd2 { get; set; }
        [Column("INT_CALC_CD_3")]
        [StringLength(2)]
        public string IntCalcCd3 { get; set; }
        [Column("INT_CALC_CD_4")]
        [StringLength(1)]
        public string IntCalcCd4 { get; set; }
        [Column("INT_RCV_ID_1")]
        [StringLength(1)]
        public string IntRcvId1 { get; set; }
        [Column("INT_RCV_ID_2")]
        [StringLength(1)]
        public string IntRcvId2 { get; set; }
        [Column("INT_RCV_ID_3")]
        [StringLength(1)]
        public string IntRcvId3 { get; set; }
        [Column("MULTI_CCY")]
        [StringLength(1)]
        public string MultiCcy { get; set; }
        [Column("FIXED_FLOAT")]
        [StringLength(1)]
        public string FixedFloat { get; set; }
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
        [Column("INT_RATE", TypeName = "decimal(9, 6)")]
        public decimal? IntRate { get; set; }
        [Column("BASE_RATE_CD")]
        [StringLength(2)]
        public string BaseRateCd { get; set; }
        [Column("BASE_RATE_SUB_CD")]
        [StringLength(2)]
        public string BaseRateSubCd { get; set; }
        [Column("BASE_RATE_TERM")]
        [StringLength(1)]
        public string BaseRateTerm { get; set; }
        [Column("SPREAD", TypeName = "decimal(9, 6)")]
        public decimal? Spread { get; set; }
        [Column("SECURITY_CD")]
        [StringLength(1)]
        public string SecurityCd { get; set; }
        [Column("SECURITY_INFO")]
        [StringLength(12)]
        public string SecurityInfo { get; set; }
        [Column("SOLD_DATE", TypeName = "datetime")]
        public DateTime? SoldDate { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
