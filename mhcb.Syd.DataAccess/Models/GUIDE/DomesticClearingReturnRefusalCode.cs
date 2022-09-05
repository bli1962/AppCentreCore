using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_ReturnRefusalCode")]
    public partial class DomesticClearingReturnRefusalCode
    {
        public DomesticClearingReturnRefusalCode()
        {
            DomesticClearingPaymentLines = new HashSet<DomesticClearingPaymentLine>();
        }

        [Key]
        public int ReturnRefusalCodeId { get; set; }
        public int? ReturnCode { get; set; }
        public int? RefusalCode { get; set; }
        public int? FailureCode { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        public bool IsPresentment { get; set; }

        [InverseProperty(nameof(DomesticClearingPaymentLine.ReturnRefusalCode))]
        public virtual ICollection<DomesticClearingPaymentLine> DomesticClearingPaymentLines { get; set; }
    }
}
