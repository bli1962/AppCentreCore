using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M07_SETTL_RETRACE_INPUT", Schema = "EUC")]
    public partial class M07SettlRetraceInput
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("RETRACE_NO")]
        [StringLength(5)]
        public string RetraceNo { get; set; }
        [Column("OPE_DATE", TypeName = "datetime")]
        public DateTime? OpeDate { get; set; }
        [Column("DEPT_CD")]
        [StringLength(2)]
        public string DeptCd { get; set; }
        [Column("ONLINE_SYSTEM_CD")]
        [StringLength(2)]
        public string OnlineSystemCd { get; set; }
        [Column("ONLINE_FUNC_CD")]
        [StringLength(2)]
        public string OnlineFuncCd { get; set; }
        [Column("OPE_KIND")]
        [StringLength(1)]
        public string OpeKind { get; set; }
        [Column("INPUT_EMP_CD")]
        [StringLength(4)]
        public string InputEmpCd { get; set; }
        [Column("INPUT_OPE_ID")]
        [StringLength(3)]
        public string InputOpeId { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("IRREGULAR_TRANS_FLG")]
        [StringLength(2)]
        public string IrregularTransFlg { get; set; }
        [Column("REMARKS")]
        [StringLength(30)]
        public string Remarks { get; set; }
        [Column("CORRECT_CMT_CD")]
        [StringLength(1)]
        public string CorrectCmtCd { get; set; }
        [Column("CORRECT_REASON")]
        [StringLength(1)]
        public string CorrectReason { get; set; }
        [Column("DELETE_FLG")]
        [StringLength(1)]
        public string DeleteFlg { get; set; }
        [Column("PRO_B_DATE", TypeName = "datetime")]
        public DateTime? ProBDate { get; set; }
        [Column("BACK_VALUE_CD")]
        [StringLength(1)]
        public string BackValueCd { get; set; }
        [Column("PROCESS_END_FG")]
        [StringLength(1)]
        public string ProcessEndFg { get; set; }
        [Column("ACT_UPD_IBF_ID")]
        [StringLength(1)]
        public string ActUpdIbfId { get; set; }
        [Column("ACT_ID")]
        [StringLength(1)]
        public string ActId { get; set; }
        [Column("DR_CR")]
        [StringLength(1)]
        public string DrCr { get; set; }
        [Column("ACT_TYPE")]
        [StringLength(1)]
        public string ActType { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_UPD_CUST_ABBR")]
        [StringLength(12)]
        public string ActUpdCustAbbr { get; set; }
        [Column("ACT_UPD_REF_NO")]
        [StringLength(12)]
        public string ActUpdRefNo { get; set; }
        [Column("ACT_UPD_CCY_CODE")]
        [StringLength(2)]
        public string ActUpdCcyCode { get; set; }
        [Column("ACT_UPD_CCY_ABBR")]
        [StringLength(4)]
        public string ActUpdCcyAbbr { get; set; }
        [Column("AMOUNT_FC", TypeName = "decimal(19, 3)")]
        public decimal? AmountFc { get; set; }
        [Column("CONVERSION_RATE", TypeName = "decimal(9, 5)")]
        public decimal? ConversionRate { get; set; }
        [Column("AMOUNT_BC", TypeName = "decimal(19, 3)")]
        public decimal? AmountBc { get; set; }
        [Column("EXCHANGE_AMT_FC", TypeName = "decimal(19, 3)")]
        public decimal? ExchangeAmtFc { get; set; }
        [Column("EQUIV_CCY_CD")]
        [StringLength(2)]
        public string EquivCcyCd { get; set; }
        [Column("EXCHANGE_RATE", TypeName = "decimal(13, 8)")]
        public decimal? ExchangeRate { get; set; }
        [Column("CHECK_NO")]
        [StringLength(10)]
        public string CheckNo { get; set; }
        [Column("AVAILABILITY_FLG")]
        [StringLength(1)]
        public string AvailabilityFlg { get; set; }
        [Column("AVAILABLE_DATE", TypeName = "datetime")]
        public DateTime? AvailableDate { get; set; }
        [Column("LAST_UPDATE", TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        [Column("LAST_TRANS_NO")]
        [StringLength(5)]
        public string LastTransNo { get; set; }
        [Column("CUST_LIAB_ACCOUNT")]
        [StringLength(5)]
        public string CustLiabAccount { get; set; }
        [Column("PROGRAM_NO")]
        [StringLength(8)]
        public string ProgramNo { get; set; }
        [Column("SEGMENT_TYPE")]
        [StringLength(2)]
        public string SegmentType { get; set; }
        [Column("OD_FLG")]
        [StringLength(1)]
        public string OdFlg { get; set; }
        [Column("TRANS_CD")]
        [StringLength(1)]
        public string TransCd { get; set; }
        [Column("ACT_UPD_RO_NO")]
        [StringLength(3)]
        public string ActUpdRoNo { get; set; }
        [Column("INT_PAYER_COUNTRY")]
        [StringLength(2)]
        public string IntPayerCountry { get; set; }
        [Column("ACT_UPD_REMARKS")]
        [StringLength(1)]
        public string ActUpdRemarks { get; set; }
        [Column("PA_FLG")]
        [StringLength(1)]
        public string PaFlg { get; set; }
        [Column("ACT_UPDATE_FLG")]
        [StringLength(1)]
        public string ActUpdateFlg { get; set; }
        [Column("NO_UPDATE_FLG")]
        [StringLength(1)]
        public string NoUpdateFlg { get; set; }
        [Column("ACT_UPD_CON_CODE")]
        [StringLength(3)]
        public string ActUpdConCode { get; set; }
        [Column("EURO_STL_PA_CD")]
        [StringLength(1)]
        public string EuroStlPaCd { get; set; }
        [Column("INTERNAL_RATE_TYPE")]
        [StringLength(1)]
        public string InternalRateType { get; set; }
        [Column("INTERNAL_RATE", TypeName = "decimal(11, 6)")]
        public decimal? InternalRate { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
