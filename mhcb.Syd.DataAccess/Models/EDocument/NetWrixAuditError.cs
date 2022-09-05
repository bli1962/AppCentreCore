using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EDocument
{
    [Table("NetWrix_audit_errors")]
    [Index(nameof(MessageId), Name = "NetWrixMessageIDNonClustered")]
    public partial class NetWrixAuditError
    {
        [Key]
        [Column("ErrorID")]
        public Guid ErrorId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ErrorTime { get; set; }
        [Required]
        public string Workstation { get; set; }
        [Required]
        public string Application { get; set; }
        [Required]
        [StringLength(128)]
        public string DataBaseName { get; set; }
        [Required]
        [StringLength(128)]
        public string TableName { get; set; }
        [Column("MessageID")]
        public int MessageId { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
