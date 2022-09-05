using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_PaymentValidationError")]
    public partial class DomesticClearingPaymentValidationError
    {
        [Key]
        public int PaymentValidationErrorId { get; set; }
        public int? PaymentId { get; set; }
        public int? ValidationErrorId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(PaymentId))]
        [InverseProperty(nameof(DomesticClearingPayment.DomesticClearingPaymentValidationErrors))]
        public virtual DomesticClearingPayment Payment { get; set; }
        [ForeignKey(nameof(ValidationErrorId))]
        [InverseProperty(nameof(DomesticClearingValidationError.DomesticClearingPaymentValidationErrors))]
        public virtual DomesticClearingValidationError ValidationError { get; set; }
    }
}
