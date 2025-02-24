using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T04_SECURITY_DETAILS", Schema = "EUC")]
    public partial class T04SecurityDetail
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_NAME")]
        [StringLength(30)]
        public string ActName { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("STOCK_CD")]
        [StringLength(1)]
        public string StockCd { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("CUST_NAME")]
        [StringLength(40)]
        public string CustName { get; set; }
        [Column("FINAL_MATURITY", TypeName = "datetime")]
        public DateTime? FinalMaturity { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("REDEMPTION_1")]
        [StringLength(1)]
        public string Redemption1 { get; set; }
        [Column("REDEMPTION_2")]
        [StringLength(1)]
        public string Redemption2 { get; set; }
        [Column("PUBLIC_PRIVATE")]
        [StringLength(2)]
        public string PublicPrivate { get; set; }
        [Column("FACE_BAL_FC", TypeName = "decimal(16, 3)")]
        public decimal? FaceBalFc { get; set; }
        [Column("FACE_BAL_BC", TypeName = "decimal(16, 3)")]
        public decimal? FaceBalBc { get; set; }
        [Column("BEFORE_AMORT_ACM_FC", TypeName = "decimal(16, 3)")]
        public decimal? BeforeAmortAcmFc { get; set; }
        [Column("BEFORE_AMORT_ACM_BC", TypeName = "decimal(16, 3)")]
        public decimal? BeforeAmortAcmBc { get; set; }
        [Column("AMORT_ACM_AMT_FC", TypeName = "decimal(16, 3)")]
        public decimal? AmortAcmAmtFc { get; set; }
        [Column("AMORT_ACM_AMT_BC", TypeName = "decimal(16, 3)")]
        public decimal? AmortAcmAmtBc { get; set; }
        [Column("AFTER_AMORT_ACM_FC", TypeName = "decimal(16, 3)")]
        public decimal? AfterAmortAcmFc { get; set; }
        [Column("AFTER_AMORT_ACM_BC", TypeName = "decimal(16, 3)")]
        public decimal? AfterAmortAcmBc { get; set; }
        [Column("REVAL_AMT_FC", TypeName = "decimal(16, 3)")]
        public decimal? RevalAmtFc { get; set; }
        [Column("REVAL_AMT_BC", TypeName = "decimal(16, 3)")]
        public decimal? RevalAmtBc { get; set; }
        [Column("MTM_BAL_FC", TypeName = "decimal(16, 3)")]
        public decimal? MtmBalFc { get; set; }
        [Column("MTM_BAL_BC", TypeName = "decimal(16, 3)")]
        public decimal? MtmBalBc { get; set; }
        [Column("AMORT_ACM_FLG")]
        [StringLength(1)]
        public string AmortAcmFlg { get; set; }
        [Column("FORM")]
        [StringLength(4)]
        public string Form { get; set; }
        [Column("BASE_CCY_CD")]
        [StringLength(2)]
        public string BaseCcyCd { get; set; }
        [Column("BASE_CCY_ABBR")]
        [StringLength(4)]
        public string BaseCcyAbbr { get; set; }
        [Column("NATIONALITY")]
        [StringLength(2)]
        public string Nationality { get; set; }
        [Column("LOCATION_COUNTRY")]
        [StringLength(2)]
        public string LocationCountry { get; set; }
        [Column("JAPANESE_FLG")]
        [StringLength(1)]
        public string JapaneseFlg { get; set; }
        [Column("ATTRIBUTE_CD")]
        [StringLength(1)]
        public string AttributeCd { get; set; }
        [Column("DKB_COMPANY_CD")]
        [StringLength(1)]
        public string DkbCompanyCd { get; set; }
        [Column("TERM")]
        [StringLength(7)]
        public string Term { get; set; }
        [Column("CONTRACT_DATE", TypeName = "datetime")]
        public DateTime? ContractDate { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
