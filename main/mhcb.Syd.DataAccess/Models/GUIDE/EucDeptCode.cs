using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("EUC_DEPT_CODE", Schema = "dbo")]
    public partial class EucDeptCode
    {
        [Key]
        [Column("DEPT_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string DeptCd { get; set; }
        [Column("DEPT_NAME")]
        [StringLength(25)]
        [Unicode(false)]
        public string DeptName { get; set; }
        [Column("DEPT_ABBR")]
        [StringLength(4)]
        [Unicode(false)]
        public string DeptAbbr { get; set; }
        [Key]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        [Unicode(false)]
        public string BranchNo { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        [Unicode(false)]
        public string StatusCd { get; set; }
    }
}
