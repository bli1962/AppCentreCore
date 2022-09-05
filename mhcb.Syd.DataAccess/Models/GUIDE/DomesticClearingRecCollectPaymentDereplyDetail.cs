using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Collect_Payment_DEReplyDetail")]
    public partial class DomesticClearingRecCollectPaymentDereplyDetail
    {
        [Key]
        [Column("RecCollectPaymentDEReplyDetailId")]
        public int RecCollectPaymentDereplyDetailId { get; set; }
        public int RecCollectionId { get; set; }
        [StringLength(1)]
        public string RecordType { get; set; }
        [StringLength(6)]
        public string SequenceNumber { get; set; }
        [Column("BSBNumber")]
        [StringLength(7)]
        public string Bsbnumber { get; set; }
        [StringLength(9)]
        public string AccountNumberDebitCredit { get; set; }
        [StringLength(1)]
        public string Indicator { get; set; }
        [StringLength(2)]
        public string TransactionCode { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Amount { get; set; }
        [StringLength(32)]
        public string TitleOfAccountCreditedDebited { get; set; }
        [StringLength(18)]
        public string LodgementReference { get; set; }
        [StringLength(7)]
        public string TraceBsbNumber { get; set; }
        [StringLength(9)]
        public string TraceAccountNumber { get; set; }
        [StringLength(16)]
        public string RemitterName { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? WithholdingTaxAmount { get; set; }
        [StringLength(4)]
        public string StatusCode { get; set; }
        [StringLength(40)]
        public string StatusText { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(RecCollectionId))]
        [InverseProperty(nameof(DomesticClearingRecCollection.DomesticClearingRecCollectPaymentDereplyDetails))]
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
