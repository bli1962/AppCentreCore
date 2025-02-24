using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("STATUS_CODE")]
    public partial class StatusCode
    {
        [Key]
        [Column("STATUS_CODE")]
        [StringLength(1)]
        public string StatusCode1 { get; set; }
        [Column("STATUS_DESC")]
        [StringLength(30)]
        public string StatusDesc { get; set; }
    }
}
