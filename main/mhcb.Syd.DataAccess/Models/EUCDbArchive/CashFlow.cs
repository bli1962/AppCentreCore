using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("CASH_FLOW", Schema = "EUC")]
    public partial class CashFlow
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("EVENT_DATE", TypeName = "datetime")]
        public DateTime? EventDate { get; set; }
        [Column("LO_BB_IBD_INV_INCOMING_AMOUNT", TypeName = "decimal(7, 0)")]
        public decimal? LoBbIbdInvIncomingAmount { get; set; }
        [Column("LO_BB_IBD_INV_OUTGOING_AMOUNT", TypeName = "decimal(7, 0)")]
        public decimal? LoBbIbdInvOutgoingAmount { get; set; }
        [Column("LO_BB_IBD_INV_NET_AMOUNT", TypeName = "decimal(7, 0)")]
        public decimal? LoBbIbdInvNetAmount { get; set; }
        [Column("LO_BB_IBD_INV_INT_AMOUNT", TypeName = "decimal(6, 0)")]
        public decimal? LoBbIbdInvIntAmount { get; set; }
        [Column("MM_SW_INCOMING_AMOUNT", TypeName = "decimal(7, 0)")]
        public decimal? MmSwIncomingAmount { get; set; }
        [Column("MM_SW_OUTGOING_AMOUNT", TypeName = "decimal(7, 0)")]
        public decimal? MmSwOutgoingAmount { get; set; }
        [Column("MM_SW_NET_AMOUNT", TypeName = "decimal(7, 0)")]
        public decimal? MmSwNetAmount { get; set; }
        [Column("MM_SW_INT_AMOUNT", TypeName = "decimal(6, 0)")]
        public decimal? MmSwIntAmount { get; set; }
        [Column("FX_PURCHASE_AMOUNT", TypeName = "decimal(7, 0)")]
        public decimal? FxPurchaseAmount { get; set; }
        [Column("FX_SALE_AMOUNT", TypeName = "decimal(7, 0)")]
        public decimal? FxSaleAmount { get; set; }
        [Column("FX_NET_AMOUNT", TypeName = "decimal(7, 0)")]
        public decimal? FxNetAmount { get; set; }
        [Column("NET_AMOUNT", TypeName = "decimal(7, 0)")]
        public decimal? NetAmount { get; set; }
        [Column("DFB_IO_BAL", TypeName = "decimal(7, 0)")]
        public decimal? DfbIoBal { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
