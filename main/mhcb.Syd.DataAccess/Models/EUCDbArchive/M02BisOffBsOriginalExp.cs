using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M02_BIS_OFF_BS_ORIGINAL_EXP", Schema = "EUC")]
    public partial class M02BisOffBsOriginalExp
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("TRANSACTION_ID")]
        [StringLength(2)]
        public string TransactionId { get; set; }
        [Column("BIS_NO")]
        [StringLength(3)]
        public string BisNo { get; set; }
        [Column("ORIGINAL_EXP_TYPE")]
        [StringLength(1)]
        public string OriginalExpType { get; set; }
        [Column("ORIGINAL_EXP_YEAR", TypeName = "decimal(3, 0)")]
        public decimal? OriginalExpYear { get; set; }
        [Column("DEPT_CD")]
        [StringLength(2)]
        public string DeptCd { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
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
        [Column("RISK_WEIGHT", TypeName = "decimal(3, 0)")]
        public decimal? RiskWeight { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("NOTINAL_IN_FC", TypeName = "decimal(18, 3)")]
        public decimal? NotinalInFc { get; set; }
        [Column("NOTINAL_IN_BC", TypeName = "decimal(18, 3)")]
        public decimal? NotinalInBc { get; set; }
        [Column("TERM_RISK", TypeName = "decimal(5, 1)")]
        public decimal? TermRisk { get; set; }
        [Column("CREDIT_RISK_AMOUNT", TypeName = "decimal(18, 3)")]
        public decimal? CreditRiskAmount { get; set; }
        [Column("RISK_ASSET", TypeName = "decimal(18, 3)")]
        public decimal? RiskAsset { get; set; }
        [Column("ACR_BIS_NO")]
        [StringLength(3)]
        public string AcrBisNo { get; set; }
        [Column("ACR_RISK_WEIGHT", TypeName = "decimal(3, 0)")]
        public decimal? AcrRiskWeight { get; set; }
        [Column("ACR_INT_BC", TypeName = "decimal(18, 3)")]
        public decimal? AcrIntBc { get; set; }
        [Column("ACR_INT_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? AcrIntRiskAst { get; set; }
        [Column("ACR_COM_BC", TypeName = "decimal(18, 3)")]
        public decimal? AcrComBc { get; set; }
        [Column("ACR_COM_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? AcrComRiskAst { get; set; }
        [Column("EXP_PRE_INT_BC", TypeName = "decimal(18, 3)")]
        public decimal? ExpPreIntBc { get; set; }
        [Column("EXP_PRE_INT_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? ExpPreIntRiskAst { get; set; }
        [Column("EXP_PRE_COM_BC", TypeName = "decimal(18, 3)")]
        public decimal? ExpPreComBc { get; set; }
        [Column("EXP_PRE_COM_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? ExpPreComRiskAst { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
