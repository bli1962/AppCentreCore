using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    [Table("MARGIN_BASE")]
    public partial class MarginBase
    {
        [Column("MARGIN_BASE_TYPE")]
        public byte MarginBaseType { get; set; }
        [Column("MARGIN_BASE_DESC")]
        [StringLength(50)]
        public string MarginBaseDesc { get; set; }
    }
}
