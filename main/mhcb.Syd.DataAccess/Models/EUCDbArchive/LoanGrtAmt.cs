using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("LOAN_GRT_AMT", Schema = "EUC")]
    public partial class LoanGrtAmt
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("CUST_NAME")]
        [StringLength(40)]
        public string CustName { get; set; }
        [Column("CUST_CD")]
        [StringLength(7)]
        public string CustCd { get; set; }
        [Column("MZH_COMPANY_CD")]
        [StringLength(1)]
        public string MzhCompanyCd { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("DD_NO")]
        [StringLength(3)]
        public string DdNo { get; set; }
        [Column("RO_NO")]
        [StringLength(3)]
        public string RoNo { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("DD_VALUE", TypeName = "datetime")]
        public DateTime? DdValue { get; set; }
        [Column("FINAL_DUE", TypeName = "datetime")]
        public DateTime? FinalDue { get; set; }
        [Column("RO_VALUE", TypeName = "datetime")]
        public DateTime? RoValue { get; set; }
        [Column("RO_DUE", TypeName = "datetime")]
        public DateTime? RoDue { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("APPL_AMT", TypeName = "decimal(16, 3)")]
        public decimal? ApplAmt { get; set; }
        [Column("CALC_CD")]
        [StringLength(1)]
        public string CalcCd { get; set; }
        [Column("FRACTION_CD")]
        [StringLength(1)]
        public string FractionCd { get; set; }
        [Column("FINAL_DAY_CD")]
        [StringLength(1)]
        public string FinalDayCd { get; set; }
        [Column("FIXED_FLOAT")]
        [StringLength(1)]
        public string FixedFloat { get; set; }
        [Column("BASE_RATE_CD")]
        [StringLength(2)]
        public string BaseRateCd { get; set; }
        [Column("BASE_RATE_SUB_CD")]
        [StringLength(2)]
        public string BaseRateSubCd { get; set; }
        [Column("BASE_RATE_TERM")]
        [StringLength(1)]
        public string BaseRateTerm { get; set; }
        [Column("SPREAD", TypeName = "decimal(10, 7)")]
        public decimal? Spread { get; set; }
        [Column("INT_RATE", TypeName = "decimal(10, 7)")]
        public decimal? IntRate { get; set; }
        [Column("INT_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? IntAmount { get; set; }
        [Column("MAR_SEP_CALC_START", TypeName = "datetime")]
        public DateTime? MarSepCalcStart { get; set; }
        [Column("MAR_SEP_CALC_END", TypeName = "datetime")]
        public DateTime? MarSepCalcEnd { get; set; }
        [Column("MAR_SEP_ACM_BAL", TypeName = "decimal(16, 3)")]
        public decimal? MarSepAcmBal { get; set; }
        [Column("MAR_SEP_END_BAL", TypeName = "decimal(16, 3)")]
        public decimal? MarSepEndBal { get; set; }
        [Column("MAR_SEP_AVG_BAL", TypeName = "decimal(16, 3)")]
        public decimal? MarSepAvgBal { get; set; }
        [Column("MAR_SEP_GRT_AMT", TypeName = "decimal(16, 3)")]
        public decimal? MarSepGrtAmt { get; set; }
        [Column("MAR_SEP_DAYS")]
        [StringLength(2)]
        public string MarSepDays { get; set; }
        [Column("MAR_SEP_T_ACM_BAL", TypeName = "decimal(16, 3)")]
        public decimal? MarSepTAcmBal { get; set; }
        [Column("MAR_SEP_T_DAYS")]
        [StringLength(3)]
        public string MarSepTDays { get; set; }
        [Column("APR_OCT_CALC_START", TypeName = "datetime")]
        public DateTime? AprOctCalcStart { get; set; }
        [Column("APR_OCT_CALC_END", TypeName = "datetime")]
        public DateTime? AprOctCalcEnd { get; set; }
        [Column("APR_OCT_ACM_BAL", TypeName = "decimal(16, 3)")]
        public decimal? AprOctAcmBal { get; set; }
        [Column("APR_OCT_END_BAL", TypeName = "decimal(16, 3)")]
        public decimal? AprOctEndBal { get; set; }
        [Column("APR_OCT_AVG_BAL", TypeName = "decimal(16, 3)")]
        public decimal? AprOctAvgBal { get; set; }
        [Column("APR_OCT_GRT_AMT", TypeName = "decimal(16, 3)")]
        public decimal? AprOctGrtAmt { get; set; }
        [Column("APR_OCT_DAYS")]
        [StringLength(2)]
        public string AprOctDays { get; set; }
        [Column("APR_OCT_T_ACM_BAL", TypeName = "decimal(16, 3)")]
        public decimal? AprOctTAcmBal { get; set; }
        [Column("APR_OCT_T_DAYS")]
        [StringLength(3)]
        public string AprOctTDays { get; set; }
        [Column("MAY_NOV_CALC_START", TypeName = "datetime")]
        public DateTime? MayNovCalcStart { get; set; }
        [Column("MAY_NOV_CALC_END", TypeName = "datetime")]
        public DateTime? MayNovCalcEnd { get; set; }
        [Column("MAY_NOV_ACM_BAL", TypeName = "decimal(16, 3)")]
        public decimal? MayNovAcmBal { get; set; }
        [Column("MAY_NOV_END_BAL", TypeName = "decimal(16, 3)")]
        public decimal? MayNovEndBal { get; set; }
        [Column("MAY_NOV_AVG_BAL", TypeName = "decimal(16, 3)")]
        public decimal? MayNovAvgBal { get; set; }
        [Column("MAY_NOV_GRT_AMT", TypeName = "decimal(16, 3)")]
        public decimal? MayNovGrtAmt { get; set; }
        [Column("MAY_NOV_DAYS")]
        [StringLength(2)]
        public string MayNovDays { get; set; }
        [Column("MAY_NOV_T_ACM_BAL", TypeName = "decimal(16, 3)")]
        public decimal? MayNovTAcmBal { get; set; }
        [Column("MAY_NOV_T_DAYS")]
        [StringLength(3)]
        public string MayNovTDays { get; set; }
        [Column("JUN_DEC_CALC_START", TypeName = "datetime")]
        public DateTime? JunDecCalcStart { get; set; }
        [Column("JUN_DEC_CALC_END", TypeName = "datetime")]
        public DateTime? JunDecCalcEnd { get; set; }
        [Column("JUN_DEC_ACM_BAL", TypeName = "decimal(16, 3)")]
        public decimal? JunDecAcmBal { get; set; }
        [Column("JUN_DEC_END_BAL", TypeName = "decimal(16, 3)")]
        public decimal? JunDecEndBal { get; set; }
        [Column("JUN_DEC_AVG_BAL", TypeName = "decimal(16, 3)")]
        public decimal? JunDecAvgBal { get; set; }
        [Column("JUN_DEC_GRT_AMT", TypeName = "decimal(16, 3)")]
        public decimal? JunDecGrtAmt { get; set; }
        [Column("JUN_DEC_DAYS")]
        [StringLength(2)]
        public string JunDecDays { get; set; }
        [Column("JUN_DEC_T_ACM_BAL", TypeName = "decimal(16, 3)")]
        public decimal? JunDecTAcmBal { get; set; }
        [Column("JUN_DEC_T_DAYS")]
        [StringLength(3)]
        public string JunDecTDays { get; set; }
        [Column("JUL_JAN_CALC_START", TypeName = "datetime")]
        public DateTime? JulJanCalcStart { get; set; }
        [Column("JUL_JAN_CALC_END", TypeName = "datetime")]
        public DateTime? JulJanCalcEnd { get; set; }
        [Column("JUL_JAN_ACM_BAL", TypeName = "decimal(16, 3)")]
        public decimal? JulJanAcmBal { get; set; }
        [Column("JUL_JAN_END_BAL", TypeName = "decimal(16, 3)")]
        public decimal? JulJanEndBal { get; set; }
        [Column("JUL_JAN_AVG_BAL", TypeName = "decimal(16, 3)")]
        public decimal? JulJanAvgBal { get; set; }
        [Column("JUL_JAN_GRT_AMT", TypeName = "decimal(16, 3)")]
        public decimal? JulJanGrtAmt { get; set; }
        [Column("JUL_JAN_DAYS")]
        [StringLength(2)]
        public string JulJanDays { get; set; }
        [Column("JUL_JAN_T_ACM_BAL", TypeName = "decimal(16, 3)")]
        public decimal? JulJanTAcmBal { get; set; }
        [Column("JUL_JAN_T_DAYS")]
        [StringLength(3)]
        public string JulJanTDays { get; set; }
        [Column("AUG_FEB_CALC_START", TypeName = "datetime")]
        public DateTime? AugFebCalcStart { get; set; }
        [Column("AUG_FEB_CALC_END", TypeName = "datetime")]
        public DateTime? AugFebCalcEnd { get; set; }
        [Column("AUG_FEB_ACM_BAL", TypeName = "decimal(16, 3)")]
        public decimal? AugFebAcmBal { get; set; }
        [Column("AUG_FEB_END_BAL", TypeName = "decimal(16, 3)")]
        public decimal? AugFebEndBal { get; set; }
        [Column("AUG_FEB_AVG_BAL", TypeName = "decimal(16, 3)")]
        public decimal? AugFebAvgBal { get; set; }
        [Column("AUG_FEB_GRT_AMT", TypeName = "decimal(16, 3)")]
        public decimal? AugFebGrtAmt { get; set; }
        [Column("AUG_FEB_DAYS")]
        [StringLength(2)]
        public string AugFebDays { get; set; }
        [Column("AUG_FEB_T_ACM_BAL", TypeName = "decimal(16, 3)")]
        public decimal? AugFebTAcmBal { get; set; }
        [Column("AUG_FEB_T_DAYS")]
        [StringLength(3)]
        public string AugFebTDays { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
