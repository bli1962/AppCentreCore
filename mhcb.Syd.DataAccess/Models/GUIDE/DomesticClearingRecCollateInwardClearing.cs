using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Collate_InwardClearing")]
    public partial class DomesticClearingRecCollateInwardClearing
    {
        [Key]
        public int RecCollateInwardClearingId { get; set; }
        public int RecCollectionId { get; set; }
        public int RecBatchId { get; set; }
        [StringLength(50)]
        public string PaymentMethod { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Amount { get; set; }
        public int? Items { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(RecBatchId))]
        [InverseProperty(nameof(DomesticClearingRecBatch.DomesticClearingRecCollateInwardClearings))]
        public virtual DomesticClearingRecBatch RecBatch { get; set; }
        [ForeignKey(nameof(RecCollectionId))]
        [InverseProperty(nameof(DomesticClearingRecCollection.DomesticClearingRecCollateInwardClearings))]
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
