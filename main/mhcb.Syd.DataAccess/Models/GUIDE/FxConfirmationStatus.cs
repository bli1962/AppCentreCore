using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FxConfirmationStatus", Schema = "dbo")]
    public partial class FxConfirmationStatus
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Status { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string Description { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string DisplayText { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string FinalStatus { get; set; }
    }
}
