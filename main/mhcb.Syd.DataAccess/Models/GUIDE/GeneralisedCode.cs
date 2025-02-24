using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("GENERALISED_CODES", Schema = "dbo")]
    public partial class GeneralisedCode
    {
        [Required]
        [Column("TYPE")]
        [StringLength(25)]
        [Unicode(false)]
        public string Type { get; set; }
        [Required]
        [Column("CODE")]
        [StringLength(20)]
        [Unicode(false)]
        public string Code { get; set; }
        [Required]
        [Column("ABBREVIATION")]
        [StringLength(20)]
        [Unicode(false)]
        public string Abbreviation { get; set; }
        [Required]
        [Column("DESCRIPTION")]
        [StringLength(100)]
        [Unicode(false)]
        public string Description { get; set; }
        [Column("CREATED_AMENDED_DATE", TypeName = "datetime")]
        public DateTime? CreatedAmendedDate { get; set; }
    }
}
