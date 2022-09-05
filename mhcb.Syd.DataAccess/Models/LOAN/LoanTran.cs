using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("LOAN_TRANS")]
    [Index(nameof(DueDate), Name = "IDX_DueDate")]
    [Index(nameof(StartDate), Name = "IDX_StartDate")]
    [Index(nameof(RoNo), Name = "NCI_LOAN_TRANS_RO_NO")]
    [Index(nameof(Status), Name = "NCI_LOAN_TRANS_Status")]
    public partial class LoanTran
    {
        [Key]
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Key]
        [Column("TRANS_NO")]
        public int TransNo { get; set; }
        [Column("RO_NO")]
        public int? RoNo { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("START_DATE", TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column("DUE_DATE", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("INC_DUE_DATE")]
        public bool? IncDueDate { get; set; }
        [Column("DAYS")]
        public int? Days { get; set; }
        [Column("DRAW_CCY")]
        [StringLength(3)]
        public string DrawCcy { get; set; }
        [Column("DRAW_AMT", TypeName = "decimal(27, 4)")]
        public decimal? DrawAmt { get; set; }
        [Column("DRAW_EQUIV", TypeName = "decimal(27, 4)")]
        public decimal? DrawEquiv { get; set; }
        [Column("DRAW_EXCH_RATE_IND")]
        [StringLength(1)]
        public string DrawExchRateInd { get; set; }
        [Column("DRAW_EXCH_RATE", TypeName = "decimal(18, 6)")]
        public decimal? DrawExchRate { get; set; }
        [Column("REPAY_CCY")]
        [StringLength(3)]
        public string RepayCcy { get; set; }
        [Column("REPAY_AMT", TypeName = "decimal(27, 4)")]
        public decimal? RepayAmt { get; set; }
        [Column("REPAY_EQUIV", TypeName = "decimal(27, 4)")]
        public decimal? RepayEquiv { get; set; }
        [Column("REPAY_EXCH_RATE_IND")]
        [StringLength(1)]
        public string RepayExchRateInd { get; set; }
        [Column("REPAY_EXCH_RATE", TypeName = "decimal(18, 6)")]
        public decimal? RepayExchRate { get; set; }
        [Column("BAL_AMT", TypeName = "decimal(27, 4)")]
        public decimal? BalAmt { get; set; }
        [Column("INT_RATE", TypeName = "decimal(18, 6)")]
        public decimal? IntRate { get; set; }
        [Column("BASE_RATE", TypeName = "decimal(18, 6)")]
        public decimal? BaseRate { get; set; }
        [Column("INT_AMT", TypeName = "decimal(27, 4)")]
        public decimal? IntAmt { get; set; }
        [Column("INT_AMT_CALC", TypeName = "decimal(27, 4)")]
        public decimal? IntAmtCalc { get; set; }
        [Column("INT_RECV_DATE")]
        [StringLength(10)]
        public string IntRecvDate { get; set; }
        [Column("INT_RECV_BY")]
        [StringLength(6)]
        public string IntRecvBy { get; set; }
        [Column("CREATE_DATE", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("PROC_BY1")]
        [StringLength(6)]
        public string ProcBy1 { get; set; }
        [Column("PROC_BY2")]
        [StringLength(6)]
        public string ProcBy2 { get; set; }
        [Column("APPR_BY1")]
        [StringLength(6)]
        public string ApprBy1 { get; set; }
        [Column("APPR_BY2")]
        [StringLength(6)]
        public string ApprBy2 { get; set; }
        [Column("CHK_BY")]
        [StringLength(6)]
        public string ChkBy { get; set; }
        [Column("FLAG_DEL_BY")]
        [StringLength(6)]
        public string FlagDelBy { get; set; }
        [Column("REMARKS")]
        [StringLength(100)]
        public string Remarks { get; set; }
        [Column("INC_START_DATE")]
        public bool? IncStartDate { get; set; }
        [Column("DRAWDOWN_NO")]
        [StringLength(30)]
        public string DrawdownNo { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("AUTHORIZED")]
        [StringLength(1)]
        public string Authorized { get; set; }
        [Column("FINAL_DUE_DATE", TypeName = "datetime")]
        public DateTime? FinalDueDate { get; set; }
        [Column("INTEREST_TO_DATE", TypeName = "datetime")]
        public DateTime? InterestToDate { get; set; }
        [Column("INTEREST_CALC_CODE")]
        [StringLength(5)]
        public string InterestCalcCode { get; set; }
        [Column("BASE_RATE_CODE")]
        [StringLength(5)]
        public string BaseRateCode { get; set; }
        [Column("SPREAD", TypeName = "decimal(22, 7)")]
        public decimal? Spread { get; set; }
        [Column("INTEREST_COLLECT")]
        [StringLength(1)]
        public string InterestCollect { get; set; }
        [Column("INTERNAL_RATE")]
        [StringLength(1)]
        public string InternalRate { get; set; }
        [Column("RECEIVING_METHOD")]
        [StringLength(2)]
        public string ReceivingMethod { get; set; }
        [Column("PAYING_METHOD")]
        [StringLength(2)]
        public string PayingMethod { get; set; }
        [Column("ACCOUNT_CODE")]
        public int? AccountCode { get; set; }
        [Column("CUSTOMER_ACCOUNT_CODE_BORROWER")]
        [StringLength(12)]
        public string CustomerAccountCodeBorrower { get; set; }
        [Column("CUSTOMER_ACCOUNT_CODE")]
        public int? CustomerAccountCode { get; set; }
        [Column("ACCOUNT_NO1")]
        public int? AccountNo1 { get; set; }
        [Column("ACCOUNT_NO2")]
        public int? AccountNo2 { get; set; }
        [Column("ACCOUNT_NO1_MANUAL_ENTRY")]
        [StringLength(3)]
        public string AccountNo1ManualEntry { get; set; }
        [Column("ACCOUNT_NO2_MANUAL_ENTRY")]
        [StringLength(6)]
        public string AccountNo2ManualEntry { get; set; }
        [Column("ATTENTION")]
        [StringLength(200)]
        public string Attention { get; set; }
        [Column("Old_RO_InterestCollect")]
        [StringLength(1)]
        public string OldRoInterestCollect { get; set; }
        [Column("Old_RO_IntAmt", TypeName = "decimal(27, 4)")]
        public decimal? OldRoIntAmt { get; set; }
        [Column("RO_Type1")]
        [StringLength(1)]
        public string RoType1 { get; set; }
        [Column("RO_Type2")]
        [StringLength(1)]
        public string RoType2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InitialInputDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InitialApprovalDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinalApprovalDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifyRateDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveModifiedRateDateTime { get; set; }
        [StringLength(6)]
        public string ModifyRatesBy { get; set; }
        [StringLength(6)]
        public string AppRatesBy { get; set; }

        [ForeignKey(nameof(AccountCode))]
        [InverseProperty("LoanTrans")]
        public virtual AccountCode AccountCodeNavigation { get; set; }
        [ForeignKey(nameof(AccountNo1))]
        [InverseProperty("LoanTrans")]
        public virtual AccountNo1 AccountNo1Navigation { get; set; }
        [ForeignKey(nameof(AccountNo2))]
        [InverseProperty("LoanTrans")]
        public virtual AccountNo2 AccountNo2Navigation { get; set; }
        [ForeignKey(nameof(CustomerAccountCode))]
        [InverseProperty("LoanTrans")]
        public virtual CustomerAccountCode CustomerAccountCodeNavigation { get; set; }
        [ForeignKey(nameof(ProcBy1))]
        [InverseProperty(nameof(User.LoanTrans))]
        public virtual User ProcBy1Navigation { get; set; }
        [ForeignKey(nameof(RefNo))]
        [InverseProperty(nameof(FacilityMaster.LoanTrans))]
        public virtual FacilityMaster RefNoNavigation { get; set; }
    }
}
