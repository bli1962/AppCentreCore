using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Status")]
    public partial class DomesticClearingStatus
    {
        public DomesticClearingStatus()
        {
            DomesticClearingFees = new HashSet<DomesticClearingFee>();
            DomesticClearingPaymentLines = new HashSet<DomesticClearingPaymentLine>();
            DomesticClearingPayments = new HashSet<DomesticClearingPayment>();
            DomesticClearingProducts = new HashSet<DomesticClearingProduct>();
            DomesticClearingRemitters = new HashSet<DomesticClearingRemitter>();
            DomesticClearingUnitCodeAccounts = new HashSet<DomesticClearingUnitCodeAccount>();
        }

        [Key]
        public int StatusId { get; set; }
        [Required]
        [StringLength(450)]
        public string Abbreviation { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
        public int Order { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [InverseProperty(nameof(DomesticClearingFee.Status))]
        public virtual ICollection<DomesticClearingFee> DomesticClearingFees { get; set; }
        [InverseProperty(nameof(DomesticClearingPaymentLine.Status))]
        public virtual ICollection<DomesticClearingPaymentLine> DomesticClearingPaymentLines { get; set; }
        [InverseProperty(nameof(DomesticClearingPayment.Status))]
        public virtual ICollection<DomesticClearingPayment> DomesticClearingPayments { get; set; }
        [InverseProperty(nameof(DomesticClearingProduct.Status))]
        public virtual ICollection<DomesticClearingProduct> DomesticClearingProducts { get; set; }
        [InverseProperty(nameof(DomesticClearingRemitter.Status))]
        public virtual ICollection<DomesticClearingRemitter> DomesticClearingRemitters { get; set; }
        [InverseProperty(nameof(DomesticClearingUnitCodeAccount.Status))]
        public virtual ICollection<DomesticClearingUnitCodeAccount> DomesticClearingUnitCodeAccounts { get; set; }
    }
}
