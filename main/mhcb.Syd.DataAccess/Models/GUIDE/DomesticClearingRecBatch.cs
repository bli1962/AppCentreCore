using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Batch", Schema = "dbo")]
    public partial class DomesticClearingRecBatch
    {
        public DomesticClearingRecBatch()
        {
            DomesticClearingRecCollateGos = new HashSet<DomesticClearingRecCollateGo>();
            DomesticClearingRecCollateInwardClearings = new HashSet<DomesticClearingRecCollateInwardClearing>();
            DomesticClearingRecCollatePaymentCreations = new HashSet<DomesticClearingRecCollatePaymentCreation>();
            DomesticClearingRecCollatePayments = new HashSet<DomesticClearingRecCollatePayment>();
            DomesticClearingRecRecGos = new HashSet<DomesticClearingRecRecGo>();
            DomesticClearingRecRecInwardClearings = new HashSet<DomesticClearingRecRecInwardClearing>();
            DomesticClearingRecRecPaymentCreations = new HashSet<DomesticClearingRecRecPaymentCreation>();
            DomesticClearingRecRecPayments = new HashSet<DomesticClearingRecRecPayment>();
        }

        [Key]
        public int RecBatchId { get; set; }
        public int RecTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDateFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDateTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDateFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDateTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OperationDateFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OperationDateTo { get; set; }
        public bool Processed { get; set; }
        public bool Completed { get; set; }
        public bool? SentClearer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProcessingDateFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProcessingDateTo { get; set; }

        [ForeignKey("RecTypeId")]
        [InverseProperty("DomesticClearingRecBatches")]
        public virtual DomesticClearingRecType RecType { get; set; }
        [InverseProperty("RecBatch")]
        public virtual ICollection<DomesticClearingRecCollateGo> DomesticClearingRecCollateGos { get; set; }
        [InverseProperty("RecBatch")]
        public virtual ICollection<DomesticClearingRecCollateInwardClearing> DomesticClearingRecCollateInwardClearings { get; set; }
        [InverseProperty("RecBatch")]
        public virtual ICollection<DomesticClearingRecCollatePaymentCreation> DomesticClearingRecCollatePaymentCreations { get; set; }
        [InverseProperty("RecBatch")]
        public virtual ICollection<DomesticClearingRecCollatePayment> DomesticClearingRecCollatePayments { get; set; }
        [InverseProperty("RecBatch")]
        public virtual ICollection<DomesticClearingRecRecGo> DomesticClearingRecRecGos { get; set; }
        [InverseProperty("RecBatch")]
        public virtual ICollection<DomesticClearingRecRecInwardClearing> DomesticClearingRecRecInwardClearings { get; set; }
        [InverseProperty("RecBatch")]
        public virtual ICollection<DomesticClearingRecRecPaymentCreation> DomesticClearingRecRecPaymentCreations { get; set; }
        [InverseProperty("RecBatch")]
        public virtual ICollection<DomesticClearingRecRecPayment> DomesticClearingRecRecPayments { get; set; }
    }
}
