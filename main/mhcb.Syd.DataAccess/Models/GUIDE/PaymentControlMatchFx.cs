﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_MatchFX", Schema = "dbo")]
    [Index("GbaseRefNo", Name = "NCI_PaymentControl_MatchFX_GBaseRefNo")]
    [Index("Processed", Name = "NCI_PaymentControl_MatchFX_Processed")]
    public partial class PaymentControlMatchFx
    {
        [Key]
        [Column("MatchFXId")]
        public int MatchFxid { get; set; }
        [Required]
        [Column("GBaseRefNo")]
        [StringLength(20)]
        public string GbaseRefNo { get; set; }
        public bool Processed { get; set; }
        public int? PaymentId { get; set; }
        public bool IsBank { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey("PaymentId")]
        [InverseProperty("PaymentControlMatchFxes")]
        public virtual PaymentControlPayment Payment { get; set; }
    }
}
