using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("AUDIT_LOG")]
    public partial class AuditLog
    {
        [Key]
        [Column("AUDIT_ID")]
        public int AuditId { get; set; }
        [Required]
        [Column("USER_ID")]
        [StringLength(8)]
        public string UserId { get; set; }
        [Column("AUDIT_DATE", TypeName = "datetime")]
        public DateTime? AuditDate { get; set; }
        [Required]
        [Column("REF_NO")]
        [StringLength(20)]
        public string RefNo { get; set; }
        [Column("TRANS_NO")]
        [StringLength(12)]
        public string TransNo { get; set; }
        [Column("AUDIT_DESC")]
        [StringLength(200)]
        public string AuditDesc { get; set; }
        [Column("APP_NAME")]
        [StringLength(50)]
        public string AppName { get; set; }
        [Column("TABLE_NAME")]
        [StringLength(50)]
        public string TableName { get; set; }
        [Column("ORIGINAL_VALUE")]
        [StringLength(400)]
        public string OriginalValue { get; set; }
        [Column("NEW_VALUE")]
        [StringLength(400)]
        public string NewValue { get; set; }
    }
}
