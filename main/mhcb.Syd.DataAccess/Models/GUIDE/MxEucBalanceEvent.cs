using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxEucBalanceEvent", Schema = "dbo")]
    [Index("BatchNo", Name = "NCI_MxEucBalanceEvent_BatchNo")]
    [Index("EventId", "Status", "Category", Name = "NCI_MxEucBalanceEvent_EventIdEtc")]
    [Index("GbaseReferenceNo", "Id", Name = "NCI_MxEucBalanceEvent_GBaseRefNo")]
    public partial class MxEucBalanceEvent
    {
        [Key]
        public int Id { get; set; }
        public int EventId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeSent { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StatusUpdateTime { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string Category { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string EventType { get; set; }
        [Required]
        [Column("GBaseReferenceNo")]
        [StringLength(20)]
        [Unicode(false)]
        public string GbaseReferenceNo { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string CustomerAbbreviation { get; set; }
        [StringLength(3)]
        public string BranchNo { get; set; }
        public int? Account { get; set; }
        [Required]
        [StringLength(12)]
        [Unicode(false)]
        public string TradeDate { get; set; }
        [Required]
        [StringLength(12)]
        [Unicode(false)]
        public string EffectiveDate { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public decimal? NominalAmount { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public decimal? SettlementAmount { get; set; }
        [StringLength(3)]
        public string Currency { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string BorrowOrLend { get; set; }
        [StringLength(12)]
        [Unicode(false)]
        public string ClosingDate { get; set; }
        [StringLength(12)]
        [Unicode(false)]
        public string MaturityDate { get; set; }
        [StringLength(3)]
        public string Revolving { get; set; }
        [StringLength(11)]
        public string FacilityType { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string TradeExternalId { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Rates { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? InitialRate { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? SalesMargin { get; set; }
        public int? BatchNo { get; set; }
    }
}
