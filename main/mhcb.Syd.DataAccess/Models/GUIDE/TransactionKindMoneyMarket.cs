using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("TransactionKindMoneyMarket", Schema = "dbo")]
    public partial class TransactionKindMoneyMarket
    {
        [Required]
        [StringLength(15)]
        [Unicode(false)]
        public string BranchCode { get; set; }
        public int BranchNo { get; set; }
        [Required]
        [StringLength(10)]
        [Unicode(false)]
        public string TransactionType { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string AccountCategory { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Description { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string MxLegalEntity { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string MxTypology { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string Payout { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string CounterpartyTypeRule { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string TermRule { get; set; }
        [Required]
        [StringLength(3)]
        public string TransactionKind { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string BuySell { get; set; }
    }
}
