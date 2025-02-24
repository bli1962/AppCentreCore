﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_DirectEntry", Schema = "dbo")]
    public partial class DomesticClearingDirectEntry
    {
        [Key]
        public int DirectEntryId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateToBeProcessed { get; set; }
        [Column("BSBNumber")]
        [StringLength(7)]
        public string Bsbnumber { get; set; }
        [StringLength(9)]
        public string AccountNumberToBeCreditedDebited { get; set; }
        [StringLength(1)]
        public string Indicator { get; set; }
        [StringLength(2)]
        public string TrasactionCode { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? Amount { get; set; }
        [StringLength(32)]
        public string TitleOfAccountCreditedDebited { get; set; }
        [StringLength(18)]
        public string LodgementReference { get; set; }
        [Column("TraceRecordBSB")]
        [StringLength(7)]
        public string TraceRecordBsb { get; set; }
        [StringLength(9)]
        public string TraceRecordAccountNumber { get; set; }
        [StringLength(16)]
        public string RemitterName { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? WithHoldingTaxAmount { get; set; }
        public bool Processed { get; set; }
        public int? PaymentId { get; set; }
        public int? PaymentLineId { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        [StringLength(1024)]
        public string Filename { get; set; }
        [StringLength(6)]
        public string NumberOfUserSupplyingFile { get; set; }

        [ForeignKey("PaymentId")]
        [InverseProperty("DomesticClearingDirectEntries")]
        public virtual DomesticClearingPayment Payment { get; set; }
        [ForeignKey("PaymentLineId")]
        [InverseProperty("DomesticClearingDirectEntries")]
        public virtual DomesticClearingPaymentLine PaymentLine { get; set; }
    }
}
