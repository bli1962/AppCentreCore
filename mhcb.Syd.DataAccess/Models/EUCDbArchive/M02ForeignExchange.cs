using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M02_FOREIGN_EXCHANGE", Schema = "EUC")]
    public partial class M02ForeignExchange
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
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
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("COVER_PO_FLG")]
        [StringLength(1)]
        public string CoverPoFlg { get; set; }
        [Column("CONTRACT_DATE_OPE", TypeName = "datetime")]
        public DateTime? ContractDateOpe { get; set; }
        [Column("CONTRACT_DATE_VALUE", TypeName = "datetime")]
        public DateTime? ContractDateValue { get; set; }
        [Column("DELIVARY_DATE", TypeName = "datetime")]
        public DateTime? DelivaryDate { get; set; }
        [Column("DELIVARY_THRU", TypeName = "datetime")]
        public DateTime? DelivaryThru { get; set; }
        [Column("CONTRACT_CCY_ABBR")]
        [StringLength(4)]
        public string ContractCcyAbbr { get; set; }
        [Column("CONTRACT_CCY_CD")]
        [StringLength(2)]
        public string ContractCcyCd { get; set; }
        [Column("CONTRACT_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal? ContractCcyAmt { get; set; }
        [Column("CONTRACT_CCY_BAL", TypeName = "decimal(16, 3)")]
        public decimal? ContractCcyBal { get; set; }
        [Column("EXCHANGE_RATE", TypeName = "decimal(13, 8)")]
        public decimal? ExchangeRate { get; set; }
        [Column("EQUIV_CCY_ABBR")]
        [StringLength(4)]
        public string EquivCcyAbbr { get; set; }
        [Column("EQUIV_CCY_CD")]
        [StringLength(2)]
        public string EquivCcyCd { get; set; }
        [Column("EQUIV_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal? EquivCcyAmt { get; set; }
        [Column("EQUIV_CCY_BAL", TypeName = "decimal(16, 3)")]
        public decimal? EquivCcyBal { get; set; }
        [Column("SPREAD", TypeName = "decimal(9, 6)")]
        public decimal? Spread { get; set; }
        [Column("SWAP_REF_NO")]
        [StringLength(12)]
        public string SwapRefNo { get; set; }
        [Column("BROKER")]
        [StringLength(12)]
        public string Broker { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("AUTHORIZED")]
        [StringLength(1)]
        public string Authorized { get; set; }
        [Column("REVISE")]
        [StringLength(1)]
        public string Revise { get; set; }
        [Column("INTERNAL_RATE")]
        [StringLength(14)]
        public string InternalRate { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
