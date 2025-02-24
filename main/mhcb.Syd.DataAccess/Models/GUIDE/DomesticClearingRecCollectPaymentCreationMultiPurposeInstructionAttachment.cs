﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Collect_PaymentCreation_MultiPurposeInstructionAttachment", Schema = "dbo")]
    public partial class DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachment
    {
        [Key]
        public int RecCollectPaymentCreationMultiPurposeInstructionAttachment { get; set; }
        public int RecCollectionId { get; set; }
        public int? MultiPurposeInstructionAttachmentId { get; set; }
        public int? MultiPurposeInstructionDetailId { get; set; }
        [StringLength(255)]
        public string CustomerName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Amount { get; set; }
        [StringLength(255)]
        public string BeneficiaryName { get; set; }
        [Column("BSB")]
        [StringLength(255)]
        public string Bsb { get; set; }
        [StringLength(255)]
        public string Account { get; set; }
        [StringLength(255)]
        public string Reference { get; set; }
        [StringLength(255)]
        public string CustomerCurrentAccount { get; set; }
        public bool? Processed { get; set; }
        public int? PaymentLineId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedWhen { get; set; }

        [ForeignKey("RecCollectionId")]
        [InverseProperty("DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachments")]
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
