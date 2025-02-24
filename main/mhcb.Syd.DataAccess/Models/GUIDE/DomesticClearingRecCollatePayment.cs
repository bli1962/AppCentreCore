﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Collate_Payment", Schema = "dbo")]
    public partial class DomesticClearingRecCollatePayment
    {
        [Key]
        public int RecCollatePaymentId { get; set; }
        public int RecCollectionId { get; set; }
        public int RecBatchId { get; set; }
        [Column("GCMSReferenceNumber")]
        [StringLength(50)]
        public string GcmsreferenceNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Amount { get; set; }
        public int? NumberOfTrans { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey("RecBatchId")]
        [InverseProperty("DomesticClearingRecCollatePayments")]
        public virtual DomesticClearingRecBatch RecBatch { get; set; }
        [ForeignKey("RecCollectionId")]
        [InverseProperty("DomesticClearingRecCollatePayments")]
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
