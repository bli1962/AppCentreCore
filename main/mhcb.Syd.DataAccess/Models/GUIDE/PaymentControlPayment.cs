using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_Payment", Schema = "dbo")]
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
        [Unicode(false)]
        public string PaymentCurrencyCode { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? PaymentAmount { get; set; }
        public int? ProductReferenceId { get; set; }
        public int? StatusId { get; set; }
        [StringLength(12)]
        [Unicode(false)]
        public string CustomerAbbreviation { get; set; }
        public bool? WaitingPayment { get; set; }
        public bool? WaitingSwiftPayment { get; set; }
        public bool? WaitingConfirmation { get; set; }
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
        [Unicode(false)]
        public string CountryCode { get; set; }
        public int? PreviousStatusId { get; set; }

        [ForeignKey("ProductReferenceId")]
        [InverseProperty("PaymentControlPayments")]
        public virtual PaymentControlProductReference ProductReference { get; set; }
        [ForeignKey("StatusId")]
        [InverseProperty("PaymentControlPayments")]
        public virtual PaymentControlStatus Status { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<PaymentControlAccordConfirmation> PaymentControlAccordConfirmations { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<PaymentControlMatchFx> PaymentControlMatchFxes { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<PaymentControlMatchMoneyMarket> PaymentControlMatchMoneyMarkets { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<PaymentControlMisysConfirmation> PaymentControlMisysConfirmations { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<PaymentControlPaymentLog> PaymentControlPaymentLogs { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<PaymentControlRemittance> PaymentControlRemittances { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<PaymentControlSwiftAck> PaymentControlSwiftAcks { get; set; }
        [InverseProperty("PaymentNavigation")]
        public virtual ICollection<PaymentControlSwiftPayment> PaymentControlSwiftPayments { get; set; }
    }
}
