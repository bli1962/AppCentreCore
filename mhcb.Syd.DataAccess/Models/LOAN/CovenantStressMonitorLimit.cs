using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    [Table("Covenant_Stress_Monitor_Limit")]
    public partial class CovenantStressMonitorLimit
    {
        [Column("Limit_type")]
        [StringLength(20)]
        public string LimitType { get; set; }
        public int? Limit { get; set; }
    }
}
