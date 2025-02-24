using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("SYSTEM_REGISTRY_PARAMETERS", Schema = "dbo")]
    public partial class SystemRegistryParameter
    {
        [Key]
        [Column("PARAM_KEY")]
        [StringLength(25)]
        [Unicode(false)]
        public string ParamKey { get; set; }
        [Required]
        [Column("PARAM_VALUE")]
        [StringLength(120)]
        [Unicode(false)]
        public string ParamValue { get; set; }
        [Required]
        [Column("ENCRIPT_IND")]
        [StringLength(1)]
        [Unicode(false)]
        public string EncriptInd { get; set; }
        [Column("ACTIVE_FLAG")]
        [StringLength(1)]
        [Unicode(false)]
        public string ActiveFlag { get; set; }
    }
}
