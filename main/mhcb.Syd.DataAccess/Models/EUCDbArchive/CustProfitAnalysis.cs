﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("CUST_PROFIT_ANALYSIS", Schema = "EUC")]
    public partial class CustProfitAnalysis
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("BASE")]
        [StringLength(8)]
        public string Base { get; set; }
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
        [Column("LOAN_SHRT_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? LoanShrtAcmBal { get; set; }
        [Column("LOAN_SHRT_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? LoanShrtRiskAst { get; set; }
        [Column("LOAN_SHRT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? LoanShrtIncome { get; set; }
        [Column("OD_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? OdAcmBal { get; set; }
        [Column("OD_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? OdRiskAst { get; set; }
        [Column("OD_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? OdIncome { get; set; }
        [Column("BB_IBD_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? BbIbdAcmBal { get; set; }
        [Column("BB_IBD_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? BbIbdRiskAst { get; set; }
        [Column("BB_IBD_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? BbIbdIncome { get; set; }
        [Column("LOAN_LONG_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? LoanLongAcmBal { get; set; }
        [Column("LOAN_LONG_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? LoanLongRiskAst { get; set; }
        [Column("LOAN_LONG_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? LoanLongIncome { get; set; }
        [Column("TIME_DEPO_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? TimeDepoAcmBal { get; set; }
        [Column("TIME_DEPO_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? TimeDepoIncome { get; set; }
        [Column("CURR_DEPO_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? CurrDepoAcmBal { get; set; }
        [Column("CURR_DEPO_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? CurrDepoIncome { get; set; }
        [Column("OTHER_LIAB_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? OtherLiabAcmBal { get; set; }
        [Column("OTHER_LIAB_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? OtherLiabIncome { get; set; }
        [Column("GRT_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? GrtAcmBal { get; set; }
        [Column("GRT_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? GrtRiskAst { get; set; }
        [Column("GRT_FEE", TypeName = "decimal(18, 3)")]
        public decimal? GrtFee { get; set; }
        [Column("UNUSD_CMT_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? UnusdCmtAcmBal { get; set; }
        [Column("UNUSD_CMT_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? UnusdCmtRiskAst { get; set; }
        [Column("UNUSD_CMT_FEE_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? UnusdCmtFeeIncome { get; set; }
        [Column("SWAP_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? SwapAcmBal { get; set; }
        [Column("SWAP_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? SwapRiskAst { get; set; }
        [Column("SWAP_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? SwapIncome { get; set; }
        [Column("OT_ON_B_AST_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? OtOnBAstAcmBal { get; set; }
        [Column("OT_ON_B_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? OtOnBRiskAst { get; set; }
        [Column("OT_ON_B_AST_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? OtOnBAstIncome { get; set; }
        [Column("OT_OFF_B_AST_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? OtOffBAstAcmBal { get; set; }
        [Column("OT_OFF_B_RISK_AST", TypeName = "decimal(18, 3)")]
        public decimal? OtOffBRiskAst { get; set; }
        [Column("OT_OFF_B_AST_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? OtOffBAstIncome { get; set; }
        [Column("INT_INCOME_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? IntIncomePrevT { get; set; }
        [Column("INT_INCOME_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? IntIncomeCurrM { get; set; }
        [Column("INT_INCOME_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? IntIncomeCurrT { get; set; }
        [Column("FEE_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? FeePrevT { get; set; }
        [Column("FEE_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? FeeCurrM { get; set; }
        [Column("FEE_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? FeeCurrT { get; set; }
        [Column("GRT_FEE_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? GrtFeePrevT { get; set; }
        [Column("GRT_FEE_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? GrtFeeCurrM { get; set; }
        [Column("GRT_FEE_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? GrtFeeCurrT { get; set; }
        [Column("UNUSD_CMT_FEE_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? UnusdCmtFeePrevT { get; set; }
        [Column("UNUSD_CMT_FEE_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? UnusdCmtFeeCurrM { get; set; }
        [Column("UNUSD_CMT_FEE_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? UnusdCmtFeeCurrT { get; set; }
        [Column("OT_CR_FEE_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? OtCrFeePrevT { get; set; }
        [Column("OT_CR_FEE_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? OtCrFeeCurrM { get; set; }
        [Column("OT_CR_FEE_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? OtCrFeeCurrT { get; set; }
        [Column("TRADE_FEE_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? TradeFeePrevT { get; set; }
        [Column("TRADE_FEE_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? TradeFeeCurrM { get; set; }
        [Column("TRADE_FEE_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? TradeFeeCurrT { get; set; }
        [Column("OT_FEE_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? OtFeePrevT { get; set; }
        [Column("OT_FEE_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? OtFeeCurrM { get; set; }
        [Column("OT_FEE_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? OtFeeCurrT { get; set; }
        [Column("CUST_FX_PL_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? CustFxPlPrevT { get; set; }
        [Column("CUST_FX_PL_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? CustFxPlCurrM { get; set; }
        [Column("CUST_FX_PL_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? CustFxPlCurrT { get; set; }
        [Column("PL_TOTAL_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? PlTotalPrevT { get; set; }
        [Column("PL_TOTAL_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? PlTotalCurrM { get; set; }
        [Column("PL_TOTAL_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? PlTotalCurrT { get; set; }
        [Column("AST_ACM_BAL_PREV_T", TypeName = "decimal(20, 3)")]
        public decimal? AstAcmBalPrevT { get; set; }
        [Column("AST_ACM_BAL_CURR_M", TypeName = "decimal(20, 3)")]
        public decimal? AstAcmBalCurrM { get; set; }
        [Column("AST_ACM_BAL_CURR_T", TypeName = "decimal(20, 3)")]
        public decimal? AstAcmBalCurrT { get; set; }
        [Column("RISK_AST_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? RiskAstPrevT { get; set; }
        [Column("RISK_AST_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? RiskAstCurrM { get; set; }
        [Column("RISK_AST_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? RiskAstCurrT { get; set; }
        [Column("FX_TRANS_VOL_PREV_T", TypeName = "decimal(20, 3)")]
        public decimal? FxTransVolPrevT { get; set; }
        [Column("FX_TRANS_VOL_CURR_M", TypeName = "decimal(20, 3)")]
        public decimal? FxTransVolCurrM { get; set; }
        [Column("FX_TRANS_VOL_CURR_T", TypeName = "decimal(20, 3)")]
        public decimal? FxTransVolCurrT { get; set; }
        [Column("DEPO_ACM_BAL_PREV_T", TypeName = "decimal(20, 3)")]
        public decimal? DepoAcmBalPrevT { get; set; }
        [Column("DEPO_ACM_BAL_CURR_T", TypeName = "decimal(20, 3)")]
        public decimal? DepoAcmBalCurrT { get; set; }
        [Column("LOAN_ACM_BAL_PREV_T", TypeName = "decimal(20, 3)")]
        public decimal? LoanAcmBalPrevT { get; set; }
        [Column("LOAN_ACM_BAL_CURR_T", TypeName = "decimal(20, 3)")]
        public decimal? LoanAcmBalCurrT { get; set; }
        [Column("PROMOTE_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? PromoteExpPrevT { get; set; }
        [Column("PROMOTE_EXP_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? PromoteExpCurrM { get; set; }
        [Column("PROMOTE_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? PromoteExpCurrT { get; set; }
        [Column("OPERATE_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? OperateExpPrevT { get; set; }
        [Column("OPERATE_EXP_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? OperateExpCurrM { get; set; }
        [Column("OPERATE_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? OperateExpCurrT { get; set; }
        [Column("RSV_BAD_DEBT_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? RsvBadDebtPrevT { get; set; }
        [Column("RSV_BAD_DEBT_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? RsvBadDebtCurrM { get; set; }
        [Column("RSV_BAD_DEBT_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? RsvBadDebtCurrT { get; set; }
        [Column("BR_COM_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? BrComExpPrevT { get; set; }
        [Column("BR_COM_EXP_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? BrComExpCurrM { get; set; }
        [Column("BR_COM_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? BrComExpCurrT { get; set; }
        [Column("DIV_COM_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? DivComExpPrevT { get; set; }
        [Column("DIV_COM_EXP_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? DivComExpCurrM { get; set; }
        [Column("DIV_COM_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? DivComExpCurrT { get; set; }
        [Column("HO_COST_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? HoCostPrevT { get; set; }
        [Column("HO_COST_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? HoCostCurrM { get; set; }
        [Column("HO_COST_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? HoCostCurrT { get; set; }
        [Column("OT_DIR_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? OtDirExpPrevT { get; set; }
        [Column("OT_DIR_EXP_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? OtDirExpCurrM { get; set; }
        [Column("OT_DIR_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? OtDirExpCurrT { get; set; }
        [Column("OT_INDIR_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? OtIndirExpPrevT { get; set; }
        [Column("OT_INDIR_EXP_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? OtIndirExpCurrM { get; set; }
        [Column("OT_INDIR_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? OtIndirExpCurrT { get; set; }
        [Column("NON_SETTLE_EXP_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? NonSettleExpPrevT { get; set; }
        [Column("NON_SETTLE_EXP_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? NonSettleExpCurrM { get; set; }
        [Column("NON_SETTLE_EXP_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? NonSettleExpCurrT { get; set; }
        [Column("PREV_T_DAYS")]
        [StringLength(3)]
        public string PrevTDays { get; set; }
        [Column("CURR_M_DAYS")]
        [StringLength(2)]
        public string CurrMDays { get; set; }
        [Column("CURR_T_DAYS")]
        [StringLength(3)]
        public string CurrTDays { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
