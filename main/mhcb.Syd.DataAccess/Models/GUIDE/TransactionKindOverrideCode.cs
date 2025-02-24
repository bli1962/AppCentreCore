using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("TransactionKindOverrideCode", Schema = "dbo")]
    public partial class TransactionKindOverrideCode
    {
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string CounterpartyLabel { get; set; }
        [Required]
        [Column("GBaseCustomerAbbrev")]
        [StringLength(50)]
        [Unicode(false)]
        public string GbaseCustomerAbbrev { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string MxTypology { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string MxPayout { get; set; }
        [Required]
        [StringLength(3)]
        public string TransactionKind { get; set; }
    }
}
