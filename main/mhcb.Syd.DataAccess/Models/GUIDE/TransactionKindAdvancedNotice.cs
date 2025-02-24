using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("TransactionKindAdvancedNotice", Schema = "dbo")]
    public partial class TransactionKindAdvancedNotice
    {
        [Required]
        [StringLength(3)]
        public string TransactionKind { get; set; }
        [Required]
        [StringLength(10)]
        [Unicode(false)]
        public string Typology { get; set; }
        [Required]
        [StringLength(2)]
        [Unicode(false)]
        public string Days { get; set; }
        [Key]
        [StringLength(40)]
        [Unicode(false)]
        public string Instrument { get; set; }
        [Required]
        [Column("ACTAbbr")]
        [StringLength(15)]
        [Unicode(false)]
        public string Actabbr { get; set; }
        [Required]
        [Column("ACTName")]
        [StringLength(30)]
        [Unicode(false)]
        public string Actname { get; set; }
        [Required]
        [Column("RATE")]
        [StringLength(10)]
        [Unicode(false)]
        public string Rate { get; set; }
        [Required]
        [StringLength(3)]
        [Unicode(false)]
        public string BranchNo { get; set; }
        [Required]
        [StringLength(25)]
        [Unicode(false)]
        public string LegalEntity { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string TicketProductName { get; set; }
        [Required]
        [StringLength(10)]
        [Unicode(false)]
        public string ComfirmationType { get; set; }
    }
}
