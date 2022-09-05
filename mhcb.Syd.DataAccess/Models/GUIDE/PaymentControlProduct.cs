using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_Product")]
    [Index(nameof(Code), Name = "UQ_PaymentControl_Product_Code", IsUnique = true)]
    public partial class PaymentControlProduct
    {
        public PaymentControlProduct()
        {
            PaymentControlProductReferences = new HashSet<PaymentControlProductReference>();
        }

        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Code { get; set; }
        [StringLength(1024)]
        public string Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [InverseProperty(nameof(PaymentControlProductReference.Product))]
        public virtual ICollection<PaymentControlProductReference> PaymentControlProductReferences { get; set; }
    }
}
