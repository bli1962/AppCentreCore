using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxTaxCode")]
    public partial class MxTaxCode
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(2)]
        public string Code { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? TaxRate { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [StringLength(3)]
        public string Branch { get; set; }
    }
}
