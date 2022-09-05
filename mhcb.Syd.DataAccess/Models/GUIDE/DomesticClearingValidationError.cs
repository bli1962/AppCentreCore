using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_ValidationError")]
    public partial class DomesticClearingValidationError
    {
        public DomesticClearingValidationError()
        {
            DomesticClearingPaymentLineValidationErrors = new HashSet<DomesticClearingPaymentLineValidationError>();
            DomesticClearingPaymentValidationErrors = new HashSet<DomesticClearingPaymentValidationError>();
        }

        [Key]
        public int ValidationErrorId { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(1024)]
        public string Description { get; set; }
        public bool IsInternal { get; set; }
        public bool IsVerfiable { get; set; }
        public bool IsPreError { get; set; }
        public bool IsReturn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [InverseProperty(nameof(DomesticClearingPaymentLineValidationError.ValidationError))]
        public virtual ICollection<DomesticClearingPaymentLineValidationError> DomesticClearingPaymentLineValidationErrors { get; set; }
        [InverseProperty(nameof(DomesticClearingPaymentValidationError.ValidationError))]
        public virtual ICollection<DomesticClearingPaymentValidationError> DomesticClearingPaymentValidationErrors { get; set; }
    }
}
