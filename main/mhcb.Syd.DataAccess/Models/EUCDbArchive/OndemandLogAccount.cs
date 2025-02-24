using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("ONDEMAND_LOG_ACCOUNT", Schema = "EUC_ONDM")]
    public partial class OndemandLogAccount
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("TRANS_NO")]
        [StringLength(5)]
        public string TransNo { get; set; }
        [Column("SEQ_NO")]
        [StringLength(2)]
        public string SeqNo { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("DEPARTMENT_CD")]
        [StringLength(2)]
        public string DepartmentCd { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("DD_NO")]
        [StringLength(3)]
        public string DdNo { get; set; }
        [Column("RO_NO")]
        [StringLength(3)]
        public string RoNo { get; set; }
        [Column("ONLINE_CD")]
        [StringLength(4)]
        public string OnlineCd { get; set; }
        [Column("OPE_KIND")]
        [StringLength(1)]
        public string OpeKind { get; set; }
        [Column("INPUT_EMP_CD")]
        [StringLength(4)]
        public string InputEmpCd { get; set; }
        [Column("INPUT_OPE_ID")]
        [StringLength(3)]
        public string InputOpeId { get; set; }
        [Column("APPROVE_EMP_CD")]
        [StringLength(4)]
        public string ApproveEmpCd { get; set; }
        [Column("APPROVE_OPE_ID")]
        [StringLength(3)]
        public string ApproveOpeId { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("IRREGULAR_TRANS_FLG")]
        [StringLength(2)]
        public string IrregularTransFlg { get; set; }
        [Column("IBF_ID_2")]
        [StringLength(1)]
        public string IbfId2 { get; set; }
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
        [Column("ACT_ABBR")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_NO_2")]
        [StringLength(12)]
        public string RefNo2 { get; set; }
        [Column("CCY_CODE")]
        [StringLength(2)]
        public string CcyCode { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("AMOUNT_FC", TypeName = "decimal(16, 3)")]
        public decimal? AmountFc { get; set; }
        [Column("CONVERSION_RATE", TypeName = "decimal(9, 5)")]
        public decimal? ConversionRate { get; set; }
        [Column("AMOUNT_BC", TypeName = "decimal(16, 3)")]
        public decimal? AmountBc { get; set; }
        [Column("EQUIV_CCY_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? EquivCcyAmount { get; set; }
        [Column("EQUIV_CCY_CD")]
        [StringLength(2)]
        public string EquivCcyCd { get; set; }
        [Column("EQUIV_RATE", TypeName = "decimal(13, 8)")]
        public decimal? EquivRate { get; set; }
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
        [Column("RO_NO_2")]
        [StringLength(3)]
        public string RoNo2 { get; set; }
        [Column("INT_PAYER_COUNTRY")]
        [StringLength(2)]
        public string IntPayerCountry { get; set; }
        [Column("REMARKS_FLG")]
        [StringLength(1)]
        public string RemarksFlg { get; set; }
        [Column("PA_FLG")]
        [StringLength(1)]
        public string PaFlg { get; set; }
        [Column("UPDATE_FLG")]
        [StringLength(1)]
        public string UpdateFlg { get; set; }
        [Column("NO_UPDATE_FLG")]
        [StringLength(1)]
        public string NoUpdateFlg { get; set; }
        [Column("CRT_DATE")]
        [StringLength(19)]
        public string CrtDate { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
        [Column("BATCH_NUMBER")]
        public int? BatchNumber { get; set; }
    }
}
