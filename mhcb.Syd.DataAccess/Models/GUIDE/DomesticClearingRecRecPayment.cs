using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Rec_Payment")]
    public partial class DomesticClearingRecRecPayment
    {
        [Key]
        public int RecRecPaymentId { get; set; }
        public int RecBatchId { get; set; }
        [Column("GEB_RecCollatePaymentId")]
        public int? GebRecCollatePaymentId { get; set; }
        [Column("PMT_RecCollatePaymentId")]
        public int? PmtRecCollatePaymentId { get; set; }
        [Column("CLR_RecCollatePaymentId")]
        public int? ClrRecCollatePaymentId { get; set; }
        [Column("GCMSReferenceNumber")]
        [StringLength(50)]
        public string GcmsreferenceNumber { get; set; }
        [Column("GEB_ValueDate", TypeName = "datetime")]
        public DateTime? GebValueDate { get; set; }
        [Column("PMT_ValueDate", TypeName = "datetime")]
        public DateTime? PmtValueDate { get; set; }
        [Column("CLR_ValueDate", TypeName = "datetime")]
        public DateTime? ClrValueDate { get; set; }
        [Column("GEB_Amount", TypeName = "decimal(22, 8)")]
        public decimal? GebAmount { get; set; }
        [Column("PMT_Amount", TypeName = "decimal(22, 8)")]
        public decimal? PmtAmount { get; set; }
        [Column("CLR_Amount", TypeName = "decimal(22, 8)")]
        public decimal? ClrAmount { get; set; }
        [Column("GEB_NumberOfTrans")]
        public int? GebNumberOfTrans { get; set; }
        [Column("PMT_NumberOfTrans")]
        public int? PmtNumberOfTrans { get; set; }
        [Column("CLR_NumberOfTrans")]
        public int? ClrNumberOfTrans { get; set; }
        public int? RecKeyStatusId { get; set; }
        public int? RecValueStatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(RecBatchId))]
        [InverseProperty(nameof(DomesticClearingRecBatch.DomesticClearingRecRecPayments))]
        public virtual DomesticClearingRecBatch RecBatch { get; set; }
        [ForeignKey(nameof(RecKeyStatusId))]
        [InverseProperty(nameof(DomesticClearingRecKeyStatus.DomesticClearingRecRecPayments))]
        public virtual DomesticClearingRecKeyStatus RecKeyStatus { get; set; }
        [ForeignKey(nameof(RecValueStatusId))]
        [InverseProperty(nameof(DomesticClearingRecValueStatus.DomesticClearingRecRecPayments))]
        public virtual DomesticClearingRecValueStatus RecValueStatus { get; set; }
    }
}
