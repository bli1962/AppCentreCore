using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_MatchMoneyMarket")]
    [Index(nameof(Processed), Name = "NCI_PaymentControl_MatchMoneyMarket_Processed")]
    public partial class PaymentControlMatchMoneyMarket
    {
        [Key]
        public int MatchMoneyMarketId { get; set; }
        [Required]
        [Column("GBaseRefNo")]
        [StringLength(50)]
        public string GbaseRefNo { get; set; }
        [Column("MMTicketId")]
        public int MmticketId { get; set; }
        public bool Processed { get; set; }
        public int? PaymentId { get; set; }
        public bool IsBank { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(PaymentId))]
        [InverseProperty(nameof(PaymentControlPayment.PaymentControlMatchMoneyMarkets))]
        public virtual PaymentControlPayment Payment { get; set; }
    }
}
