using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("TransactionKindAdvancedNotice")]
    public partial class TransactionKindAdvancedNotice
    {
        [Required]
        [StringLength(3)]
        public string TransactionKind { get; set; }
        [Required]
        [StringLength(10)]
        public string Typology { get; set; }
        [Required]
        [StringLength(2)]
        public string Days { get; set; }
        [Key]
        [StringLength(40)]
        public string Instrument { get; set; }
        [Required]
        [Column("ACTAbbr")]
        [StringLength(15)]
        public string Actabbr { get; set; }
        [Required]
        [Column("ACTName")]
        [StringLength(30)]
        public string Actname { get; set; }
        [Required]
        [Column("RATE")]
        [StringLength(10)]
        public string Rate { get; set; }
        [Required]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Required]
        [StringLength(25)]
        public string LegalEntity { get; set; }
        [Required]
        [StringLength(50)]
        public string TicketProductName { get; set; }
        [Required]
        [StringLength(10)]
        public string ComfirmationType { get; set; }
    }
}
