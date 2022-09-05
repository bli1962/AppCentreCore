using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Collect_Payment_BulkPaymentSummary")]
    public partial class DomesticClearingRecCollectPaymentBulkPaymentSummary
    {
        [Key]
        public int RecCollectPaymentBulkPaymentSummaryId { get; set; }
        public int RecCollectionId { get; set; }
        public int? BulkPaymentSummaryId { get; set; }
        [Column("GCMSReferenceNumber")]
        [StringLength(50)]
        public string GcmsreferenceNumber { get; set; }
        [StringLength(50)]
        public string CustomerUnitCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceivedDate { get; set; }
        [StringLength(50)]
        public string TransactionStatusType { get; set; }
        [StringLength(50)]
        public string Creator { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(50)]
        public string Approver1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate1 { get; set; }
        [StringLength(50)]
        public string Approver2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate2 { get; set; }
        [StringLength(50)]
        public string Approver3 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate3 { get; set; }
        [StringLength(50)]
        public string Approver4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate4 { get; set; }
        [StringLength(50)]
        public string Approver5 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDate5 { get; set; }
        [StringLength(50)]
        public string DebitAccountNumber { get; set; }
        [StringLength(1024)]
        public string Remarks { get; set; }
        [StringLength(50)]
        public string RejectionFlag { get; set; }
        [StringLength(50)]
        public string DecimalPointSymbol { get; set; }
        [StringLength(50)]
        public string DateFormat { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [StringLength(50)]
        public string Currency { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Amount { get; set; }
        [StringLength(50)]
        public string PaymentMethod { get; set; }
        [StringLength(50)]
        public string BulkTransactionFormatDefinitionName { get; set; }
        [StringLength(50)]
        public string ReferenceAuthority { get; set; }
        public int? TotalNumberofTrans { get; set; }
        public int? StatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BulkPaymnetSummaryCreatedWhen { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(RecCollectionId))]
        [InverseProperty(nameof(DomesticClearingRecCollection.DomesticClearingRecCollectPaymentBulkPaymentSummaries))]
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
