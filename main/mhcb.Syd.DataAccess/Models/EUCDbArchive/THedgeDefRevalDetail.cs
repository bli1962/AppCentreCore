using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T_HEDGE_DEF_REVAL_DETAIL", Schema = "EUC")]
    public partial class THedgeDefRevalDetail
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("SYSTEM_CODE")]
        [StringLength(2)]
        public string SystemCode { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("REF_SUB_NO")]
        [StringLength(3)]
        public string RefSubNo { get; set; }
        [Column("TRANS_CD")]
        [StringLength(1)]
        public string TransCd { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("PL_ACT_CD")]
        [StringLength(5)]
        public string PlActCd { get; set; }
        [Column("CONTRACT_DATE", TypeName = "datetime")]
        public DateTime? ContractDate { get; set; }
        [Column("DUE_DATE", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("HEDGE_TYPE")]
        [StringLength(1)]
        public string HedgeType { get; set; }
        [Column("FIXED_FLOAT")]
        [StringLength(1)]
        public string FixedFloat { get; set; }
        [Column("MTM_AMOUNT_FC", TypeName = "decimal(21, 3)")]
        public decimal? MtmAmountFc { get; set; }
        [Column("MTM_AMOUNT_BC", TypeName = "decimal(21, 3)")]
        public decimal? MtmAmountBc { get; set; }
        [Column("ACCRUAL_PL_FC", TypeName = "decimal(21, 3)")]
        public decimal? AccrualPlFc { get; set; }
        [Column("ACCRUAL_PL_BC", TypeName = "decimal(21, 3)")]
        public decimal? AccrualPlBc { get; set; }
        [Column("FWD_REVAL_FC", TypeName = "decimal(21, 3)")]
        public decimal? FwdRevalFc { get; set; }
        [Column("FWD_REVAL_BC", TypeName = "decimal(21, 3)")]
        public decimal? FwdRevalBc { get; set; }
        [Column("DEF_REVAL_FC", TypeName = "decimal(21, 3)")]
        public decimal? DefRevalFc { get; set; }
        [Column("DEF_REVAL_BC", TypeName = "decimal(21, 3)")]
        public decimal? DefRevalBc { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
