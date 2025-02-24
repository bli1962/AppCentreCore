﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Collect_Payment_Payment", Schema = "dbo")]
    public partial class DomesticClearingRecCollectPaymentPayment
    {
        [Key]
        public int RecCollectPaymentPaymentId { get; set; }
        public int RecCollectionId { get; set; }
        public int? PaymentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? TotalAmount { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Fees { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string CurrencyCode { get; set; }
        [StringLength(255)]
        public string CustomerCurrentAccount { get; set; }
        public int? StatusId { get; set; }
        [StringLength(50)]
        public string StatusIdUpdatedWho { get; set; }
        [Column("GCMSReferenceNumber")]
        [StringLength(50)]
        public string GcmsreferenceNumber { get; set; }
        public int? DirectionId { get; set; }
        public int? MainPostId { get; set; }
        public int? FeePostId { get; set; }
        [StringLength(12)]
        public string CustomerAbbreviation { get; set; }
        public int? PaymentMethodId { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string BranchNo { get; set; }
        public bool? SentClearer { get; set; }
        public int? NumberOfTrans { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey("RecCollectionId")]
        [InverseProperty("DomesticClearingRecCollectPaymentPayments")]
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
