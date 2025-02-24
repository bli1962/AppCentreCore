using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    [Table("RATING_CODE")]
    public partial class RatingCode
    {
        [Column("CODE")]
        public byte? Code { get; set; }
        [Required]
        [Column("RATING")]
        [StringLength(2)]
        public string Rating { get; set; }
        [Column("CODE_DESC")]
        [StringLength(50)]
        public string CodeDesc { get; set; }
    }
}
