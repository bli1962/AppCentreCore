using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    public partial class VGuideEucDeptCode
    {
        [Required]
        [Column("DEPT_CD")]
        [StringLength(2)]
        public string DeptCd { get; set; }
        [Column("DEPT_NAME")]
        [StringLength(25)]
        public string DeptName { get; set; }
        [Column("DEPT_ABBR")]
        [StringLength(4)]
        public string DeptAbbr { get; set; }
        [Required]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
    }
}
