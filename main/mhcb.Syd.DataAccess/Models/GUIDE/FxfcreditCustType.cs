using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FXFCreditCustType", Schema = "dbo")]
    public partial class FxfcreditCustType
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(4)]
        [Unicode(false)]
        public string Code { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string Description { get; set; }
        public int? Active { get; set; }
    }
}
