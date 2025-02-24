using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_PaymentLineValidationError", Schema = "dbo")]
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

        [ForeignKey("PaymentLineId")]
        [InverseProperty("DomesticClearingPaymentLineValidationErrors")]
        public virtual DomesticClearingPaymentLine PaymentLine { get; set; }
        [ForeignKey("ValidationErrorId")]
        [InverseProperty("DomesticClearingPaymentLineValidationErrors")]
        public virtual DomesticClearingValidationError ValidationError { get; set; }
    }
}
