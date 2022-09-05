using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("RAM_GBASE_TOTAL")]
    public partial class RamGbaseTotal
    {
        [Column("PROCESS_DATE", TypeName = "datetime")]
        public DateTime ProcessDate { get; set; }
        [Required]
        [Column("DEPARTMENT")]
        [StringLength(100)]
        public string Department { get; set; }
        [Column("TOTAL")]
        public int Total { get; set; }
        [Column("DELETE_TOTAL")]
        public int? DeleteTotal { get; set; }
        [Required]
        [Column("BRANCH")]
        [StringLength(3)]
        public string Branch { get; set; }
    }
}
