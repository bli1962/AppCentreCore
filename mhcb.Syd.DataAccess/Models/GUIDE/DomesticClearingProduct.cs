using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Product")]
    [Index(nameof(Type), Name = "UQ_DomesticClearing_Product_Description", IsUnique = true)]
    [Index(nameof(Type), Name = "UQ_DomesticClearing_Product_Type", IsUnique = true)]
    public partial class DomesticClearingProduct
    {
        public DomesticClearingProduct()
        {
            DomesticClearingPayments = new HashSet<DomesticClearingPayment>();
            DomesticClearingProductLogs = new HashSet<DomesticClearingProductLog>();
        }

        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        public int? StatusId { get; set; }
        [StringLength(50)]
        public string StatusIdUpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        public int? PreviousStatusId { get; set; }

        [ForeignKey(nameof(StatusId))]
        [InverseProperty(nameof(DomesticClearingStatus.DomesticClearingProducts))]
        public virtual DomesticClearingStatus Status { get; set; }
        [InverseProperty(nameof(DomesticClearingPayment.Product))]
        public virtual ICollection<DomesticClearingPayment> DomesticClearingPayments { get; set; }
        [InverseProperty(nameof(DomesticClearingProductLog.Product))]
        public virtual ICollection<DomesticClearingProductLog> DomesticClearingProductLogs { get; set; }
    }
}
