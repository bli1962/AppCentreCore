using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    [Table("DEPT_PERMISSION")]
    public partial class DeptPermission
    {
        [Column("DEPT_ID")]
        public int DeptId { get; set; }
        [Required]
        [Column("DEPT_NAME")]
        [StringLength(5)]
        public string DeptName { get; set; }
        [Column("VIEW_USER")]
        public bool? ViewUser { get; set; }
        [Column("ACT_USER")]
        public bool? ActUser { get; set; }
        [Column("VIEW_CUST")]
        public bool? ViewCust { get; set; }
        [Column("ACT_CUST")]
        public bool? ActCust { get; set; }
        [Column("VIEW_FACILITY")]
        public bool? ViewFacility { get; set; }
        [Column("ACT_FACILITY")]
        public bool? ActFacility { get; set; }
        [Column("VIEW_TRANS")]
        public bool? ViewTrans { get; set; }
        [Column("ACT_TRANS")]
        public bool? ActTrans { get; set; }
        [Column("VIEW_COVENANT")]
        public bool? ViewCovenant { get; set; }
        [Column("ACT_COVENANT")]
        public bool? ActCovenant { get; set; }
        [Column("VIEW_AO")]
        public bool? ViewAo { get; set; }
        [Column("ACT_AO")]
        public bool? ActAo { get; set; }
        [Column("VIEW_LOAN")]
        public bool? ViewLoan { get; set; }
        [Column("ACT_LOAN")]
        public bool? ActLoan { get; set; }
    }
}
