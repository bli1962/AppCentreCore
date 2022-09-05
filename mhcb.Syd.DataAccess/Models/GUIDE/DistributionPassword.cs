using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DISTRIBUTION_PASSWORD")]
    public partial class DistributionPassword
    {
        [Key]
        public int Id { get; set; }
        [StringLength(6)]
        public string CustomerCode { get; set; }
        [Required]
        [StringLength(250)]
        public string Password { get; set; }
        [StringLength(3)]
        public string CustomerBranch { get; set; }
        [StringLength(12)]
        public string CustomerAbbr { get; set; }
        public bool Encode { get; set; }
    }
}
