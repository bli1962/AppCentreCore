using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Rec_PaymentCreation")]
    public partial class DomesticClearingRecRecPaymentCreation
    {
        [Key]
        public int RecRecPaymentCreationId { get; set; }
        public int RecBatchId { get; set; }
        [Column("GEB_RecCollatePaymentCreationId")]
        public int? GebRecCollatePaymentCreationId { get; set; }
        [Column("PMT_RecCollatePaymentCreationId")]
        public int? PmtRecCollatePaymentCreationId { get; set; }
        [Column("GCMSReferenceNumber")]
        [StringLength(50)]
        public string GcmsreferenceNumber { get; set; }
        [Column("GEB_CreationDate", TypeName = "datetime")]
        public DateTime? GebCreationDate { get; set; }
        [Column("PMT_CreationDate", TypeName = "datetime")]
        public DateTime? PmtCreationDate { get; set; }
        [Column("GEB_ValueDate", TypeName = "datetime")]
        public DateTime? GebValueDate { get; set; }
        [Column("PMT_ValueDate", TypeName = "datetime")]
        public DateTime? PmtValueDate { get; set; }
        [Column("GEB_Amount", TypeName = "decimal(22, 8)")]
        public decimal? GebAmount { get; set; }
        [Column("PMT_Amount", TypeName = "decimal(22, 8)")]
        public decimal? PmtAmount { get; set; }
        [Column("GEB_NumberOfTrans")]
        public int? GebNumberOfTrans { get; set; }
        [Column("PMT_NumberOfTrans")]
        public int? PmtNumberOfTrans { get; set; }
        [Column("GEB_PaymentMethodId")]
        public int? GebPaymentMethodId { get; set; }
        [Column("PMT_PaymentMethodId")]
        public int? PmtPaymentMethodId { get; set; }
        [Column("GEB_Currency")]
        [StringLength(50)]
        public string GebCurrency { get; set; }
        [Column("PMT_Currency")]
        [StringLength(50)]
        public string PmtCurrency { get; set; }
        [Column("GEB_CustomerCurrentAccount")]
        [StringLength(255)]
        public string GebCustomerCurrentAccount { get; set; }
        [Column("PMT_CustomerCurrentAccount")]
        [StringLength(255)]
        public string PmtCustomerCurrentAccount { get; set; }
        [Column("GEB_CustomerAbbreviation")]
        [StringLength(12)]
        public string GebCustomerAbbreviation { get; set; }
        [Column("PMT_CustomerAbbreviation")]
        [StringLength(12)]
        public string PmtCustomerAbbreviation { get; set; }
        public int? RecKeyStatusId { get; set; }
        public int? RecValueStatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(RecBatchId))]
        [InverseProperty(nameof(DomesticClearingRecBatch.DomesticClearingRecRecPaymentCreations))]
        public virtual DomesticClearingRecBatch RecBatch { get; set; }
        [ForeignKey(nameof(RecKeyStatusId))]
        [InverseProperty(nameof(DomesticClearingRecKeyStatus.DomesticClearingRecRecPaymentCreations))]
        public virtual DomesticClearingRecKeyStatus RecKeyStatus { get; set; }
        [ForeignKey(nameof(RecValueStatusId))]
        [InverseProperty(nameof(DomesticClearingRecValueStatus.DomesticClearingRecRecPaymentCreations))]
        public virtual DomesticClearingRecValueStatus RecValueStatus { get; set; }
    }
}
