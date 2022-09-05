using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FXFInstitution")]
    [Index(nameof(Code), Name = "IX_FXFInstitution_CODE", IsUnique = true)]
    public partial class Fxfinstitution
    {
        [Key]
        [Column("INSTITUTIONID")]
        public int Institutionid { get; set; }
        [Column("CODE")]
        [StringLength(35)]
        public string Code { get; set; }
        [Column("SUBTYPECODE")]
        [StringLength(2)]
        public string Subtypecode { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
