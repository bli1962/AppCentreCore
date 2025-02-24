using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("LOAN_MASTER_STATUS_CODE")]
    public partial class LoanMasterStatusCode
    {
        [Key]
        [Column("MODULE")]
        [StringLength(20)]
        public string Module { get; set; }
        [Key]
        [Column("STATUS_CODE")]
        [StringLength(1)]
        public string StatusCode { get; set; }
        [Required]
        [Column("SHORT_DESC")]
        [StringLength(10)]
        public string ShortDesc { get; set; }
        [Column("FULL_DESC")]
        [StringLength(20)]
        public string FullDesc { get; set; }
    }
}
