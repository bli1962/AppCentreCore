using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_SwiftPaymentLog", Schema = "dbo")]
    public partial class PaymentControlSwiftPaymentLog
    {
        [Key]
        public int SwiftPaymentLogId { get; set; }
        public int SwiftPaymentId { get; set; }
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

        [ForeignKey("SwiftPaymentId")]
        [InverseProperty("PaymentControlSwiftPaymentLogs")]
        public virtual PaymentControlSwiftPayment SwiftPayment { get; set; }
    }
}
