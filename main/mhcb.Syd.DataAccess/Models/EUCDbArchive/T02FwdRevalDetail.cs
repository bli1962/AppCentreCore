using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T02_FWD_REVAL_DETAIL", Schema = "EUC")]
    public partial class T02FwdRevalDetail
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
        [Column("ON_MEMO_CD")]
        [StringLength(1)]
        public string OnMemoCd { get; set; }
        [Column("TRANS_CD")]
        [StringLength(1)]
        public string TransCd { get; set; }
        [Column("SOLD_BOUGHT_ID")]
        [StringLength(1)]
        public string SoldBoughtId { get; set; }
        [Column("ESTMATE_ID")]
        [StringLength(1)]
        public string EstmateId { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("CONTRACT_DATE", TypeName = "datetime")]
        public DateTime? ContractDate { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("SETTLEMENT_DATE", TypeName = "datetime")]
        public DateTime? SettlementDate { get; set; }
        [Column("FWD_POSITION_FC", TypeName = "decimal(21, 3)")]
        public decimal? FwdPositionFc { get; set; }
        [Column("FWD_POSITION_BC", TypeName = "decimal(27, 3)")]
        public decimal? FwdPositionBc { get; set; }
        [Column("CONTRACT_RATE", TypeName = "decimal(14, 8)")]
        public decimal? ContractRate { get; set; }
        [Column("FWD_POSITION_EQUIV", TypeName = "decimal(21, 3)")]
        public decimal? FwdPositionEquiv { get; set; }
        [Column("FWD_REVAL_RATE", TypeName = "decimal(14, 8)")]
        public decimal? FwdRevalRate { get; set; }
        [Column("FWD_REVAL_AMOUNT", TypeName = "decimal(25, 3)")]
        public decimal? FwdRevalAmount { get; set; }
        [Column("DEF_REVAL_AMOUNT", TypeName = "decimal(25, 3)")]
        public decimal? DefRevalAmount { get; set; }
        [Column("COST", TypeName = "decimal(12, 10)")]
        public decimal? Cost { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
