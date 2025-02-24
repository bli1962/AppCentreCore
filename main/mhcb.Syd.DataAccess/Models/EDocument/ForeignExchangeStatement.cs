using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EDocument
{
    [Table("ForeignExchangeStatement")]
    public partial class ForeignExchangeStatement
    {
        [Key]
        public int Id { get; set; }
        public int StatementId { get; set; }
        [StringLength(200)]
        public string ReferenceNo { get; set; }
        [StringLength(200)]
        public string Currency { get; set; }
        [StringLength(200)]
        public string OurPrice { get; set; }
        [StringLength(200)]
        public string OurSale { get; set; }
        [StringLength(200)]
        public string DealDate { get; set; }
        [StringLength(200)]
        public string ValueDate { get; set; }
        [StringLength(200)]
        public string Rate { get; set; }
        [StringLength(200)]
        public string EquivalentAmountCurrency { get; set; }
        [StringLength(200)]
        public string EquivalentAmount { get; set; }
        [StringLength(200)]
        public string Remarks { get; set; }

        [ForeignKey(nameof(StatementId))]
        [InverseProperty("ForeignExchangeStatements")]
        public virtual Statement Statement { get; set; }
    }
}
