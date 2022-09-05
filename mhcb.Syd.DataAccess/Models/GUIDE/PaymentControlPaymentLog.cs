using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_PaymentLog")]
    public partial class PaymentControlPaymentLog
    {
        [Key]
        public int PaymentLogId { get; set; }
        public int PaymentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime When { get; set; }
        [StringLength(1024)]
        public string Who { get; set; }
        [StringLength(1024)]
        public string Type { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }

        [ForeignKey(nameof(PaymentId))]
        [InverseProperty(nameof(PaymentControlPayment.PaymentControlPaymentLogs))]
        public virtual PaymentControlPayment Payment { get; set; }
    }
}
