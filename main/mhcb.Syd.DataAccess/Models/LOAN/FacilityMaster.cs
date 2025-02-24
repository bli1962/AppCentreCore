using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("FACILITY_MASTER")]
    [Index(nameof(ApplnNo), Name = "IDX_ApplnNo")]
    public partial class FacilityMaster
    {
        public FacilityMaster()
        {
            FeeRateLimitChangeLogs = new HashSet<FeeRateLimitChangeLog>();
            LoanTrans = new HashSet<LoanTran>();
        }

        [Key]
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Required]
        [Column("APPLN_NO")]
        [StringLength(11)]
        public string ApplnNo { get; set; }
        [Column("APPLN_NO1")]
        [StringLength(11)]
        public string ApplnNo1 { get; set; }
        [Column("RATING1")]
        [StringLength(1)]
        public string Rating1 { get; set; }
        [Column("RATING2")]
        public short? Rating2 { get; set; }
        [Column("PROD_TYPE1")]
        public short? ProdType1 { get; set; }
        [Column("PROD_TYPE2")]
        public short? ProdType2 { get; set; }
        [Column("PROD_TYPE3")]
        public short? ProdType3 { get; set; }
        [Column("PROD_TYPE4")]
        public short? ProdType4 { get; set; }
        [Column("APPR_DATE", TypeName = "datetime")]
        public DateTime? ApprDate { get; set; }
        [Column("APPR_DATE1", TypeName = "datetime")]
        public DateTime? ApprDate1 { get; set; }
        [Column("MULTI_CCY")]
        public bool? MultiCcy { get; set; }
        [Column("BASE_CCY")]
        [StringLength(3)]
        public string BaseCcy { get; set; }
        [Column("LIMIT", TypeName = "decimal(27, 4)")]
        public decimal? Limit { get; set; }
        [Column("MAT_DATE", TypeName = "datetime")]
        public DateTime? MatDate { get; set; }
        [Column("SIGHT_DATE", TypeName = "datetime")]
        public DateTime? SightDate { get; set; }
        [Column("MAX_INT_PERIOD")]
        [StringLength(30)]
        public string MaxIntPeriod { get; set; }
        [Column("BASE_RATE")]
        [StringLength(10)]
        public string BaseRate { get; set; }
        [Column("BASE_RATE_REMARK")]
        [StringLength(50)]
        public string BaseRateRemark { get; set; }
        [Column("MARGIN", TypeName = "decimal(18, 6)")]
        public decimal? Margin { get; set; }
        [Column("INT_CALC_METHOD")]
        public short? IntCalcMethod { get; set; }
        [Column("INT_CALC_REMARK")]
        [StringLength(50)]
        public string IntCalcRemark { get; set; }
        [Column("REPAY_TYPE")]
        public short? RepayType { get; set; }
        [Column("REPAY_REMARK")]
        [StringLength(50)]
        public string RepayRemark { get; set; }
        [Column("OTHER_REMARK")]
        [StringLength(400)]
        public string OtherRemark { get; set; }
        [Column("G_FEE_TYPE")]
        public short? GFeeType { get; set; }
        [Column("G_FEE_RATE", TypeName = "decimal(18, 6)")]
        public decimal? GFeeRate { get; set; }
        [Column("FEE_KIND_ID")]
        public byte FeeKindId { get; set; }
        [Column("FEE_RATE", TypeName = "decimal(18, 6)")]
        public decimal FeeRate { get; set; }
        [Column("FEE_CALC_METHOD_TYPE")]
        public byte FeeCalcMethodType { get; set; }
        [Column("FEE_START_DATE", TypeName = "smalldatetime")]
        public DateTime FeeStartDate { get; set; }
        [Column("FEE_END_DATE", TypeName = "smalldatetime")]
        public DateTime FeeEndDate { get; set; }
        [Column("FEE_PAYMENT_TYPE")]
        public byte FeePaymentType { get; set; }
        [Column("FREQ_TYPE")]
        public byte FreqType { get; set; }
        [Column("DAY_OF_MONTH_TYPE")]
        public byte DayOfMonthType { get; set; }
        [Column("FEE_COL_DATE", TypeName = "smalldatetime")]
        public DateTime FeeColDate { get; set; }
        [Column("FEE_REMARKS")]
        [StringLength(100)]
        public string FeeRemarks { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
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
        [Column("CREATE_DATE", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("APPR_ON", TypeName = "datetime")]
        public DateTime? ApprOn { get; set; }
        [Column("MODIFY_DATE", TypeName = "datetime")]
        public DateTime? ModifyDate { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("DIRECT_DEBIT")]
        public bool DirectDebit { get; set; }

        [ForeignKey(nameof(DayOfMonthType))]
        [InverseProperty(nameof(FeeDayOfMonthType.FacilityMasters))]
        public virtual FeeDayOfMonthType DayOfMonthTypeNavigation { get; set; }
        [ForeignKey(nameof(FeeCalcMethodType))]
        [InverseProperty(nameof(FeeCalcMethod.FacilityMasters))]
        public virtual FeeCalcMethod FeeCalcMethodTypeNavigation { get; set; }
        [ForeignKey(nameof(FeePaymentType))]
        [InverseProperty(nameof(FeePayment.FacilityMasters))]
        public virtual FeePayment FeePaymentTypeNavigation { get; set; }
        [ForeignKey(nameof(FreqType))]
        [InverseProperty(nameof(FeeFreqType.FacilityMasters))]
        public virtual FeeFreqType FreqTypeNavigation { get; set; }
        [ForeignKey(nameof(Rating1))]
        [InverseProperty("FacilityMasters")]
        public virtual Rating1 Rating1Navigation { get; set; }
        [ForeignKey(nameof(Rating2))]
        [InverseProperty("FacilityMasters")]
        public virtual Rating2 Rating2Navigation { get; set; }
        [InverseProperty(nameof(FeeRateLimitChangeLog.RefNoNavigation))]
        public virtual ICollection<FeeRateLimitChangeLog> FeeRateLimitChangeLogs { get; set; }
        [InverseProperty(nameof(LoanTran.RefNoNavigation))]
        public virtual ICollection<LoanTran> LoanTrans { get; set; }
    }
}
