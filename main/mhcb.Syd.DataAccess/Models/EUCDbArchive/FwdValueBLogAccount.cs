using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("FWD_VALUE_B_LOG_ACCOUNT", Schema = "EUC")]
    public partial class FwdValueBLogAccount
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("SYSTEM_CODE")]
        [StringLength(2)]
        public string SystemCode { get; set; }
        [Column("OPE_DATE", TypeName = "datetime")]
        public DateTime? OpeDate { get; set; }
        [Column("FWD_VALDT_TRANS_NO")]
        [StringLength(5)]
        public string FwdValdtTransNo { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
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
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("AMOUNT_FC", TypeName = "decimal(19, 3)")]
        public decimal? AmountFc { get; set; }
        [Column("CONVERSION_RATE", TypeName = "decimal(9, 5)")]
        public decimal? ConversionRate { get; set; }
        [Column("AMOUNT_BC", TypeName = "decimal(19, 3)")]
        public decimal? AmountBc { get; set; }
        [Column("EQUIV_CCY_AMOUNT", TypeName = "decimal(19, 3)")]
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
        [Column("RO_NO")]
        [StringLength(3)]
        public string RoNo { get; set; }
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
        [Column("CON_CD")]
        [StringLength(3)]
        public string ConCd { get; set; }
        [Column("INTERNAL_RATE_TYPE")]
        [StringLength(1)]
        public string InternalRateType { get; set; }
        [Column("INTERNAL_RATE", TypeName = "decimal(9, 6)")]
        public decimal? InternalRate { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
