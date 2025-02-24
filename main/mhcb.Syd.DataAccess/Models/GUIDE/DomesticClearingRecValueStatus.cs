using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_ValueStatus", Schema = "dbo")]
    public partial class DomesticClearingRecValueStatus
    {
        public DomesticClearingRecValueStatus()
        {
            DomesticClearingRecRecGos = new HashSet<DomesticClearingRecRecGo>();
            DomesticClearingRecRecInwardClearings = new HashSet<DomesticClearingRecRecInwardClearing>();
            DomesticClearingRecRecPaymentCreations = new HashSet<DomesticClearingRecRecPaymentCreation>();
            DomesticClearingRecRecPayments = new HashSet<DomesticClearingRecRecPayment>();
        }

        [Key]
        public int RecValueStatusId { get; set; }
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

        [InverseProperty("RecValueStatus")]
        public virtual ICollection<DomesticClearingRecRecGo> DomesticClearingRecRecGos { get; set; }
        [InverseProperty("RecValueStatus")]
        public virtual ICollection<DomesticClearingRecRecInwardClearing> DomesticClearingRecRecInwardClearings { get; set; }
        [InverseProperty("RecValueStatus")]
        public virtual ICollection<DomesticClearingRecRecPaymentCreation> DomesticClearingRecRecPaymentCreations { get; set; }
        [InverseProperty("RecValueStatus")]
        public virtual ICollection<DomesticClearingRecRecPayment> DomesticClearingRecRecPayments { get; set; }
    }
}
