using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Collect_Payment_DEReplyHeader")]
    public partial class DomesticClearingRecCollectPaymentDereplyHeader
    {
        [Key]
        [Column("RecCollectPaymentDEReplyHeaderId")]
        public int RecCollectPaymentDereplyHeaderId { get; set; }
        public int RecCollectionId { get; set; }
        [StringLength(1)]
        public string RecordType { get; set; }
        [StringLength(14)]
        public string PaymentReferenceNumber { get; set; }
        [Column("BSBNumber")]
        [StringLength(7)]
        public string Bsbnumber { get; set; }
        [StringLength(9)]
        public string AccountNumberDebitCredit { get; set; }
        [StringLength(16)]
        public string DateTimeProcessed { get; set; }
        [StringLength(50)]
        public string ReportingMethod { get; set; }
        [StringLength(16)]
        public string UserIdNumber { get; set; }
        [StringLength(12)]
        public string EntriesDescription { get; set; }
        [StringLength(8)]
        public string DateToBeProcessed { get; set; }
        [StringLength(22)]
        public string CustomerReference { get; set; }
        [StringLength(1)]
        public string PendingAuthorisation { get; set; }
        [StringLength(4)]
        public string FailReasonCode { get; set; }
        [StringLength(40)]
        public string FailReasonText { get; set; }
        public int? NumberOfValidItems { get; set; }
        public int? NumberOfItemsFailed { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? CreditTotalsOfValidItems { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? DebitTotalsOfValidItems { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? CreditTotalsOfFailedItems { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? DebitTotalsOfFailedItems { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(RecCollectionId))]
        [InverseProperty(nameof(DomesticClearingRecCollection.DomesticClearingRecCollectPaymentDereplyHeaders))]
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
