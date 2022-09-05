using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_Payment")]
    public partial class PaymentControlPayment
    {
        public PaymentControlPayment()
        {
            PaymentControlAccordConfirmations = new HashSet<PaymentControlAccordConfirmation>();
            PaymentControlMatchFxes = new HashSet<PaymentControlMatchFx>();
            PaymentControlMatchMoneyMarkets = new HashSet<PaymentControlMatchMoneyMarket>();
            PaymentControlMisysConfirmations = new HashSet<PaymentControlMisysConfirmation>();
            PaymentControlPaymentLogs = new HashSet<PaymentControlPaymentLog>();
            PaymentControlRemittances = new HashSet<PaymentControlRemittance>();
            PaymentControlSwiftAcks = new HashSet<PaymentControlSwiftAck>();
            PaymentControlSwiftPayments = new HashSet<PaymentControlSwiftPayment>();
        }

        [Key]
        public int PaymentId { get; set; }
        [Column("GBaseRefNo")]
        [StringLength(20)]
        public string GbaseRefNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ValueDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ReleaseDate { get; set; }
        [StringLength(2)]
        public string PaymentCurrencyCode { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? PaymentAmount { get; set; }
        public int? ProductReferenceId { get; set; }
        public int? StatusId { get; set; }
        [StringLength(12)]
        public string CustomerAbbreviation { get; set; }
        [Required]
        public bool? WaitingPayment { get; set; }
        [Required]
        public bool? WaitingSwiftPayment { get; set; }
        [Required]
        public bool? WaitingConfirmation { get; set; }
        [Required]
        public bool? WaitingAckNack { get; set; }
        public bool WasManual { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [StringLength(50)]
        public string StatusIdUpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedWhen { get; set; }
        [StringLength(2)]
        public string CountryCode { get; set; }
        public int? PreviousStatusId { get; set; }

        [ForeignKey(nameof(ProductReferenceId))]
        [InverseProperty(nameof(PaymentControlProductReference.PaymentControlPayments))]
        public virtual PaymentControlProductReference ProductReference { get; set; }
        [ForeignKey(nameof(StatusId))]
        [InverseProperty(nameof(PaymentControlStatus.PaymentControlPayments))]
        public virtual PaymentControlStatus Status { get; set; }
        [InverseProperty(nameof(PaymentControlAccordConfirmation.Payment))]
        public virtual ICollection<PaymentControlAccordConfirmation> PaymentControlAccordConfirmations { get; set; }
        [InverseProperty(nameof(PaymentControlMatchFx.Payment))]
        public virtual ICollection<PaymentControlMatchFx> PaymentControlMatchFxes { get; set; }
        [InverseProperty(nameof(PaymentControlMatchMoneyMarket.Payment))]
        public virtual ICollection<PaymentControlMatchMoneyMarket> PaymentControlMatchMoneyMarkets { get; set; }
        [InverseProperty(nameof(PaymentControlMisysConfirmation.Payment))]
        public virtual ICollection<PaymentControlMisysConfirmation> PaymentControlMisysConfirmations { get; set; }
        [InverseProperty(nameof(PaymentControlPaymentLog.Payment))]
        public virtual ICollection<PaymentControlPaymentLog> PaymentControlPaymentLogs { get; set; }
        [InverseProperty(nameof(PaymentControlRemittance.Payment))]
        public virtual ICollection<PaymentControlRemittance> PaymentControlRemittances { get; set; }
        [InverseProperty(nameof(PaymentControlSwiftAck.Payment))]
        public virtual ICollection<PaymentControlSwiftAck> PaymentControlSwiftAcks { get; set; }
        [InverseProperty(nameof(PaymentControlSwiftPayment.PaymentNavigation))]
        public virtual ICollection<PaymentControlSwiftPayment> PaymentControlSwiftPayments { get; set; }
    }
}
