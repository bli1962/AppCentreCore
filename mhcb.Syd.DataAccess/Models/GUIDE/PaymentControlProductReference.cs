using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_ProductReference")]
    [Index(nameof(Code), Name = "UQ_PaymentControl_ProductReference_Code", IsUnique = true)]
    public partial class PaymentControlProductReference
    {
        public PaymentControlProductReference()
        {
            PaymentControlPayments = new HashSet<PaymentControlPayment>();
            PaymentControlSwiftPayments = new HashSet<PaymentControlSwiftPayment>();
        }

        [Key]
        public int ProductReferenceId { get; set; }
        public int ProductId { get; set; }
        [Required]
        [StringLength(3)]
        public string Code { get; set; }
        [StringLength(1024)]
        public string Name { get; set; }
        public bool HasConfirmations { get; set; }
        public bool HasSwiftPayments { get; set; }
        public bool IsTaking { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(PaymentControlProduct.PaymentControlProductReferences))]
        public virtual PaymentControlProduct Product { get; set; }
        [InverseProperty(nameof(PaymentControlPayment.ProductReference))]
        public virtual ICollection<PaymentControlPayment> PaymentControlPayments { get; set; }
        [InverseProperty(nameof(PaymentControlSwiftPayment.ProductReference))]
        public virtual ICollection<PaymentControlSwiftPayment> PaymentControlSwiftPayments { get; set; }
    }
}
