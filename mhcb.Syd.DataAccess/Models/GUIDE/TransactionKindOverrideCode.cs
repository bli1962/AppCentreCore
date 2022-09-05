using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("TransactionKindOverrideCode")]
    public partial class TransactionKindOverrideCode
    {
        [Required]
        [StringLength(50)]
        public string CounterpartyLabel { get; set; }
        [Required]
        [Column("GBaseCustomerAbbrev")]
        [StringLength(50)]
        public string GbaseCustomerAbbrev { get; set; }
        [Required]
        [StringLength(20)]
        public string MxTypology { get; set; }
        [Required]
        [StringLength(20)]
        public string MxPayout { get; set; }
        [Required]
        [StringLength(3)]
        public string TransactionKind { get; set; }
    }
}
