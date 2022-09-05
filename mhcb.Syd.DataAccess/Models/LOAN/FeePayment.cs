using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("FEE_PAYMENT")]
    public partial class FeePayment
    {
        public FeePayment()
        {
            FacilityMasters = new HashSet<FacilityMaster>();
        }

        [Key]
        [Column("FEE_PAYMENT_TYPE")]
        public byte FeePaymentType { get; set; }
        [Column("FEE_PAYMENT_DESC")]
        [StringLength(10)]
        public string FeePaymentDesc { get; set; }

        [InverseProperty(nameof(FacilityMaster.FeePaymentTypeNavigation))]
        public virtual ICollection<FacilityMaster> FacilityMasters { get; set; }
    }
}
