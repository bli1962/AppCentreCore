using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("PROD_TYPE")]
    public partial class ProdType
    {
        [Key]
        [Column("PROD_ID")]
        public short ProdId { get; set; }
        [Column("PROD_DESC")]
        [StringLength(20)]
        public string ProdDesc { get; set; }
    }
}
