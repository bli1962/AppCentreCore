using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("RACF_SYSTEM_ID")]
    public partial class RacfSystemId
    {
        [Key]
        [Column("ID_TYPE")]
        [StringLength(25)]
        public string IdType { get; set; }
        [Key]
        [Column("SYSTEM_ID")]
        [StringLength(8)]
        public string SystemId { get; set; }
        [Required]
        [Column("PASSWORD")]
        [StringLength(68)]
        public string Password { get; set; }
        [Column("PWD_CREATE_DATE", TypeName = "datetime")]
        public DateTime PwdCreateDate { get; set; }
        [Column("RACF_STATUS_CODE")]
        [StringLength(1)]
        public string RacfStatusCode { get; set; }
        [Column("RACF_PREVIOUS_PWD")]
        [StringLength(68)]
        public string RacfPreviousPwd { get; set; }
        [Column("CHANGED_BY")]
        [StringLength(8)]
        public string ChangedBy { get; set; }
        [Column("CHANGED_DATE", TypeName = "datetime")]
        public DateTime? ChangedDate { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(80)]
        public string Description { get; set; }
    }
}
