using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SYSTEM_REGISTRY_PARAMETERS")]
    public partial class SystemRegistryParameter
    {
        [Key]
        [Column("PARAM_KEY")]
        [StringLength(25)]
        public string ParamKey { get; set; }
        [Required]
        [Column("PARAM_VALUE")]
        [StringLength(120)]
        public string ParamValue { get; set; }
        [Required]
        [Column("ENCRIPT_IND")]
        [StringLength(1)]
        public string EncriptInd { get; set; }
        [Column("ACTIVE_FLAG")]
        [StringLength(1)]
        public string ActiveFlag { get; set; }
    }
}
