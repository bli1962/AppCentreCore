using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("SEMI_ANNUAL_BY_CUST", Schema = "EUC")]
    public partial class SemiAnnualByCust
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("DEPARTMENT_CD")]
        [StringLength(2)]
        public string DepartmentCd { get; set; }
        [Column("EMPLOYEE_CD")]
        [StringLength(4)]
        public string EmployeeCd { get; set; }
        [Column("ATTRIBUTE_CD")]
        [StringLength(1)]
        public string AttributeCd { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("INT_INCOME_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? IntIncomeCurrT { get; set; }
        [Column("COM_INCOME_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? ComIncomeCurrT { get; set; }
        [Column("GRT_FEE_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? GrtFeeCurrT { get; set; }
        [Column("UNUSD_CMT_FEE_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? UnusdCmtFeeCurrT { get; set; }
        [Column("OT_CR_FEE_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? OtCrFeeCurrT { get; set; }
        [Column("TRADE_FEE_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? TradeFeeCurrT { get; set; }
        [Column("OT_FEE_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? OtFeeCurrT { get; set; }
        [Column("CUST_FX_PL_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? CustFxPlCurrT { get; set; }
        [Column("PL_TOTAL_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? PlTotalCurrT { get; set; }
        [Column("AST_ACM_BAL_CURR_T", TypeName = "decimal(20, 3)")]
        public decimal? AstAcmBalCurrT { get; set; }
        [Column("RISK_AST_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? RiskAstCurrT { get; set; }
        [Column("FX_TRANS_VOL_CURR_T", TypeName = "decimal(20, 3)")]
        public decimal? FxTransVolCurrT { get; set; }
        [Column("DEPO_ACM_BAL_CURR_T", TypeName = "decimal(20, 3)")]
        public decimal? DepoAcmBalCurrT { get; set; }
        [Column("GRT_ACM_BAL_CURR_T", TypeName = "decimal(20, 3)")]
        public decimal? GrtAcmBalCurrT { get; set; }
        [Column("LOAN_ACM_BAL_CURR_T", TypeName = "decimal(20, 3)")]
        public decimal? LoanAcmBalCurrT { get; set; }
        [Column("PROMOTE_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? PromoteExpCurrT { get; set; }
        [Column("OPERATE_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? OperateExpCurrT { get; set; }
        [Column("RSV_BAD_DEBT_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? RsvBadDebtCurrT { get; set; }
        [Column("BR_COM_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? BrComExpCurrT { get; set; }
        [Column("DIV_COM_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? DivComExpCurrT { get; set; }
        [Column("HO_COST_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? HoCostCurrT { get; set; }
        [Column("OT_DIR_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? OtDirExpCurrT { get; set; }
        [Column("OT_INDIR_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? OtIndirExpCurrT { get; set; }
        [Column("NON_SETTLE_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? NonSettleExpCurrT { get; set; }
        [Column("INT_INCOME_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? IntIncomePrevT { get; set; }
        [Column("COM_INCOME_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? ComIncomePrevT { get; set; }
        [Column("GRT_FEE_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? GrtFeePrevT { get; set; }
        [Column("UNUSD_CMT_FEE_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? UnusdCmtFeePrevT { get; set; }
        [Column("OT_CR_FEE_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? OtCrFeePrevT { get; set; }
        [Column("TRADE_FEE_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? TradeFeePrevT { get; set; }
        [Column("OT_FEE_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? OtFeePrevT { get; set; }
        [Column("CUST_FX_PL_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? CustFxPlPrevT { get; set; }
        [Column("PL_TOTAL_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? PlTotalPrevT { get; set; }
        [Column("AST_ACM_BAL_PREV_T", TypeName = "decimal(20, 3)")]
        public decimal? AstAcmBalPrevT { get; set; }
        [Column("RISK_AST_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? RiskAstPrevT { get; set; }
        [Column("FX_TRANS_VOL_PREV_T", TypeName = "decimal(20, 3)")]
        public decimal? FxTransVolPrevT { get; set; }
        [Column("DEPO_ACM_BAL_PREV_T", TypeName = "decimal(20, 3)")]
        public decimal? DepoAcmBalPrevT { get; set; }
        [Column("LOAN_ACM_BAL_PREV_T", TypeName = "decimal(20, 3)")]
        public decimal? LoanAcmBalPrevT { get; set; }
        [Column("PROMOTE_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? PromoteExpPrevT { get; set; }
        [Column("OPERATE_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? OperateExpPrevT { get; set; }
        [Column("RSV_BAD_DEBT_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? RsvBadDebtPrevT { get; set; }
        [Column("BR_COM_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? BrComExpPrevT { get; set; }
        [Column("DIV_COM_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? DivComExpPrevT { get; set; }
        [Column("HO_COST_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? HoCostPrevT { get; set; }
        [Column("OT_DIR_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? OtDirExpPrevT { get; set; }
        [Column("OT_INDIR_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? OtIndirExpPrevT { get; set; }
        [Column("NON_SETTLE_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? NonSettleExpPrevT { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
