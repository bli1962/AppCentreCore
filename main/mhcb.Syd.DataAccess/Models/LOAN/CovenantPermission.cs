using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("COVENANT_PERMISSION")]
    public partial class CovenantPermission
    {
        [Key]
        [Column("DEPT_ID")]
        public int DeptId { get; set; }
        [Key]
        [Column("DEPARTMENT_CODE")]
        [StringLength(3)]
        public string DepartmentCode { get; set; }
        [Column("DEPT_CODE_ID")]
        public int? DeptCodeId { get; set; }
    }
}
