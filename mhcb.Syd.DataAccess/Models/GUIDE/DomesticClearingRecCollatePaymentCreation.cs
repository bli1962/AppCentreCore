using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Collate_PaymentCreation")]
    public partial class DomesticClearingRecCollatePaymentCreation
    {
        [Key]
        public int RecCollatePaymentCreationId { get; set; }
        public int RecCollectionId { get; set; }
        public int RecBatchId { get; set; }
        [Column("GCMSReferenceNumber")]
        [StringLength(50)]
        public string GcmsreferenceNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Amount { get; set; }
        public int? NumberOfTrans { get; set; }
        public int? PaymentMethodId { get; set; }
        [StringLength(50)]
        public string Currency { get; set; }
        [StringLength(255)]
        public string CustomerCurrentAccount { get; set; }
        [StringLength(12)]
        public string CustomerAbbreviation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(RecBatchId))]
        [InverseProperty(nameof(DomesticClearingRecBatch.DomesticClearingRecCollatePaymentCreations))]
        public virtual DomesticClearingRecBatch RecBatch { get; set; }
        [ForeignKey(nameof(RecCollectionId))]
        [InverseProperty(nameof(DomesticClearingRecCollection.DomesticClearingRecCollatePaymentCreations))]
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
