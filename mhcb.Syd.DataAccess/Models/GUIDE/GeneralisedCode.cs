using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GENERALISED_CODES")]
    public partial class GeneralisedCode
    {
        [Required]
        [Column("TYPE")]
        [StringLength(25)]
        public string Type { get; set; }
        [Required]
        [Column("CODE")]
        [StringLength(20)]
        public string Code { get; set; }
        [Required]
        [Column("ABBREVIATION")]
        [StringLength(20)]
        public string Abbreviation { get; set; }
        [Required]
        [Column("DESCRIPTION")]
        [StringLength(100)]
        public string Description { get; set; }
        [Column("CREATED_AMENDED_DATE", TypeName = "datetime")]
        public DateTime? CreatedAmendedDate { get; set; }
    }
}
