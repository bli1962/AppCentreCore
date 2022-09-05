using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Collate_GO")]
    public partial class DomesticClearingRecCollateGo
    {
        [Key]
        [Column("RecCollateGOId")]
        public int RecCollateGoid { get; set; }
        public int RecCollectionId { get; set; }
        public int RecBatchId { get; set; }
        [StringLength(50)]
        public string TransNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OperationDate { get; set; }
        [StringLength(30)]
        public string Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? DebitAmount { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? CreditAmount { get; set; }
        [StringLength(4)]
        public string DebitCurrency { get; set; }
        [StringLength(4)]
        public string CreditCurrency { get; set; }
        [StringLength(20)]
        public string DebitAccountCode { get; set; }
        [StringLength(20)]
        public string DebitAccountNumber { get; set; }
        [StringLength(20)]
        public string CreditAccountCode { get; set; }
        [StringLength(20)]
        public string CreditAccountNumber { get; set; }
        [StringLength(12)]
        public string DebitCustomerAbbreviation { get; set; }
        [StringLength(12)]
        public string CreditCustomerAbbreviation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(RecBatchId))]
        [InverseProperty(nameof(DomesticClearingRecBatch.DomesticClearingRecCollateGos))]
        public virtual DomesticClearingRecBatch RecBatch { get; set; }
        [ForeignKey(nameof(RecCollectionId))]
        [InverseProperty(nameof(DomesticClearingRecCollection.DomesticClearingRecCollateGos))]
        public virtual DomesticClearingRecCollection RecCollection { get; set; }
    }
}
