using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    [Table("LCS_CUST_MASTER")]
    public partial class LcsCustMaster
    {
        [Required]
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Required]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CONTACT")]
        [StringLength(50)]
        public string Contact { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("PREP_BY")]
        [StringLength(6)]
        public string PrepBy { get; set; }
        [Column("PREP_ON", TypeName = "datetime")]
        public DateTime? PrepOn { get; set; }
        [Column("APPR_BY")]
        [StringLength(6)]
        public string ApprBy { get; set; }
        [Column("APPR_ON", TypeName = "datetime")]
        public DateTime? ApprOn { get; set; }
    }
}
