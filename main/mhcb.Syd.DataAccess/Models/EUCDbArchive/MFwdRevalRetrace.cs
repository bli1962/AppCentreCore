using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M_FWD_REVAL_RETRACE", Schema = "EUC")]
    public partial class MFwdRevalRetrace
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("PRO_B_DATE", TypeName = "datetime")]
        public DateTime? ProBDate { get; set; }
        [Column("ON_MEMO_FLG")]
        [StringLength(1)]
        public string OnMemoFlg { get; set; }
        [Column("ACCOUNT_ID")]
        [StringLength(1)]
        public string AccountId { get; set; }
        [Column("TRANS_CD")]
        [StringLength(1)]
        public string TransCd { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("SUB_REF_NO")]
        [StringLength(2)]
        public string SubRefNo { get; set; }
        [Column("SECTION_CD")]
        [StringLength(2)]
        public string SectionCd { get; set; }
        [Column("EST_ID")]
        [StringLength(1)]
        public string EstId { get; set; }
        [Column("CONTRACT_DATE", TypeName = "datetime")]
        public DateTime? ContractDate { get; set; }
        [Column("CCY_CODE_1")]
        [StringLength(2)]
        public string CcyCode1 { get; set; }
        [Column("CCY_ABBR_1")]
        [StringLength(4)]
        public string CcyAbbr1 { get; set; }
        [Column("BUY_SELL_1")]
        [StringLength(1)]
        public string BuySell1 { get; set; }
        [Column("POSITION_1", TypeName = "decimal(19, 3)")]
        public decimal? Position1 { get; set; }
        [Column("CONTRACT_RATE_1", TypeName = "decimal(10, 6)")]
        public decimal? ContractRate1 { get; set; }
        [Column("EXCHANGE_RATE_1", TypeName = "decimal(13, 8)")]
        public decimal? ExchangeRate1 { get; set; }
        [Column("EQUIVALENT_1", TypeName = "decimal(19, 3)")]
        public decimal? Equivalent1 { get; set; }
        [Column("REVL_RATE_1", TypeName = "decimal(13, 8)")]
        public decimal? RevlRate1 { get; set; }
        [Column("REVL_EQUIV_1", TypeName = "decimal(21, 3)")]
        public decimal? RevlEquiv1 { get; set; }
        [Column("PARITY_VALUE_1", TypeName = "decimal(11, 10)")]
        public decimal? ParityValue1 { get; set; }
        [Column("REVAL_DIF_1", TypeName = "decimal(21, 3)")]
        public decimal? RevalDif1 { get; set; }
        [Column("BF_NPV_REVAL_DIF_1", TypeName = "decimal(21, 3)")]
        public decimal? BfNpvRevalDif1 { get; set; }
        [Column("CCY_CODE_2")]
        [StringLength(2)]
        public string CcyCode2 { get; set; }
        [Column("CCY_ABBR_2")]
        [StringLength(4)]
        public string CcyAbbr2 { get; set; }
        [Column("BUY_SELL_2")]
        [StringLength(1)]
        public string BuySell2 { get; set; }
        [Column("POSITION_2", TypeName = "decimal(19, 3)")]
        public decimal? Position2 { get; set; }
        [Column("CONTRACT_RATE_2", TypeName = "decimal(10, 6)")]
        public decimal? ContractRate2 { get; set; }
        [Column("EXCHANGE_RATE_2", TypeName = "decimal(13, 8)")]
        public decimal? ExchangeRate2 { get; set; }
        [Column("EQUIVALENT_2", TypeName = "decimal(19, 3)")]
        public decimal? Equivalent2 { get; set; }
        [Column("REVL_RATE_2", TypeName = "decimal(13, 8)")]
        public decimal? RevlRate2 { get; set; }
        [Column("REVL_EQUIV_2", TypeName = "decimal(21, 3)")]
        public decimal? RevlEquiv2 { get; set; }
        [Column("PARITY_VALUE_2", TypeName = "decimal(11, 10)")]
        public decimal? ParityValue2 { get; set; }
        [Column("REVAL_DIF_2", TypeName = "decimal(21, 3)")]
        public decimal? RevalDif2 { get; set; }
        [Column("BF_NPV_REVAL_DIF_2", TypeName = "decimal(21, 3)")]
        public decimal? BfNpvRevalDif2 { get; set; }
        [Column("NPV_ID")]
        [StringLength(3)]
        public string NpvId { get; set; }
        [Column("REMARKS")]
        [StringLength(40)]
        public string Remarks { get; set; }
        [Column("ADJUST_NO")]
        [StringLength(4)]
        public string AdjustNo { get; set; }
        [Column("LAST_ADJUST_NO")]
        [StringLength(4)]
        public string LastAdjustNo { get; set; }
        [Column("OPE_DATE", TypeName = "datetime")]
        public DateTime? OpeDate { get; set; }
        [Column("MODIFIED_DATE", TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("DELETE_FLG")]
        [StringLength(1)]
        public string DeleteFlg { get; set; }
        [Column("CON_CODE")]
        [StringLength(3)]
        public string ConCode { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
