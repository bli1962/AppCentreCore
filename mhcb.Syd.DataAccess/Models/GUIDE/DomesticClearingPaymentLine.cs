using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_PaymentLine")]
    public partial class DomesticClearingPaymentLine
    {
        public DomesticClearingPaymentLine()
        {
            DomesticClearingBulkPaymentDetails = new HashSet<DomesticClearingBulkPaymentDetail>();
            DomesticClearingDirectEntries = new HashSet<DomesticClearingDirectEntry>();
            DomesticClearingGdes = new HashSet<DomesticClearingGde>();
            DomesticClearingGopostings = new HashSet<DomesticClearingGoposting>();
            DomesticClearingMultiPurposeInstructionAttachments = new HashSet<DomesticClearingMultiPurposeInstructionAttachment>();
            DomesticClearingPaymentLineValidationErrors = new HashSet<DomesticClearingPaymentLineValidationError>();
        }

        [Key]
        public int PaymentLineId { get; set; }
        public int PaymentId { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        public int? StatusId { get; set; }
        [StringLength(50)]
        public string StatusIdUpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReturnDate { get; set; }
        public int? ReturnRefusalCodeId { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? ReturnFee { get; set; }
        public int? ReturnPostId { get; set; }
        public int? ReturnFeePostId { get; set; }

        [ForeignKey(nameof(PaymentId))]
        [InverseProperty(nameof(DomesticClearingPayment.DomesticClearingPaymentLines))]
        public virtual DomesticClearingPayment Payment { get; set; }
        [ForeignKey(nameof(ReturnFeePostId))]
        [InverseProperty(nameof(DomesticClearingGoposting.DomesticClearingPaymentLineReturnFeePosts))]
        public virtual DomesticClearingGoposting ReturnFeePost { get; set; }
        [ForeignKey(nameof(ReturnPostId))]
        [InverseProperty(nameof(DomesticClearingGoposting.DomesticClearingPaymentLineReturnPosts))]
        public virtual DomesticClearingGoposting ReturnPost { get; set; }
        [ForeignKey(nameof(ReturnRefusalCodeId))]
        [InverseProperty(nameof(DomesticClearingReturnRefusalCode.DomesticClearingPaymentLines))]
        public virtual DomesticClearingReturnRefusalCode ReturnRefusalCode { get; set; }
        [ForeignKey(nameof(StatusId))]
        [InverseProperty(nameof(DomesticClearingStatus.DomesticClearingPaymentLines))]
        public virtual DomesticClearingStatus Status { get; set; }
        [InverseProperty(nameof(DomesticClearingBulkPaymentDetail.PaymentLine))]
        public virtual ICollection<DomesticClearingBulkPaymentDetail> DomesticClearingBulkPaymentDetails { get; set; }
        [InverseProperty(nameof(DomesticClearingDirectEntry.PaymentLine))]
        public virtual ICollection<DomesticClearingDirectEntry> DomesticClearingDirectEntries { get; set; }
        [InverseProperty(nameof(DomesticClearingGde.PaymentLine))]
        public virtual ICollection<DomesticClearingGde> DomesticClearingGdes { get; set; }
        [InverseProperty(nameof(DomesticClearingGoposting.PaymentLine))]
        public virtual ICollection<DomesticClearingGoposting> DomesticClearingGopostings { get; set; }
        [InverseProperty(nameof(DomesticClearingMultiPurposeInstructionAttachment.PaymentLine))]
        public virtual ICollection<DomesticClearingMultiPurposeInstructionAttachment> DomesticClearingMultiPurposeInstructionAttachments { get; set; }
        [InverseProperty(nameof(DomesticClearingPaymentLineValidationError.PaymentLine))]
        public virtual ICollection<DomesticClearingPaymentLineValidationError> DomesticClearingPaymentLineValidationErrors { get; set; }
    }
}
