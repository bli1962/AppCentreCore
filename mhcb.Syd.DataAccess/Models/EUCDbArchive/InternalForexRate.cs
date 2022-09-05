using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("INTERNAL_FOREX_RATE", Schema = "EUC")]
    public partial class InternalForexRate
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("CONTRACT_DATE_OPE", TypeName = "datetime")]
        public DateTime? ContractDateOpe { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("TRANS_NO")]
        [StringLength(5)]
        public string TransNo { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("CONTRACT_NO")]
        [StringLength(12)]
        public string ContractNo { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("CONTRACT_DATE_VALUE", TypeName = "datetime")]
        public DateTime? ContractDateValue { get; set; }
        [Column("CONTRACT_CCY_CD")]
        [StringLength(2)]
        public string ContractCcyCd { get; set; }
        [Column("CONTRACT_CCY_ABBR")]
        [StringLength(4)]
        public string ContractCcyAbbr { get; set; }
        [Column("CONTRACT_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal? ContractCcyAmt { get; set; }
        [Column("EQUIV_CCY_CD")]
        [StringLength(2)]
        public string EquivCcyCd { get; set; }
        [Column("EQUIV_CCY_ABBR")]
        [StringLength(4)]
        public string EquivCcyAbbr { get; set; }
        [Column("EQUIV_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal? EquivCcyAmt { get; set; }
        [Column("EXCHANGE_RATE", TypeName = "decimal(13, 8)")]
        public decimal? ExchangeRate { get; set; }
        [Column("INTERNAL_RATE", TypeName = "decimal(13, 8)")]
        public decimal? InternalRate { get; set; }
        [Column("PLINF_CCY_CD")]
        [StringLength(2)]
        public string PlinfCcyCd { get; set; }
        [Column("PLINF_CCY_ABBR")]
        [StringLength(4)]
        public string PlinfCcyAbbr { get; set; }
        [Column("PLINF_CCY_AMT", TypeName = "decimal(16, 3)")]
        public decimal? PlinfCcyAmt { get; set; }
        [Column("DEPT_CD")]
        [StringLength(2)]
        public string DeptCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
