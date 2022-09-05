using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Rec_InwardClearing")]
    public partial class DomesticClearingRecRecInwardClearing
    {
        [Key]
        public int RecRecInwardClearingId { get; set; }
        public int RecBatchId { get; set; }
        [StringLength(50)]
        public string PaymentMethod { get; set; }
        [Column("PMT_RecCollateInwardClearingId")]
        public int? PmtRecCollateInwardClearingId { get; set; }
        [Column("CLR_RecCollateInwardClearingId")]
        public int? ClrRecCollateInwardClearingId { get; set; }
        [Column("PMT_Amount", TypeName = "decimal(22, 8)")]
        public decimal? PmtAmount { get; set; }
        [Column("CLR_Amount", TypeName = "decimal(22, 8)")]
        public decimal? ClrAmount { get; set; }
        [Column("PMT_Items")]
        public int? PmtItems { get; set; }
        [Column("CLR_Items")]
        public int? ClrItems { get; set; }
        public int? RecKeyStatusId { get; set; }
        public int? RecValueStatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(RecBatchId))]
        [InverseProperty(nameof(DomesticClearingRecBatch.DomesticClearingRecRecInwardClearings))]
        public virtual DomesticClearingRecBatch RecBatch { get; set; }
        [ForeignKey(nameof(RecKeyStatusId))]
        [InverseProperty(nameof(DomesticClearingRecKeyStatus.DomesticClearingRecRecInwardClearings))]
        public virtual DomesticClearingRecKeyStatus RecKeyStatus { get; set; }
        [ForeignKey(nameof(RecValueStatusId))]
        [InverseProperty(nameof(DomesticClearingRecValueStatus.DomesticClearingRecRecInwardClearings))]
        public virtual DomesticClearingRecValueStatus RecValueStatus { get; set; }
    }
}
