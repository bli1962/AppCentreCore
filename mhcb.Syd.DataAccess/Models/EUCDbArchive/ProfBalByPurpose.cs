using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("PROF_BAL_BY_PURPOSE", Schema = "EUC")]
    public partial class ProfBalByPurpose
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("TOT_DTL_ID")]
        [StringLength(2)]
        public string TotDtlId { get; set; }
        [Column("PURPOSE_FIRST_CLASS")]
        [StringLength(2)]
        public string PurposeFirstClass { get; set; }
        [Column("PURPOSE_SECOND_CLASS")]
        [StringLength(2)]
        public string PurposeSecondClass { get; set; }
        [Column("PURPOSE_FINAL_CLASS")]
        [StringLength(2)]
        public string PurposeFinalClass { get; set; }
        [Column("PURPOSE_NAME")]
        [StringLength(50)]
        public string PurposeName { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("TOT_ASSET_END_BAL", TypeName = "decimal(18, 3)")]
        public decimal? TotAssetEndBal { get; set; }
        [Column("TOT_ASSET_AVG", TypeName = "decimal(18, 3)")]
        public decimal? TotAssetAvg { get; set; }
        [Column("LOAN_END_BAL", TypeName = "decimal(18, 3)")]
        public decimal? LoanEndBal { get; set; }
        [Column("LOAN_AVG", TypeName = "decimal(18, 3)")]
        public decimal? LoanAvg { get; set; }
        [Column("MID_LNG_LOAN_END_BAL", TypeName = "decimal(18, 3)")]
        public decimal? MidLngLoanEndBal { get; set; }
        [Column("MID_LNG_LOAN_AVG", TypeName = "decimal(18, 3)")]
        public decimal? MidLngLoanAvg { get; set; }
        [Column("SHRT_LOAN_END_BAL", TypeName = "decimal(18, 3)")]
        public decimal? ShrtLoanEndBal { get; set; }
        [Column("SHRT_LOAN_AVG", TypeName = "decimal(18, 3)")]
        public decimal? ShrtLoanAvg { get; set; }
        [Column("TRADE_BILL_END_BAL", TypeName = "decimal(18, 3)")]
        public decimal? TradeBillEndBal { get; set; }
        [Column("TRADE_BILL_AVG", TypeName = "decimal(18, 3)")]
        public decimal? TradeBillAvg { get; set; }
        [Column("NO_TRADE_END_BAL", TypeName = "decimal(18, 3)")]
        public decimal? NoTradeEndBal { get; set; }
        [Column("NO_TRADE_AVG", TypeName = "decimal(18, 3)")]
        public decimal? NoTradeAvg { get; set; }
        [Column("WITH_TRADE_END_BAL", TypeName = "decimal(18, 3)")]
        public decimal? WithTradeEndBal { get; set; }
        [Column("WITH_TRADE_AVG", TypeName = "decimal(18, 3)")]
        public decimal? WithTradeAvg { get; set; }
        [Column("UNUSD_CMT_END_BAL", TypeName = "decimal(18, 3)")]
        public decimal? UnusdCmtEndBal { get; set; }
        [Column("UNUSD_CMT_AVG", TypeName = "decimal(18, 3)")]
        public decimal? UnusdCmtAvg { get; set; }
        [Column("UNUSD_LOAN_END_BAL", TypeName = "decimal(18, 3)")]
        public decimal? UnusdLoanEndBal { get; set; }
        [Column("UNUSD_LOAN_AVG", TypeName = "decimal(18, 3)")]
        public decimal? UnusdLoanAvg { get; set; }
        [Column("UNUSD_GRT_END_BAL", TypeName = "decimal(18, 3)")]
        public decimal? UnusdGrtEndBal { get; set; }
        [Column("UNUSD_GRT_AVG", TypeName = "decimal(18, 3)")]
        public decimal? UnusdGrtAvg { get; set; }
        [Column("UNUSD_REL_OT_END_BAL", TypeName = "decimal(18, 3)")]
        public decimal? UnusdRelOtEndBal { get; set; }
        [Column("UNUSD_REL_OT_AVG", TypeName = "decimal(18, 3)")]
        public decimal? UnusdRelOtAvg { get; set; }
        [Column("UNUSD_M_LNG_END_BAL", TypeName = "decimal(18, 3)")]
        public decimal? UnusdMLngEndBal { get; set; }
        [Column("UNUSD_M_LNG_AVG", TypeName = "decimal(18, 3)")]
        public decimal? UnusdMLngAvg { get; set; }
        [Column("UNUSD_SHRT_END_BAL", TypeName = "decimal(18, 3)")]
        public decimal? UnusdShrtEndBal { get; set; }
        [Column("UNUSD_SHRT_AVG", TypeName = "decimal(18, 3)")]
        public decimal? UnusdShrtAvg { get; set; }
        [Column("OTHER_ASSET_END_BAL", TypeName = "decimal(18, 3)")]
        public decimal? OtherAssetEndBal { get; set; }
        [Column("OTHER_ASSET_AVG", TypeName = "decimal(18, 3)")]
        public decimal? OtherAssetAvg { get; set; }
        [Column("CUST_PROFIT", TypeName = "decimal(18, 3)")]
        public decimal? CustProfit { get; set; }
        [Column("INT_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? IntIncome { get; set; }
        [Column("FEE_INCOME", TypeName = "decimal(18, 3)")]
        public decimal? FeeIncome { get; set; }
        [Column("ANN_FEE", TypeName = "decimal(18, 3)")]
        public decimal? AnnFee { get; set; }
        [Column("ANN_FEE_GRT", TypeName = "decimal(18, 3)")]
        public decimal? AnnFeeGrt { get; set; }
        [Column("ANN_FEE_CMT", TypeName = "decimal(18, 3)")]
        public decimal? AnnFeeCmt { get; set; }
        [Column("ANN_FEE_OTHER", TypeName = "decimal(18, 3)")]
        public decimal? AnnFeeOther { get; set; }
        [Column("UP_FRNT_FEE", TypeName = "decimal(18, 3)")]
        public decimal? UpFrntFee { get; set; }
        [Column("TRADE_FEE", TypeName = "decimal(18, 3)")]
        public decimal? TradeFee { get; set; }
        [Column("OTHER_FEE", TypeName = "decimal(18, 3)")]
        public decimal? OtherFee { get; set; }
        [Column("FX_PROFIT", TypeName = "decimal(18, 3)")]
        public decimal? FxProfit { get; set; }
        [Column("DIR_EXP", TypeName = "decimal(18, 3)")]
        public decimal? DirExp { get; set; }
        [Column("PROMOTE_EXP", TypeName = "decimal(18, 3)")]
        public decimal? PromoteExp { get; set; }
        [Column("OPERATE_EXP", TypeName = "decimal(18, 3)")]
        public decimal? OperateExp { get; set; }
        [Column("RSV_BAD_DEBT", TypeName = "decimal(18, 3)")]
        public decimal? RsvBadDebt { get; set; }
        [Column("FRST_NET_PROFIT", TypeName = "decimal(18, 3)")]
        public decimal? FrstNetProfit { get; set; }
        [Column("INDIR_EXP", TypeName = "decimal(18, 3)")]
        public decimal? IndirExp { get; set; }
        [Column("BR_COM_EXP", TypeName = "decimal(18, 3)")]
        public decimal? BrComExp { get; set; }
        [Column("DIV_COM_EXP", TypeName = "decimal(18, 3)")]
        public decimal? DivComExp { get; set; }
        [Column("SCND_NET_PROFIT", TypeName = "decimal(18, 3)")]
        public decimal? ScndNetProfit { get; set; }
        [Column("HO_EXP", TypeName = "decimal(18, 3)")]
        public decimal? HoExp { get; set; }
        [Column("THRD_NET_PROFIT", TypeName = "decimal(18, 3)")]
        public decimal? ThrdNetProfit { get; set; }
        [Column("OTHER_EXP", TypeName = "decimal(18, 3)")]
        public decimal? OtherExp { get; set; }
        [Column("OT_DIR_EXP", TypeName = "decimal(18, 3)")]
        public decimal? OtDirExp { get; set; }
        [Column("OT_INDIR_EXP", TypeName = "decimal(18, 3)")]
        public decimal? OtIndirExp { get; set; }
        [Column("FRTH_NET_PROFIT", TypeName = "decimal(18, 3)")]
        public decimal? FrthNetProfit { get; set; }
        [Column("DIV_NET_PROFIT", TypeName = "decimal(18, 3)")]
        public decimal? DivNetProfit { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
