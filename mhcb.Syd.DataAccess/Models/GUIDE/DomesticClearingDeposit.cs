using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Deposit")]
    public partial class DomesticClearingDeposit
    {
        [Key]
        public int DepositId { get; set; }
        public bool Processed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        public int? PaymentId { get; set; }
        [StringLength(1024)]
        public string Filename { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransmissionDate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? DepositValue { get; set; }
        [StringLength(50)]
        public string AccountNumber { get; set; }
        [Column("DomicileBSB")]
        [StringLength(50)]
        public string DomicileBsb { get; set; }
        [Column("OriginalBSB")]
        [StringLength(50)]
        public string OriginalBsb { get; set; }
        public int? ChequesCount { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? ChequesValue { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? CashValue { get; set; }

        [ForeignKey(nameof(PaymentId))]
        [InverseProperty(nameof(DomesticClearingPayment.DomesticClearingDeposits))]
        public virtual DomesticClearingPayment Payment { get; set; }
    }
}
