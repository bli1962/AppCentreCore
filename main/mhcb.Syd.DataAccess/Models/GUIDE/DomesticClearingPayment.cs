using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Payment", Schema = "dbo")]
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
        [Unicode(false)]
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
        [Unicode(false)]
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

        [ForeignKey("DirectionId")]
        [InverseProperty("DomesticClearingPayments")]
        public virtual DomesticClearingDirection Direction { get; set; }
        [ForeignKey("FeePostId")]
        [InverseProperty("DomesticClearingPaymentFeePost")]
        public virtual DomesticClearingGoposting FeePost { get; set; }
        [ForeignKey("MainPostId")]
        [InverseProperty("DomesticClearingPaymentMainPost")]
        public virtual DomesticClearingGoposting MainPost { get; set; }
        [ForeignKey("PaymentMethodId")]
        [InverseProperty("DomesticClearingPayments")]
        public virtual DomesticClearingPaymentMethod PaymentMethod { get; set; }
        [ForeignKey("ProductId")]
        [InverseProperty("DomesticClearingPayments")]
        public virtual DomesticClearingProduct Product { get; set; }
        [ForeignKey("StatusId")]
        [InverseProperty("DomesticClearingPayments")]
        public virtual DomesticClearingStatus Status { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<DomesticClearingBulkPaymentDetail> DomesticClearingBulkPaymentDetails { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<DomesticClearingDeposit> DomesticClearingDeposits { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<DomesticClearingDirectEntry> DomesticClearingDirectEntries { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<DomesticClearingGde> DomesticClearingGdes { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<DomesticClearingMultiPurposeInstructionDetail> DomesticClearingMultiPurposeInstructionDetails { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<DomesticClearingPaymentLine> DomesticClearingPaymentLines { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<DomesticClearingPaymentLog> DomesticClearingPaymentLogs { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<DomesticClearingPaymentValidationError> DomesticClearingPaymentValidationErrors { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<DomesticClearingPresentment> DomesticClearingPresentments { get; set; }
    }
}
