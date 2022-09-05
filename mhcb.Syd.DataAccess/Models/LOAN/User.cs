using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("USERS")]
    public partial class User
    {
        public User()
        {
            LoanTrans = new HashSet<LoanTran>();
        }

        [Key]
        [Column("USER_ID")]
        [StringLength(6)]
        public string UserId { get; set; }
        [Column("USER_NAME")]
        [StringLength(20)]
        public string UserName { get; set; }
        [Column("PREPARE")]
        public bool? Prepare { get; set; }
        [Column("CHECK")]
        public bool? Check { get; set; }
        [Column("APPROVE")]
        public bool Approve { get; set; }
        [Column("MODIFY")]
        public bool Modify { get; set; }
        [Column("FINAL_CHECK")]
        public bool FinalCheck { get; set; }
        [Column("UNLOCK")]
        public bool Unlock { get; set; }
        [Column("SUPER")]
        public bool Super { get; set; }
        [Column("ADMIN")]
        public bool Admin { get; set; }
        [Column("APPROVED")]
        public bool Approved { get; set; }
        [Column("LAST_MOD_BY")]
        [StringLength(6)]
        public string LastModBy { get; set; }
        [Column("LAST_MOD_ON", TypeName = "datetime")]
        public DateTime? LastModOn { get; set; }
        [Column("LAST_APPR_BY")]
        [StringLength(6)]
        public string LastApprBy { get; set; }
        [Column("LAST_APPR_ON", TypeName = "datetime")]
        public DateTime? LastApprOn { get; set; }
        [Required]
        [Column("ACTIVE")]
        public bool? Active { get; set; }
        [Column("DEPT_ID")]
        public int? DeptId { get; set; }
        public bool? ModifyRates { get; set; }
        public bool? ApproveRates { get; set; }

        [InverseProperty(nameof(LoanTran.ProcBy1Navigation))]
        public virtual ICollection<LoanTran> LoanTrans { get; set; }
    }
}
