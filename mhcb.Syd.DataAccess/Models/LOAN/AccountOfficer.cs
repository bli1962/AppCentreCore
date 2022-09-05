using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    [Table("ACCOUNT_OFFICER")]
    public partial class AccountOfficer
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("ACCOUNT_OFFICER")]
        [StringLength(6)]
        public string AccountOfficer1 { get; set; }
        [Column("PROC_BY")]
        [StringLength(6)]
        public string ProcBy { get; set; }
        [Column("PROC_ON", TypeName = "smalldatetime")]
        public DateTime? ProcOn { get; set; }
    }
}
