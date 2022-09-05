using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_MultiPurposeInstructionAttachment")]
    public partial class DomesticClearingMultiPurposeInstructionAttachment
    {
        [Key]
        public int MultiPurposeInstructionAttachmentId { get; set; }
        public int MultiPurposeInstructionDetailId { get; set; }
        [StringLength(255)]
        public string CustomerName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Amount { get; set; }
        [StringLength(255)]
        public string BeneficiaryName { get; set; }
        [Column("BSB")]
        [StringLength(255)]
        public string Bsb { get; set; }
        [StringLength(255)]
        public string Account { get; set; }
        [StringLength(255)]
        public string Reference { get; set; }
        [StringLength(255)]
        public string CustomerCurrentAccount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        public bool Processed { get; set; }
        public int? PaymentLineId { get; set; }

        [ForeignKey(nameof(MultiPurposeInstructionDetailId))]
        [InverseProperty(nameof(DomesticClearingMultiPurposeInstructionDetail.DomesticClearingMultiPurposeInstructionAttachments))]
        public virtual DomesticClearingMultiPurposeInstructionDetail MultiPurposeInstructionDetail { get; set; }
        [ForeignKey(nameof(PaymentLineId))]
        [InverseProperty(nameof(DomesticClearingPaymentLine.DomesticClearingMultiPurposeInstructionAttachments))]
        public virtual DomesticClearingPaymentLine PaymentLine { get; set; }
    }
}
