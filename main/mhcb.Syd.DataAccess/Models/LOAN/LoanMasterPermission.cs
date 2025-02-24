using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    [Table("LOAN_MASTER_Permission")]
    public partial class LoanMasterPermission
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("DEPT_ID")]
        public int DeptId { get; set; }
        [Required]
        [Column("DEPARTMENT_CD")]
        [StringLength(2)]
        public string DepartmentCd { get; set; }
    }
}
