using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EDocument
{
    public partial class MoneyMarketStatement
    {
        [Key]
        public int Id { get; set; }
        public int StatementId { get; set; }
        [StringLength(200)]
        public string Date { get; set; }
        [StringLength(1)]
        public string DebitCredit { get; set; }
        [StringLength(200)]
        public string Principal { get; set; }
        [StringLength(200)]
        public string Days { get; set; }
        [StringLength(200)]
        public string Rate { get; set; }
        [StringLength(200)]
        public string DealNo { get; set; }
        [StringLength(200)]
        public string Term { get; set; }
        [StringLength(200)]
        public string Comments { get; set; }
        [StringLength(200)]
        public string Broker { get; set; }
        [StringLength(200)]
        public string Interest { get; set; }

        [ForeignKey(nameof(StatementId))]
        [InverseProperty("MoneyMarketStatements")]
        public virtual Statement Statement { get; set; }
    }
}
