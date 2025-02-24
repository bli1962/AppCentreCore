using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FXFInstitution", Schema = "dbo")]
    [Index("Code", Name = "IX_FXFInstitution_CODE", IsUnique = true)]
    public partial class Fxfinstitution
    {
        [Key]
        [Column("INSTITUTIONID")]
        public int Institutionid { get; set; }
        [Column("CODE")]
        [StringLength(35)]
        [Unicode(false)]
        public string Code { get; set; }
        [Column("SUBTYPECODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string Subtypecode { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(50)]
        [Unicode(false)]
        public string Description { get; set; }
    }
}
