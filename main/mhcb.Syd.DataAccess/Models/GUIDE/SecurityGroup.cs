using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SECURITY_GROUPS", Schema = "dbo")]
    public partial class SecurityGroup
    {
        [Key]
        [Column("IDENTIFIER", TypeName = "decimal(8, 0)")]
        public decimal Identifier { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(20)]
        [Unicode(false)]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(255)]
        [Unicode(false)]
        public string Description { get; set; }
        [Column("ENABLED_IND")]
        [StringLength(1)]
        [Unicode(false)]
        public string EnabledInd { get; set; }
        [Column("CREATED_AMENDED_DATE", TypeName = "datetime")]
        public DateTime CreatedAmendedDate { get; set; }
    }
}
