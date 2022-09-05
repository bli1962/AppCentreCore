using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Collect_PaymentCreation_MultiPurposeInstructionDetail")]
    public partial class DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetail
    {
        [Key]
        public int RecCollectPaymentCreationMultiPurposeInstructionDetailId { get; set; }
        public int RecCollectionId { get; set; }
        public int? MultiPurposeInstructionDetailId { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }
        [Column("GCMSReferenceNumber")]
        [StringLength(50)]
        public string GcmsreferenceNumber { get; set; }
        [StringLength(50)]
        public string CustomerUnitCode { get; set; }
        [StringLength(50)]
        public string CustomerUnitName { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(50)]
        public string TransactionMethod { get; set; }
        [StringLength(50)]
        public string Currency { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        public int? NumberofTransactions { get; set; }
        [StringLength(50)]
        public string Attachment { get; set; }
        [StringLength(1024)]
        public string Message { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [StringLength(1024)]
        public string RejectedReason { get; set; }
        public bool? AttachmentDownloaded { get; set; }
        public bool? Processed { get; set; }
        public int? PaymentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MultipurposeInstructionDetailCreatedWhen { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(RecCollectionId))]
        [InverseProperty(nameof(DomesticClearingRecCollection.DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetails))]
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
