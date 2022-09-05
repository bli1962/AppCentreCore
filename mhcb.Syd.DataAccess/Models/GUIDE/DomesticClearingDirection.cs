using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Direction")]
    public partial class DomesticClearingDirection
    {
        public DomesticClearingDirection()
        {
            DomesticClearingGopostings = new HashSet<DomesticClearingGoposting>();
            DomesticClearingPaymentMethods = new HashSet<DomesticClearingPaymentMethod>();
            DomesticClearingPayments = new HashSet<DomesticClearingPayment>();
        }

        [Key]
        public int DirectionId { get; set; }
        [Required]
        [StringLength(450)]
        public string Abbreviation { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [InverseProperty(nameof(DomesticClearingGoposting.Direction))]
        public virtual ICollection<DomesticClearingGoposting> DomesticClearingGopostings { get; set; }
        [InverseProperty(nameof(DomesticClearingPaymentMethod.Direction))]
        public virtual ICollection<DomesticClearingPaymentMethod> DomesticClearingPaymentMethods { get; set; }
        [InverseProperty(nameof(DomesticClearingPayment.Direction))]
        public virtual ICollection<DomesticClearingPayment> DomesticClearingPayments { get; set; }
    }
}
