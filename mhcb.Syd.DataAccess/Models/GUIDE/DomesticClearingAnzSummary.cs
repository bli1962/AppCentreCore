using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_AnzSummary")]
    public partial class DomesticClearingAnzSummary
    {
        [Key]
        public int AnzSummaryId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProcessDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [StringLength(25)]
        public string Description { get; set; }
        public int? DebitQuantity { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? DebitValue { get; set; }
        public int? CreditQuantity { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? CreditValue { get; set; }
        [Column(TypeName = "decimal(22, 8)")]
        public decimal? TotalValueOfTransactions { get; set; }
        [StringLength(10)]
        public string Direction { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        [StringLength(1024)]
        public string Filename { get; set; }
    }
}
