using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MxIndustryCodeSector")]
    public partial class MxIndustryCodeSector
    {
        [Key]
        [StringLength(6)]
        public string IndustryCode { get; set; }
        [StringLength(50)]
        public string IndustryName { get; set; }
        [Required]
        [StringLength(50)]
        public string Sector { get; set; }
    }
}
