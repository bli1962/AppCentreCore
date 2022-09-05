using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_PaymentLineValidationError")]
    public partial class DomesticClearingPaymentLineValidationError
    {
        [Key]
        public int PaymentLineValidationErrorId { get; set; }
        public int? PaymentLineId { get; set; }
        public int? ValidationErrorId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(PaymentLineId))]
        [InverseProperty(nameof(DomesticClearingPaymentLine.DomesticClearingPaymentLineValidationErrors))]
        public virtual DomesticClearingPaymentLine PaymentLine { get; set; }
        [ForeignKey(nameof(ValidationErrorId))]
        [InverseProperty(nameof(DomesticClearingValidationError.DomesticClearingPaymentLineValidationErrors))]
        public virtual DomesticClearingValidationError ValidationError { get; set; }
    }
}
