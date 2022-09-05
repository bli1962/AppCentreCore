using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_SwiftAck")]
    public partial class PaymentControlSwiftAck
    {
        [Key]
        public int SwiftAckId { get; set; }
        [StringLength(50)]
        public string MessageNo { get; set; }
        [StringLength(50)]
        public string HostMessageNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SendDate { get; set; }
        public TimeSpan? AuthorisedTime { get; set; }
        [StringLength(50)]
        public string MessageType { get; set; }
        [Column("MX")]
        [StringLength(50)]
        public string Mx { get; set; }
        [StringLength(50)]
        public string Currency { get; set; }
        [Column(TypeName = "decimal(19, 4)")]
        public decimal? Amount { get; set; }
        [StringLength(50)]
        public string ReceiverBankCode1 { get; set; }
        [StringLength(50)]
        public string ReceiverBankCode2 { get; set; }
        [StringLength(50)]
        public string ReceiverSwiftAddress { get; set; }
        [StringLength(1024)]
        public string ReceiverBankName { get; set; }
        [StringLength(1024)]
        public string ReceiverBranchCity { get; set; }
        [StringLength(50)]
        public string OurRefNo { get; set; }
        [StringLength(50)]
        public string TheirRefNo { get; set; }
        [StringLength(50)]
        public string Reference { get; set; }
        [StringLength(1024)]
        public string BeneficiaryCustomerBank { get; set; }
        [StringLength(50)]
        public string SectionNo { get; set; }
        [StringLength(50)]
        public string SectionName { get; set; }
        [StringLength(50)]
        public string Group { get; set; }
        [StringLength(50)]
        public string OutgoingStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        public int? SwiftPaymentId { get; set; }
        public int? PaymentId { get; set; }
        public bool Processed { get; set; }

        [ForeignKey(nameof(PaymentId))]
        [InverseProperty(nameof(PaymentControlPayment.PaymentControlSwiftAcks))]
        public virtual PaymentControlPayment Payment { get; set; }
        [ForeignKey(nameof(SwiftPaymentId))]
        [InverseProperty(nameof(PaymentControlSwiftPayment.PaymentControlSwiftAcks))]
        public virtual PaymentControlSwiftPayment SwiftPayment { get; set; }
    }
}
