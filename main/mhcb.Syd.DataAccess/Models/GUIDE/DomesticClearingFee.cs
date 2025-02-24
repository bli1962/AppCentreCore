using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Fee", Schema = "dbo")]
    [Index("FeeId", Name = "PK_DomesticClearing_Fee_FeeId")]
    [Index("Account", "EffectiveDate", "PaymentMethodId", Name = "UQ_DomesticClearing_Fee_AccountEffectiveDatePaymentMethod", IsUnique = true)]
    public partial class DomesticClearingFee
    {
        public DomesticClearingFee()
        {
            DomesticClearingFeeLogs = new HashSet<DomesticClearingFeeLog>();
        }

        [Key]
        public int FeeId { get; set; }
        [StringLength(12)]
        public string CustomerAbbreviation { get; set; }
        [StringLength(255)]
        public string Account { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime EffectiveDate { get; set; }
        public int? StatusId { get; set; }
        [StringLength(50)]
        public string StatusIdUpdatedWho { get; set; }
        public int PaymentMethodId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        public bool Closed { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? ReturnAmount { get; set; }
        public int? PreviousStatusId { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? DishonourAmount { get; set; }

        [ForeignKey("PaymentMethodId")]
        [InverseProperty("DomesticClearingFees")]
        public virtual DomesticClearingPaymentMethod PaymentMethod { get; set; }
        [ForeignKey("StatusId")]
        [InverseProperty("DomesticClearingFees")]
        public virtual DomesticClearingStatus Status { get; set; }
        [InverseProperty("Fee")]
        public virtual ICollection<DomesticClearingFeeLog> DomesticClearingFeeLogs { get; set; }
    }
}
