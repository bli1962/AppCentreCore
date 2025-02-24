using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("AUDIT_LOG", Schema = "dbo")]
    public partial class AuditLog
    {
        [Key]
        [Column("AUDIT_ID")]
        public int AuditId { get; set; }
        [Required]
        [Column("USER_ID")]
        [StringLength(8)]
        [Unicode(false)]
        public string UserId { get; set; }
        [Column("AUDIT_DATE", TypeName = "datetime")]
        public DateTime? AuditDate { get; set; }
        [Required]
        [Column("REF_NO")]
        [StringLength(20)]
        [Unicode(false)]
        public string RefNo { get; set; }
        [Column("TRANS_NO")]
        [StringLength(12)]
        [Unicode(false)]
        public string TransNo { get; set; }
        [Column("AUDIT_DESC")]
        [StringLength(200)]
        [Unicode(false)]
        public string AuditDesc { get; set; }
        [Column("APP_NAME")]
        [StringLength(50)]
        [Unicode(false)]
        public string AppName { get; set; }
        [Column("TABLE_NAME")]
        [StringLength(50)]
        [Unicode(false)]
        public string TableName { get; set; }
        [Column("ORIGINAL_VALUE")]
        [StringLength(400)]
        [Unicode(false)]
        public string OriginalValue { get; set; }
        [Column("NEW_VALUE")]
        [StringLength(400)]
        [Unicode(false)]
        public string NewValue { get; set; }
    }
}
