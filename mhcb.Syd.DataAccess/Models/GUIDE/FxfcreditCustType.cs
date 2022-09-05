using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FXFCreditCustType")]
    public partial class FxfcreditCustType
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(4)]
        public string Code { get; set; }
        [StringLength(25)]
        public string Description { get; set; }
        public int? Active { get; set; }
    }
}
