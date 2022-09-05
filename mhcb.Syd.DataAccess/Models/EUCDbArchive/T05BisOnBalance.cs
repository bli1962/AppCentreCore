using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T05_BIS_ON_BALANCE", Schema = "EUC")]
    public partial class T05BisOnBalance
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("BIS_NO")]
        [StringLength(3)]
        public string BisNo { get; set; }
        [Column("ASSET_TYPE")]
        [StringLength(1)]
        public string AssetType { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("DEPT_CD")]
        [StringLength(2)]
        public string DeptCd { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("PARTICIPANT_ABBR")]
        [StringLength(12)]
        public string ParticipantAbbr { get; set; }
        [Column("PARTICIPANT_SUB_NO")]
        [StringLength(2)]
        public string ParticipantSubNo { get; set; }
        [Column("DD_NO")]
        [StringLength(3)]
        public string DdNo { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("DATA_ID")]
        [StringLength(1)]
        public string DataId { get; set; }
        [Column("GUARANTOR_NO")]
        [StringLength(5)]
        public string GuarantorNo { get; set; }
        [Column("COLLATERAL_NO")]
        [StringLength(5)]
        public string CollateralNo { get; set; }
        [Column("PRIME_CCY")]
        [StringLength(2)]
        public string PrimeCcy { get; set; }
        [Column("PRIME_CCY_ABBR")]
        [StringLength(4)]
        public string PrimeCcyAbbr { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("BALANCE_DD_CCY", TypeName = "decimal(18, 3)")]
        public decimal? BalanceDdCcy { get; set; }
        [Column("BALANCE_BC", TypeName = "decimal(18, 3)")]
        public decimal? BalanceBc { get; set; }
        [Column("RISK_WEIGHT", TypeName = "decimal(3, 0)")]
        public decimal? RiskWeight { get; set; }
        [Column("RISK_ASSET", TypeName = "decimal(18, 3)")]
        public decimal? RiskAsset { get; set; }
        [Column("ACR_ACT_CD")]
        [StringLength(5)]
        public string AcrActCd { get; set; }
        [Column("ACR_ACT_ABBR")]
        [StringLength(15)]
        public string AcrActAbbr { get; set; }
        [Column("ACR_BIS_NO")]
        [StringLength(3)]
        public string AcrBisNo { get; set; }
        [Column("ACR_RISK_WEIGHT", TypeName = "decimal(3, 0)")]
        public decimal? AcrRiskWeight { get; set; }
        [Column("ACR_INT_BC", TypeName = "decimal(18, 3)")]
        public decimal? AcrIntBc { get; set; }
        [Column("ACR_INT_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? AcrIntRiskAst { get; set; }
        [Column("EXP_PRE_BC", TypeName = "decimal(18, 3)")]
        public decimal? ExpPreBc { get; set; }
        [Column("EXP_PRE_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? ExpPreRiskAst { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
