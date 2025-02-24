using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxIndustryCodeSector", Schema = "dbo")]
    public partial class MxIndustryCodeSector
    {
        [Key]
        [StringLength(6)]
        [Unicode(false)]
        public string IndustryCode { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string IndustryName { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Sector { get; set; }
    }
}
