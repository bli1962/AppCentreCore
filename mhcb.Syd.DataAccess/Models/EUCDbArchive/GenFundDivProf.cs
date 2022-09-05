using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("GEN_FUND_DIV_PROF", Schema = "EUC")]
    public partial class GenFundDivProf
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("CUST_APP_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? CustAppAcmBal { get; set; }
        [Column("CUST_APP_BAL", TypeName = "decimal(18, 3)")]
        public decimal? CustAppBal { get; set; }
        [Column("CUST_APP_INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? CustAppIntIncome { get; set; }
        [Column("SECUR_APP_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? SecurAppAcmBal { get; set; }
        [Column("SECUR_APP_BAL", TypeName = "decimal(18, 3)")]
        public decimal? SecurAppBal { get; set; }
        [Column("SECUR_APP_INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? SecurAppIntIncome { get; set; }
        [Column("OTHER_APP_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? OtherAppAcmBal { get; set; }
        [Column("OTHER_APP_BAL", TypeName = "decimal(18, 3)")]
        public decimal? OtherAppBal { get; set; }
        [Column("OTHER_APP_INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? OtherAppIntIncome { get; set; }
        [Column("CUST_ACQ_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? CustAcqAcmBal { get; set; }
        [Column("CUST_ACQ_BAL", TypeName = "decimal(18, 3)")]
        public decimal? CustAcqBal { get; set; }
        [Column("CUST_ACQ_INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? CustAcqIntIncome { get; set; }
        [Column("SECUR_ACQ_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? SecurAcqAcmBal { get; set; }
        [Column("SECUR_ACQ_BAL", TypeName = "decimal(18, 3)")]
        public decimal? SecurAcqBal { get; set; }
        [Column("SECUR_ACQ_INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? SecurAcqIntIncome { get; set; }
        [Column("OTHER_ACQ_ACM_BAL", TypeName = "decimal(20, 3)")]
        public decimal? OtherAcqAcmBal { get; set; }
        [Column("OTHER_ACQ_BAL", TypeName = "decimal(18, 3)")]
        public decimal? OtherAcqBal { get; set; }
        [Column("OTHER_ACQ_INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? OtherAcqIntIncome { get; set; }
        [Column("TOT_ACM_BAL_DUE_FR_B", TypeName = "decimal(20, 3)")]
        public decimal? TotAcmBalDueFrB { get; set; }
        [Column("TOT_BAL_DUE_FR_B", TypeName = "decimal(18, 3)")]
        public decimal? TotBalDueFrB { get; set; }
        [Column("INT_INCOME_DUE_FR_B", TypeName = "decimal(18, 3)")]
        public decimal? IntIncomeDueFrB { get; set; }
        [Column("FEE_DUE_FR_B", TypeName = "decimal(18, 3)")]
        public decimal? FeeDueFrB { get; set; }
        [Column("TOT_ACM_BAL_DUE_TO_B", TypeName = "decimal(20, 3)")]
        public decimal? TotAcmBalDueToB { get; set; }
        [Column("TOT_BAL_DUE_TO_B", TypeName = "decimal(18, 3)")]
        public decimal? TotBalDueToB { get; set; }
        [Column("INT_INCOME_DUE_TO_B", TypeName = "decimal(18, 3)")]
        public decimal? IntIncomeDueToB { get; set; }
        [Column("FEE_DUE_TO_B", TypeName = "decimal(18, 3)")]
        public decimal? FeeDueToB { get; set; }
        [Column("OTHER_INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? OtherIntIncome { get; set; }
        [Column("OTHER_FEE", TypeName = "decimal(18, 3)")]
        public decimal? OtherFee { get; set; }
        [Column("PL_GRAND_TOT_PREV_T", TypeName = "decimal(18, 3)")]
        public decimal? PlGrandTotPrevT { get; set; }
        [Column("PL_GRAND_TOT_CURR_M", TypeName = "decimal(18, 3)")]
        public decimal? PlGrandTotCurrM { get; set; }
        [Column("PL_GRAND_TOT_CURR_T", TypeName = "decimal(18, 3)")]
        public decimal? PlGrandTotCurrT { get; set; }
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
        [Column("CURR_M_DAYS")]
        [StringLength(2)]
        public string CurrMDays { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
