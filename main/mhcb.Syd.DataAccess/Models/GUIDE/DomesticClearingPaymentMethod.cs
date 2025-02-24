﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_PaymentMethod", Schema = "dbo")]
    public partial class DomesticClearingPaymentMethod
    {
        public DomesticClearingPaymentMethod()
        {
            DomesticClearingFees = new HashSet<DomesticClearingFee>();
            DomesticClearingPayments = new HashSet<DomesticClearingPayment>();
        }

        [Key]
        public int PaymentMethodId { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        public int DirectionId { get; set; }
        public bool IsMultipurpose { get; set; }
        [Column("GBaseRefPrefix")]
        [StringLength(50)]
        public string GbaseRefPrefix { get; set; }
        [Column("GASFileType")]
        [StringLength(50)]
        public string GasfileType { get; set; }
        [StringLength(30)]
        public string Remarks { get; set; }
        public int SourceId { get; set; }
        public int Priority { get; set; }

        [ForeignKey("DirectionId")]
        [InverseProperty("DomesticClearingPaymentMethods")]
        public virtual DomesticClearingDirection Direction { get; set; }
        [ForeignKey("SourceId")]
        [InverseProperty("DomesticClearingPaymentMethods")]
        public virtual DomesticClearingSource Source { get; set; }
        [InverseProperty("PaymentMethod")]
        public virtual ICollection<DomesticClearingFee> DomesticClearingFees { get; set; }
        [InverseProperty("PaymentMethod")]
        public virtual ICollection<DomesticClearingPayment> DomesticClearingPayments { get; set; }
    }
}
