using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Collect_GO_GOPosting")]
    public partial class DomesticClearingRecCollectGoGoposting
    {
        [Key]
        [Column("RecCollectGOGOPostingId")]
        public int RecCollectGogopostingId { get; set; }
        public int RecCollectionId { get; set; }
        [Column("GOPostingId")]
        public int? GopostingId { get; set; }
        [Column("GBaseRefNo")]
        [StringLength(20)]
        public string GbaseRefNo { get; set; }
        [StringLength(5)]
        public string TransNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Adjustment { get; set; }
        [StringLength(2)]
        public string CurrencyCode { get; set; }
        [StringLength(30)]
        public string Remark { get; set; }
        [StringLength(20)]
        public string DebitAccountCode { get; set; }
        [StringLength(20)]
        public string DebitAccountNo { get; set; }
        [StringLength(20)]
        public string CreditAccountCode { get; set; }
        [StringLength(20)]
        public string CreditAccountNo { get; set; }
        [StringLength(12)]
        public string DebitCustomerAbbreviation { get; set; }
        [StringLength(12)]
        public string CreditCustomerAbbreviation { get; set; }
        public int? DirectionId { get; set; }
        public bool? NeedsAutomaticApproval { get; set; }
        [StringLength(18)]
        public string CreditMinNo { get; set; }
        [StringLength(18)]
        public string DebitMinNo { get; set; }
        public int? PaymentId { get; set; }
        public int? StatusId { get; set; }
        public int? PostingTypeId { get; set; }
        [StringLength(50)]
        public string StatusIdUpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OperationDate { get; set; }
        public int? PaymentLineId { get; set; }
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }

        [ForeignKey(nameof(RecCollectionId))]
        [InverseProperty(nameof(DomesticClearingRecCollection.DomesticClearingRecCollectGoGopostings))]
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
