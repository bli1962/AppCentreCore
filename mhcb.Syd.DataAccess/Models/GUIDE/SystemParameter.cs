using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SYSTEM_PARAMETERS")]
    public partial class SystemParameter
    {
        [Key]
        [Column("PARAM_TYPE")]
        [StringLength(25)]
        public string ParamType { get; set; }
        [Required]
        [Column("PARAM_VALUE")]
        [StringLength(130)]
        public string ParamValue { get; set; }
    }
}
