using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("EUC_DEPT_CODE")]
    public partial class EucDeptCode
    {
        [Key]
        [Column("DEPT_CD")]
        [StringLength(2)]
        public string DeptCd { get; set; }
        [Column("DEPT_NAME")]
        [StringLength(25)]
        public string DeptName { get; set; }
        [Column("DEPT_ABBR")]
        [StringLength(4)]
        public string DeptAbbr { get; set; }
        [Key]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
    }
}
