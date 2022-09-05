using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("COVENANT_TYPE")]
    public partial class CovenantType
    {
        [Key]
        [Column("COVENANT_TYPE")]
        [StringLength(3)]
        public string CovenantType1 { get; set; }
        [Column("COVENANT_DECS")]
        [StringLength(25)]
        public string CovenantDecs { get; set; }
    }
}
