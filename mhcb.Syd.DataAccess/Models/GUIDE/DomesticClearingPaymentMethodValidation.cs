using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_PaymentMethodValidation")]
    public partial class DomesticClearingPaymentMethodValidation
    {
        [Key]
        public int PaymentMethodValidationId { get; set; }
        public int PaymentMethodId { get; set; }
        public int ValidationErrorId { get; set; }
        public int? ReturnRefusalCodeId { get; set; }
        public int? Priority { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedWhen { get; set; }
    }
}
