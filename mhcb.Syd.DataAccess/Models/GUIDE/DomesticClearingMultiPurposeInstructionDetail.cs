using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_MultiPurposeInstructionDetail")]
    public partial class DomesticClearingMultiPurposeInstructionDetail
    {
        public DomesticClearingMultiPurposeInstructionDetail()
        {
            DomesticClearingMultiPurposeInstructionAttachments = new HashSet<DomesticClearingMultiPurposeInstructionAttachment>();
        }

        [Key]
        public int MultiPurposeInstructionDetailId { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        public bool AttachmentDownloaded { get; set; }
        public bool Processed { get; set; }
        public int? PaymentId { get; set; }

        [ForeignKey(nameof(PaymentId))]
        [InverseProperty(nameof(DomesticClearingPayment.DomesticClearingMultiPurposeInstructionDetails))]
        public virtual DomesticClearingPayment Payment { get; set; }
        [InverseProperty(nameof(DomesticClearingMultiPurposeInstructionAttachment.MultiPurposeInstructionDetail))]
        public virtual ICollection<DomesticClearingMultiPurposeInstructionAttachment> DomesticClearingMultiPurposeInstructionAttachments { get; set; }
    }
}
