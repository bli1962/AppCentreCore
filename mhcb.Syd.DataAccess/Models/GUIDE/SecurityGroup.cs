using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SECURITY_GROUPS")]
    public partial class SecurityGroup
    {
        [Key]
        [Column("IDENTIFIER", TypeName = "decimal(8, 0)")]
        public decimal Identifier { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(20)]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("ENABLED_IND")]
        [StringLength(1)]
        public string EnabledInd { get; set; }
        [Column("CREATED_AMENDED_DATE", TypeName = "datetime")]
        public DateTime CreatedAmendedDate { get; set; }
    }
}
