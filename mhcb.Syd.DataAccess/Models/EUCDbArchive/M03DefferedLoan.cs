using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M03_DEFFERED_LOAN", Schema = "EUC")]
    public partial class M03DefferedLoan
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("DD_NO")]
        [StringLength(3)]
        public string DdNo { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("RESCHEDULED_FLG")]
        [StringLength(1)]
        public string RescheduledFlg { get; set; }
        [Column("OVERDUE_FLG")]
        [StringLength(1)]
        public string OverdueFlg { get; set; }
        [Column("PRNCPL_PRV_M", TypeName = "decimal(16, 3)")]
        public decimal? PrncplPrvM { get; set; }
        [Column("PRNCPL_PRV_M_BC", TypeName = "decimal(16, 3)")]
        public decimal? PrncplPrvMBc { get; set; }
        [Column("PRNCPL_INCRS", TypeName = "decimal(16, 3)")]
        public decimal? PrncplIncrs { get; set; }
        [Column("PRNCPL_INCRS_BC", TypeName = "decimal(16, 3)")]
        public decimal? PrncplIncrsBc { get; set; }
        [Column("PRNCPL_DECRS", TypeName = "decimal(16, 3)")]
        public decimal? PrncplDecrs { get; set; }
        [Column("PRNCPL_DECRS_BC", TypeName = "decimal(16, 3)")]
        public decimal? PrncplDecrsBc { get; set; }
        [Column("PRINCIPAL", TypeName = "decimal(16, 3)")]
        public decimal? Principal { get; set; }
        [Column("PRINCIPAL_BC", TypeName = "decimal(16, 3)")]
        public decimal? PrincipalBc { get; set; }
        [Column("PRNCPL_NONPAY_START", TypeName = "datetime")]
        public DateTime? PrncplNonpayStart { get; set; }
        [Column("INT_ACCR_CALC_START", TypeName = "datetime")]
        public DateTime? IntAccrCalcStart { get; set; }
        [Column("INT_NONPAY_START", TypeName = "datetime")]
        public DateTime? IntNonpayStart { get; set; }
        [Column("INT_ACCR_PRV_M", TypeName = "decimal(16, 3)")]
        public decimal? IntAccrPrvM { get; set; }
        [Column("INT_ACCR_PRV_M_BC", TypeName = "decimal(16, 3)")]
        public decimal? IntAccrPrvMBc { get; set; }
        [Column("INT_ACCR_INCRS", TypeName = "decimal(16, 3)")]
        public decimal? IntAccrIncrs { get; set; }
        [Column("INT_ACCR_INCRS_BC", TypeName = "decimal(16, 3)")]
        public decimal? IntAccrIncrsBc { get; set; }
        [Column("INT_ACCR_DECRS", TypeName = "decimal(16, 3)")]
        public decimal? IntAccrDecrs { get; set; }
        [Column("INT_ACCR_DECRS_BC", TypeName = "decimal(16, 3)")]
        public decimal? IntAccrDecrsBc { get; set; }
        [Column("TRANS_TO_NON_ACCR", TypeName = "decimal(16, 3)")]
        public decimal? TransToNonAccr { get; set; }
        [Column("TRANS_TO_NON_ACCR_BC", TypeName = "decimal(16, 3)")]
        public decimal? TransToNonAccrBc { get; set; }
        [Column("TRANS_FRM_NON_ACCR", TypeName = "decimal(16, 3)")]
        public decimal? TransFrmNonAccr { get; set; }
        [Column("TRANS_FRM_NON_ACCR_BC", TypeName = "decimal(16, 3)")]
        public decimal? TransFrmNonAccrBc { get; set; }
        [Column("INT_ACCR", TypeName = "decimal(16, 3)")]
        public decimal? IntAccr { get; set; }
        [Column("INT_ACCR_BC", TypeName = "decimal(16, 3)")]
        public decimal? IntAccrBc { get; set; }
        [Column("INT_REALIZED_TTL", TypeName = "decimal(16, 3)")]
        public decimal? IntRealizedTtl { get; set; }
        [Column("INT_REALIZED_TTL_BC", TypeName = "decimal(16, 3)")]
        public decimal? IntRealizedTtlBc { get; set; }
        [Column("NON_ACCR_PRV_M", TypeName = "decimal(16, 3)")]
        public decimal? NonAccrPrvM { get; set; }
        [Column("NON_ACCR_PRV_M_BC", TypeName = "decimal(16, 3)")]
        public decimal? NonAccrPrvMBc { get; set; }
        [Column("NON_ACCR_INCRS", TypeName = "decimal(16, 3)")]
        public decimal? NonAccrIncrs { get; set; }
        [Column("NON_ACCR_INCRS_BC", TypeName = "decimal(16, 3)")]
        public decimal? NonAccrIncrsBc { get; set; }
        [Column("NON_ACCR_DECRS", TypeName = "decimal(16, 3)")]
        public decimal? NonAccrDecrs { get; set; }
        [Column("NON_ACCR_DECRS_BC", TypeName = "decimal(16, 3)")]
        public decimal? NonAccrDecrsBc { get; set; }
        [Column("INT_PART_GIVEN_UP", TypeName = "decimal(16, 3)")]
        public decimal? IntPartGivenUp { get; set; }
        [Column("INT_PART_GIVEN_UP_BC", TypeName = "decimal(16, 3)")]
        public decimal? IntPartGivenUpBc { get; set; }
        [Column("INT_WRITTEN_OFF", TypeName = "decimal(16, 3)")]
        public decimal? IntWrittenOff { get; set; }
        [Column("INT_WRITTEN_OFF_BC", TypeName = "decimal(16, 3)")]
        public decimal? IntWrittenOffBc { get; set; }
        [Column("NON_ACCR", TypeName = "decimal(16, 3)")]
        public decimal? NonAccr { get; set; }
        [Column("NON_ACCR_BC", TypeName = "decimal(16, 3)")]
        public decimal? NonAccrBc { get; set; }
        [Column("NON_ACCR_START", TypeName = "datetime")]
        public DateTime? NonAccrStart { get; set; }
        [Column("OVERDUE_INT", TypeName = "decimal(16, 3)")]
        public decimal? OverdueInt { get; set; }
        [Column("OVERDUE_INT_BC", TypeName = "decimal(16, 3)")]
        public decimal? OverdueIntBc { get; set; }
        [Column("ACCELERATION", TypeName = "decimal(8, 0)")]
        public decimal? Acceleration { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
