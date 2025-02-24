using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("Config_val", Schema = "dbo")]
    public partial class ConfigVal
    {
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; }
        [StringLength(1500)]
        [Unicode(false)]
        public string Value { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Description { get; set; }
    }
}
