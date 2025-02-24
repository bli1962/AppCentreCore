using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_PaymentValidationError", Schema = "dbo")]
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

        [ForeignKey("PaymentId")]
        [InverseProperty("DomesticClearingPaymentValidationErrors")]
        public virtual DomesticClearingPayment Payment { get; set; }
        [ForeignKey("ValidationErrorId")]
        [InverseProperty("DomesticClearingPaymentValidationErrors")]
        public virtual DomesticClearingValidationError ValidationError { get; set; }
    }
}
