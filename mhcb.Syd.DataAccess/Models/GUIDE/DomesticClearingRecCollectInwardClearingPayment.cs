using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Collect_InwardClearing_Payment")]
    public partial class DomesticClearingRecCollectInwardClearingPayment
    {
        [Key]
        public int RecCollectInwardClearingPaymentId { get; set; }
        public int RecCollectionId { get; set; }
        public int? PaymentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? TotalAmount { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Fees { get; set; }
        [StringLength(2)]
        public string CurrencyCode { get; set; }
        [StringLength(255)]
        public string CustomerCurrentAccount { get; set; }
        public int? StatusId { get; set; }
        [StringLength(50)]
        public string StatusIdUpdatedWho { get; set; }
        [Column("GCMSReferenceNumber")]
        [StringLength(50)]
        public string GcmsreferenceNumber { get; set; }
        public int? DirectionId { get; set; }
        public int? MainPostId { get; set; }
        public int? FeePostId { get; set; }
        [StringLength(12)]
        public string CustomerAbbreviation { get; set; }
        public int? PaymentMethodId { get; set; }
        [Required]
        [StringLength(3)]
        public string BranchNo { get; set; }
        public bool? IsClearerExtracted { get; set; }
        [StringLength(100)]
        public string ClearerExtractFileName { get; set; }
        [StringLength(50)]
        public string UnitCode { get; set; }
        [StringLength(50)]
        public string AccountName { get; set; }
        public int? Lines { get; set; }
        public bool? IsValid { get; set; }
        [Column("IsPaymentGOPosted")]
        public bool? IsPaymentGoposted { get; set; }
        [Column("IsFeeGOPosted")]
        public bool? IsFeeGoposted { get; set; }
        public bool? IsClearerReceived { get; set; }
        [Column("BSB")]
        [StringLength(255)]
        public string Bsb { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProcessDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AvailableDate { get; set; }
        [StringLength(255)]
        public string OriginalAccountName { get; set; }
        public int? ChequesCount { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? ChequesValue { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? CashValue { get; set; }
        [StringLength(50)]
        public string ChequeNo { get; set; }
        [StringLength(30)]
        public string Remark { get; set; }
        public int? PreviousStatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(RecCollectionId))]
        [InverseProperty(nameof(DomesticClearingRecCollection.DomesticClearingRecCollectInwardClearingPayments))]
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
