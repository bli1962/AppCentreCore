using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FxConfirmationComment", Schema = "dbo")]
    public partial class FxConfirmationComment
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string ReferenceNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AddDate { get; set; }
        [Required]
        [StringLength(1000)]
        [Unicode(false)]
        public string AddBy { get; set; }
        [Required]
        [StringLength(250)]
        [Unicode(false)]
        public string Comment { get; set; }
    }
}
