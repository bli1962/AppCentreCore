using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Payment")]
    public partial class DomesticClearingPayment
    {
        public DomesticClearingPayment()
        {
            DomesticClearingBulkPaymentDetails = new HashSet<DomesticClearingBulkPaymentDetail>();
            DomesticClearingDeposits = new HashSet<DomesticClearingDeposit>();
            DomesticClearingDirectEntries = new HashSet<DomesticClearingDirectEntry>();
            DomesticClearingGdes = new HashSet<DomesticClearingGde>();
            DomesticClearingMultiPurposeInstructionDetails = new HashSet<DomesticClearingMultiPurposeInstructionDetail>();
            DomesticClearingPaymentLines = new HashSet<DomesticClearingPaymentLine>();
            DomesticClearingPaymentLogs = new HashSet<DomesticClearingPaymentLog>();
            DomesticClearingPaymentValidationErrors = new HashSet<DomesticClearingPaymentValidationError>();
            DomesticClearingPresentments = new HashSet<DomesticClearingPresentment>();
        }

        [Key]
        public int PaymentId { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
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
        public DateTime? LowPriorityWhen { get; set; }
        public int? ProductId { get; set; }
        public bool? IsDepartmentHandling { get; set; }
        [Column("DEReplyFilename")]
        [StringLength(1024)]
        public string DereplyFilename { get; set; }
        [StringLength(1024)]
        public string ChequeFrontImageName { get; set; }
        [StringLength(1024)]
        public string ChequeReverseImageName { get; set; }

        [ForeignKey(nameof(DirectionId))]
        [InverseProperty(nameof(DomesticClearingDirection.DomesticClearingPayments))]
        public virtual DomesticClearingDirection Direction { get; set; }
        [ForeignKey(nameof(FeePostId))]
        [InverseProperty(nameof(DomesticClearingGoposting.DomesticClearingPaymentFeePost))]
        public virtual DomesticClearingGoposting FeePost { get; set; }
        [ForeignKey(nameof(MainPostId))]
        [InverseProperty(nameof(DomesticClearingGoposting.DomesticClearingPaymentMainPost))]
        public virtual DomesticClearingGoposting MainPost { get; set; }
        [ForeignKey(nameof(PaymentMethodId))]
        [InverseProperty(nameof(DomesticClearingPaymentMethod.DomesticClearingPayments))]
        public virtual DomesticClearingPaymentMethod PaymentMethod { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(DomesticClearingProduct.DomesticClearingPayments))]
        public virtual DomesticClearingProduct Product { get; set; }
        [ForeignKey(nameof(StatusId))]
        [InverseProperty(nameof(DomesticClearingStatus.DomesticClearingPayments))]
        public virtual DomesticClearingStatus Status { get; set; }
        [InverseProperty(nameof(DomesticClearingBulkPaymentDetail.Payment))]
        public virtual ICollection<DomesticClearingBulkPaymentDetail> DomesticClearingBulkPaymentDetails { get; set; }
        [InverseProperty(nameof(DomesticClearingDeposit.Payment))]
        public virtual ICollection<DomesticClearingDeposit> DomesticClearingDeposits { get; set; }
        [InverseProperty(nameof(DomesticClearingDirectEntry.Payment))]
        public virtual ICollection<DomesticClearingDirectEntry> DomesticClearingDirectEntries { get; set; }
        [InverseProperty(nameof(DomesticClearingGde.Payment))]
        public virtual ICollection<DomesticClearingGde> DomesticClearingGdes { get; set; }
        [InverseProperty(nameof(DomesticClearingMultiPurposeInstructionDetail.Payment))]
        public virtual ICollection<DomesticClearingMultiPurposeInstructionDetail> DomesticClearingMultiPurposeInstructionDetails { get; set; }
        [InverseProperty(nameof(DomesticClearingPaymentLine.Payment))]
        public virtual ICollection<DomesticClearingPaymentLine> DomesticClearingPaymentLines { get; set; }
        [InverseProperty(nameof(DomesticClearingPaymentLog.Payment))]
        public virtual ICollection<DomesticClearingPaymentLog> DomesticClearingPaymentLogs { get; set; }
        [InverseProperty(nameof(DomesticClearingPaymentValidationError.Payment))]
        public virtual ICollection<DomesticClearingPaymentValidationError> DomesticClearingPaymentValidationErrors { get; set; }
        [InverseProperty(nameof(DomesticClearingPresentment.Payment))]
        public virtual ICollection<DomesticClearingPresentment> DomesticClearingPresentments { get; set; }
    }
}
