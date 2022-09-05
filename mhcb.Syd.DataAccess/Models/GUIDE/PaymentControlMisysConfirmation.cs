using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_MisysConfirmation")]
    public partial class PaymentControlMisysConfirmation
    {
        [Key]
        public int MisysConfirmationId { get; set; }
        public bool Processed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(255)]
        public string UpdatedWho { get; set; }
        public int? PaymentId { get; set; }
        [StringLength(50)]
        public string Counterparty { get; set; }
        [StringLength(50)]
        public string FinStatus { get; set; }
        [StringLength(50)]
        public string InstStatus { get; set; }
        [StringLength(50)]
        public string DmStatus { get; set; }
        [StringLength(20)]
        public string ReferenceNum { get; set; }
        [StringLength(255)]
        public string Fund { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TradeDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Rate { get; set; }
        [StringLength(50)]
        public string BuyCcy { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? BuyAmount { get; set; }
        [StringLength(255)]
        public string BuyReceivingAgent { get; set; }
        [StringLength(50)]
        public string SellCcy { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? SellAmount { get; set; }
        [StringLength(255)]
        public string SellReceivingAgent { get; set; }
        [StringLength(50)]
        public string DealType { get; set; }
        [StringLength(50)]
        public string RelatedRefNo { get; set; }
        [StringLength(50)]
        public string TypeOfOprn { get; set; }
        [StringLength(50)]
        public string PartyAsRole { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MaturityDate { get; set; }
        [StringLength(50)]
        public string PrincipleCurr { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? PrincipleAmt { get; set; }
        [StringLength(50)]
        public string IntCurr { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? IntAmt { get; set; }
        [StringLength(255)]
        public string InterestRate { get; set; }

        [ForeignKey(nameof(PaymentId))]
        [InverseProperty(nameof(PaymentControlPayment.PaymentControlMisysConfirmations))]
        public virtual PaymentControlPayment Payment { get; set; }
    }
}
