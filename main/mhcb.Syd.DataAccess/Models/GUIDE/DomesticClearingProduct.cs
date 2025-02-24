using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Product", Schema = "dbo")]
    [Index("Type", Name = "UQ_DomesticClearing_Product_Description", IsUnique = true)]
    [Index("Type", Name = "UQ_DomesticClearing_Product_Type", IsUnique = true)]
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

        [ForeignKey("StatusId")]
        [InverseProperty("DomesticClearingProducts")]
        public virtual DomesticClearingStatus Status { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<DomesticClearingPayment> DomesticClearingPayments { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<DomesticClearingProductLog> DomesticClearingProductLogs { get; set; }
    }
}
