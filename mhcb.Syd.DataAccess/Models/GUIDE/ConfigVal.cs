using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("Config_val")]
    public partial class ConfigVal
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(1500)]
        public string Value { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
    }
}
