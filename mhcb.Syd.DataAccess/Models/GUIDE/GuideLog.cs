using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("GUIDE_LOG")]
    public partial class GuideLog
    {
        [Key]
        [Column("AuditID")]
        public int AuditId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime AuditDate { get; set; }
        [StringLength(20)]
        public string TableName { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [Column("USER_ID")]
        [StringLength(20)]
        public string UserId { get; set; }
    }
}
