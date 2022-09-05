using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("TransactionKindMoneyMarket")]
    public partial class TransactionKindMoneyMarket
    {
        [Required]
        [StringLength(15)]
        public string BranchCode { get; set; }
        public int BranchNo { get; set; }
        [Required]
        [StringLength(10)]
        public string TransactionType { get; set; }
        [Required]
        [StringLength(50)]
        public string AccountCategory { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        [StringLength(50)]
        public string MxLegalEntity { get; set; }
        [Required]
        [StringLength(20)]
        public string MxTypology { get; set; }
        [Required]
        [StringLength(20)]
        public string Payout { get; set; }
        [StringLength(20)]
        public string CounterpartyTypeRule { get; set; }
        [StringLength(30)]
        public string TermRule { get; set; }
        [Required]
        [StringLength(3)]
        public string TransactionKind { get; set; }
        [Required]
        [StringLength(50)]
        public string BuySell { get; set; }
    }
}
