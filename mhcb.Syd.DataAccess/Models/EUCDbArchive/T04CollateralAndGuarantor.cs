using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T04_COLLATERAL_AND_GUARANTOR", Schema = "EUC")]
    public partial class T04CollateralAndGuarantor
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("SERIAL_NO")]
        [StringLength(5)]
        public string SerialNo { get; set; }
        [Column("RELATED_APPL_NO")]
        [StringLength(7)]
        public string RelatedApplNo { get; set; }
        [Column("RELATED_REF_NO")]
        [StringLength(12)]
        public string RelatedRefNo { get; set; }
        [Column("PARTICIPANT_ABBR")]
        [StringLength(12)]
        public string ParticipantAbbr { get; set; }
        [Column("PARTICIPANT_SUB_NO")]
        [StringLength(2)]
        public string ParticipantSubNo { get; set; }
        [Column("COL_TYPE_CD")]
        [StringLength(2)]
        public string ColTypeCd { get; set; }
        [Column("COL_TYPE_NAME")]
        [StringLength(7)]
        public string ColTypeName { get; set; }
        [Column("POSITION_CD")]
        [StringLength(1)]
        public string PositionCd { get; set; }
        [Column("LIMITED_FLG")]
        [StringLength(1)]
        public string LimitedFlg { get; set; }
        [Column("REVOLVING_FLG")]
        [StringLength(1)]
        public string RevolvingFlg { get; set; }
        [Column("GRT_TYPE")]
        [StringLength(1)]
        public string GrtType { get; set; }
        [Column("GRT_WEIGHT", TypeName = "decimal(5, 2)")]
        public decimal? GrtWeight { get; set; }
        [Column("COL_CCY_CD")]
        [StringLength(2)]
        public string ColCcyCd { get; set; }
        [Column("COL_CCY_ABBR")]
        [StringLength(4)]
        public string ColCcyAbbr { get; set; }
        [Column("COL_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? ColAmount { get; set; }
        [Column("WITHDRAWAL_CCY_CD")]
        [StringLength(2)]
        public string WithdrawalCcyCd { get; set; }
        [Column("WITHDRAWAL_CCY_ABBR")]
        [StringLength(4)]
        public string WithdrawalCcyAbbr { get; set; }
        [Column("WITHDRAWAL_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? WithdrawalAmount { get; set; }
        [Column("PERIOD", TypeName = "datetime")]
        public DateTime? Period { get; set; }
        [Column("GRT_ABBR")]
        [StringLength(12)]
        public string GrtAbbr { get; set; }
        [Column("COL_DEPO_REF_NO")]
        [StringLength(12)]
        public string ColDepoRefNo { get; set; }
        [Column("COL_DEPO_CUST_ABBR")]
        [StringLength(12)]
        public string ColDepoCustAbbr { get; set; }
        [Column("COL_DEPO_ACT_CD")]
        [StringLength(5)]
        public string ColDepoActCd { get; set; }
        [Column("COL_DEPO_ACT_ABBR")]
        [StringLength(15)]
        public string ColDepoActAbbr { get; set; }
        [Column("COL_DEPO_CCY_CD")]
        [StringLength(2)]
        public string ColDepoCcyCd { get; set; }
        [Column("COL_DEPO_CCY_ABBR")]
        [StringLength(4)]
        public string ColDepoCcyAbbr { get; set; }
        [Column("COL_DEPO_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? ColDepoAmount { get; set; }
        [Column("COL_DEPO_IBF_ID")]
        [StringLength(1)]
        public string ColDepoIbfId { get; set; }
        [Column("COL_SEC_ISSUER")]
        [StringLength(12)]
        public string ColSecIssuer { get; set; }
        [Column("COL_SEC_TYPE")]
        [StringLength(4)]
        public string ColSecType { get; set; }
        [Column("INSUARANCE_MATURITY", TypeName = "datetime")]
        public DateTime? InsuaranceMaturity { get; set; }
        [Column("REGISTERED_DATE", TypeName = "datetime")]
        public DateTime? RegisteredDate { get; set; }
        [Column("LAST_REVALUATION", TypeName = "datetime")]
        public DateTime? LastRevaluation { get; set; }
        [Column("REVALUATION_CYCLE")]
        [StringLength(2)]
        public string RevaluationCycle { get; set; }
        [Column("NEXT_REVALUATION", TypeName = "datetime")]
        public DateTime? NextRevaluation { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
