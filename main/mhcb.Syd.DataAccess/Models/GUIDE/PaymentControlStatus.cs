using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_Status", Schema = "dbo")]
    [Index("Abbreviation", Name = "UQ_PaymentControl_Status_Abbreviation", IsUnique = true)]
    public partial class PaymentControlStatus
    {
        public PaymentControlStatus()
        {
            PaymentControlPayments = new HashSet<PaymentControlPayment>();
            PaymentControlSwiftPayments = new HashSet<PaymentControlSwiftPayment>();
        }

        [Key]
        public int StatusId { get; set; }
        [Required]
        public string Abbreviation { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
        public int Order { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [InverseProperty("Status")]
        public virtual ICollection<PaymentControlPayment> PaymentControlPayments { get; set; }
        [InverseProperty("Status")]
        public virtual ICollection<PaymentControlSwiftPayment> PaymentControlSwiftPayments { get; set; }
    }
}
