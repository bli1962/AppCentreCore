using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T03_FEE_AND_CHARGE", Schema = "EUC")]
    public partial class T03FeeAndCharge
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("PARTICIPANT_ABBR")]
        [StringLength(12)]
        public string ParticipantAbbr { get; set; }
        [Column("REF_SUB_NO")]
        [StringLength(2)]
        public string RefSubNo { get; set; }
        [Column("FEE_NO")]
        [StringLength(3)]
        public string FeeNo { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("FEE_KIND")]
        [StringLength(5)]
        public string FeeKind { get; set; }
        [Column("PRINCIPAL_KIND_1")]
        [StringLength(2)]
        public string PrincipalKind1 { get; set; }
        [Column("PRINCIPAL_KIND_2")]
        [StringLength(1)]
        public string PrincipalKind2 { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("FEE_START_DATE", TypeName = "datetime")]
        public DateTime? FeeStartDate { get; set; }
        [Column("FEE_END_DATE", TypeName = "datetime")]
        public DateTime? FeeEndDate { get; set; }
        [Column("CEIL_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? CeilAmount { get; set; }
        [Column("FLOOR_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? FloorAmount { get; set; }
        [Column("FEE_RATE", TypeName = "decimal(9, 6)")]
        public decimal? FeeRate { get; set; }
        [Column("AMOUNT_RATIO", TypeName = "decimal(10, 6)")]
        public decimal? AmountRatio { get; set; }
        [Column("LAST_COLLECTION", TypeName = "datetime")]
        public DateTime? LastCollection { get; set; }
        [Column("TTL_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? TtlAmount { get; set; }
        [Column("COLLECTED_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? CollectedAmount { get; set; }
        [Column("NEXT_COLLECTION", TypeName = "datetime")]
        public DateTime? NextCollection { get; set; }
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
        [Column("ACCRUAL_FLG")]
        [StringLength(1)]
        public string AccrualFlg { get; set; }
        [Column("TAX_CD")]
        [StringLength(1)]
        public string TaxCd { get; set; }
        [Column("TAX_RATE", TypeName = "decimal(10, 6)")]
        public decimal? TaxRate { get; set; }
        [Column("SECURITY_CD")]
        [StringLength(1)]
        public string SecurityCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
