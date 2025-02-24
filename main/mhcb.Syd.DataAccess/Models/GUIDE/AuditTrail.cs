using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("AUDIT_TRAIL", Schema = "dbo")]
    public partial class AuditTrail
    {
        [Key]
        [Column("IDENTIFIER", TypeName = "decimal(12, 0)")]
        public decimal Identifier { get; set; }
        [Required]
        [Column("USER_ID")]
        [StringLength(20)]
        [Unicode(false)]
        public string UserId { get; set; }
        [Column("EVENT_DATE", TypeName = "datetime")]
        public DateTime EventDate { get; set; }
        [Column("EVENT_IDENTIFIER", TypeName = "decimal(5, 0)")]
        public decimal EventIdentifier { get; set; }
        [Required]
        [Column("DETAILS")]
        [StringLength(300)]
        [Unicode(false)]
        public string Details { get; set; }
        [Column("SM_IDENTIFIER", TypeName = "decimal(8, 0)")]
        public decimal? SmIdentifier { get; set; }
        [Column("DEPT_CODE")]
        [StringLength(6)]
        [Unicode(false)]
        public string DeptCode { get; set; }
    }
}
