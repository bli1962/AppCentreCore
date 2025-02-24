using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DISTRIBUTION_PASSWORD", Schema = "dbo")]
    public partial class DistributionPassword
    {
        [Key]
        public int Id { get; set; }
        [StringLength(6)]
        [Unicode(false)]
        public string CustomerCode { get; set; }
        [Required]
        [StringLength(250)]
        public string Password { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string CustomerBranch { get; set; }
        [StringLength(12)]
        [Unicode(false)]
        public string CustomerAbbr { get; set; }
        public bool Encode { get; set; }
    }
}
