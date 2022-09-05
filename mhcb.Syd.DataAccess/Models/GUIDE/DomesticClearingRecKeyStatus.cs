using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_KeyStatus")]
    public partial class DomesticClearingRecKeyStatus
    {
        public DomesticClearingRecKeyStatus()
        {
            DomesticClearingRecRecGos = new HashSet<DomesticClearingRecRecGo>();
            DomesticClearingRecRecInwardClearings = new HashSet<DomesticClearingRecRecInwardClearing>();
            DomesticClearingRecRecPaymentCreations = new HashSet<DomesticClearingRecRecPaymentCreation>();
            DomesticClearingRecRecPayments = new HashSet<DomesticClearingRecRecPayment>();
        }

        [Key]
        public int RecKeyStatusId { get; set; }
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

        [InverseProperty(nameof(DomesticClearingRecRecGo.RecKeyStatus))]
        public virtual ICollection<DomesticClearingRecRecGo> DomesticClearingRecRecGos { get; set; }
        [InverseProperty(nameof(DomesticClearingRecRecInwardClearing.RecKeyStatus))]
        public virtual ICollection<DomesticClearingRecRecInwardClearing> DomesticClearingRecRecInwardClearings { get; set; }
        [InverseProperty(nameof(DomesticClearingRecRecPaymentCreation.RecKeyStatus))]
        public virtual ICollection<DomesticClearingRecRecPaymentCreation> DomesticClearingRecRecPaymentCreations { get; set; }
        [InverseProperty(nameof(DomesticClearingRecRecPayment.RecKeyStatus))]
        public virtual ICollection<DomesticClearingRecRecPayment> DomesticClearingRecRecPayments { get; set; }
    }
}
