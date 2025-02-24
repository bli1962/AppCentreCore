using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_SwiftPayment", Schema = "dbo")]
    public partial class PaymentControlSwiftPayment
    {
        public PaymentControlSwiftPayment()
        {
            PaymentControlSwiftAcks = new HashSet<PaymentControlSwiftAck>();
            PaymentControlSwiftPaymentLogs = new HashSet<PaymentControlSwiftPaymentLog>();
        }

        [Key]
        public int SwiftPaymentId { get; set; }
        [Column(TypeName = "ntext")]
        public string Payment { get; set; }
        public bool IsRtgs { get; set; }
        [StringLength(50)]
        public string MessageType { get; set; }
        public bool Processed { get; set; }
        public int? PaymentId { get; set; }
        public int? StatusId { get; set; }
        [Column("GBaseRefNo")]
        [StringLength(20)]
        public string GbaseRefNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PaymentDate { get; set; }
        [StringLength(3)]
        public string Currency { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Amount { get; set; }
        public int? ProductReferenceId { get; set; }
        [StringLength(50)]
        public string SenderBank { get; set; }
        [StringLength(50)]
        public string ReceiverBank { get; set; }
        [StringLength(50)]
        public string BeneficiaryAccount { get; set; }
        [StringLength(50)]
        public string BeneficiaryCustomer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [StringLength(50)]
        public string StatusIdUpdatedWho { get; set; }
        public bool HasOther { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey("PaymentId")]
        [InverseProperty("PaymentControlSwiftPayments")]
        public virtual PaymentControlPayment PaymentNavigation { get; set; }
        [ForeignKey("ProductReferenceId")]
        [InverseProperty("PaymentControlSwiftPayments")]
        public virtual PaymentControlProductReference ProductReference { get; set; }
        [ForeignKey("StatusId")]
        [InverseProperty("PaymentControlSwiftPayments")]
        public virtual PaymentControlStatus Status { get; set; }
        [InverseProperty("SwiftPayment")]
        public virtual ICollection<PaymentControlSwiftAck> PaymentControlSwiftAcks { get; set; }
        [InverseProperty("SwiftPayment")]
        public virtual ICollection<PaymentControlSwiftPaymentLog> PaymentControlSwiftPaymentLogs { get; set; }
    }
}
