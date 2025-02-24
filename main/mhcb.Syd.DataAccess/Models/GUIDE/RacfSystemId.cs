using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("RACF_SYSTEM_ID", Schema = "dbo")]
    public partial class RacfSystemId
    {
        [Key]
        [Column("ID_TYPE")]
        [StringLength(25)]
        [Unicode(false)]
        public string IdType { get; set; }
        [Key]
        [Column("SYSTEM_ID")]
        [StringLength(8)]
        [Unicode(false)]
        public string SystemId { get; set; }
        [Required]
        [Column("PASSWORD")]
        [StringLength(68)]
        [Unicode(false)]
        public string Password { get; set; }
        [Column("PWD_CREATE_DATE", TypeName = "datetime")]
        public DateTime PwdCreateDate { get; set; }
        [Column("RACF_STATUS_CODE")]
        [StringLength(1)]
        [Unicode(false)]
        public string RacfStatusCode { get; set; }
        [Column("RACF_PREVIOUS_PWD")]
        [StringLength(68)]
        [Unicode(false)]
        public string RacfPreviousPwd { get; set; }
        [Column("CHANGED_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string ChangedBy { get; set; }
        [Column("CHANGED_DATE", TypeName = "datetime")]
        public DateTime? ChangedDate { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(80)]
        [Unicode(false)]
        public string Description { get; set; }
    }
}
