using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("USERS", Schema = "dbo")]
    public partial class User
    {
        [Key]
        [Column("USER_ID")]
        [StringLength(20)]
        [Unicode(false)]
        public string UserId { get; set; }
        [Required]
        [Column("FIRST_NAME")]
        [StringLength(20)]
        [Unicode(false)]
        public string FirstName { get; set; }
        [Required]
        [Column("LAST_NAME")]
        [StringLength(20)]
        [Unicode(false)]
        public string LastName { get; set; }
        [Required]
        [Column("PASSWORD")]
        [StringLength(68)]
        [Unicode(false)]
        public string Password { get; set; }
        [Required]
        [Column("EMPLOYEE_NO")]
        [StringLength(20)]
        [Unicode(false)]
        public string EmployeeNo { get; set; }
        [Column("SG_IDENTIFIER", TypeName = "decimal(8, 0)")]
        public decimal? SgIdentifier { get; set; }
        [Column("ROLE")]
        [StringLength(50)]
        [Unicode(false)]
        public string Role { get; set; }
        [Column("ENABLED_IND")]
        [StringLength(1)]
        [Unicode(false)]
        public string EnabledInd { get; set; }
        [Column("PWD_CREATE_DATE", TypeName = "datetime")]
        public DateTime PwdCreateDate { get; set; }
        [Column("PWD_CHANGE_IND")]
        [StringLength(1)]
        [Unicode(false)]
        public string PwdChangeInd { get; set; }
        [Column("CREATED_AMENDED_DATE", TypeName = "datetime")]
        public DateTime CreatedAmendedDate { get; set; }
        [Column("DEPT_CODE")]
        [StringLength(6)]
        [Unicode(false)]
        public string DeptCode { get; set; }
        [Column("REC_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string RecStatus { get; set; }
        [Column("OPERATOR_ID")]
        [StringLength(3)]
        [Unicode(false)]
        public string OperatorId { get; set; }
        [Column("RANK_CODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string RankCode { get; set; }
        [Column("BU_STATUS_CODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string BuStatusCode { get; set; }
        [Column("ACU_STATUS_CODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string AcuStatusCode { get; set; }
        [Column("SUB_DEPT_CODE")]
        [StringLength(6)]
        [Unicode(false)]
        public string SubDeptCode { get; set; }
        [Column("CREATED_AMENDED_BY")]
        [StringLength(10)]
        [Unicode(false)]
        public string CreatedAmendedBy { get; set; }
        [Column("GBASE_UPLOADED_DATE", TypeName = "datetime")]
        public DateTime? GbaseUploadedDate { get; set; }
        [Column("GBASE_STATUS_CODE")]
        [StringLength(1)]
        [Unicode(false)]
        public string GbaseStatusCode { get; set; }
        [Column("RACF_STATUS_CODE")]
        [StringLength(2)]
        [Unicode(false)]
        public string RacfStatusCode { get; set; }
        [Column("RACF_PREVIOUS_PWD")]
        [StringLength(68)]
        [Unicode(false)]
        public string RacfPreviousPwd { get; set; }
        [Column("NO_OF_LOGIN_ATTEMPTS")]
        public int? NoOfLoginAttempts { get; set; }
        [Column("GBASE_PREVIOUS_PWD")]
        [StringLength(68)]
        [Unicode(false)]
        public string GbasePreviousPwd { get; set; }
        [Column("GBASE_PWD_BU_STATUS_CODE")]
        [StringLength(1)]
        [Unicode(false)]
        public string GbasePwdBuStatusCode { get; set; }
        [Column("GBASE_PWD_ACU_STATUS_CODE")]
        [StringLength(1)]
        [Unicode(false)]
        public string GbasePwdAcuStatusCode { get; set; }
        [Column("GBASE_PWD_STATUS_CODE")]
        [StringLength(1)]
        [Unicode(false)]
        public string GbasePwdStatusCode { get; set; }
        [Column("MASTER_ID")]
        [StringLength(8)]
        [Unicode(false)]
        public string MasterId { get; set; }
        [Column("APPROVED_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string ApprovedBy { get; set; }
        [Column("APPROVED_DATE", TypeName = "datetime")]
        public DateTime? ApprovedDate { get; set; }
        [Column("USER_PROFILE_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string UserProfileStatus { get; set; }
        [Column("APPROVAL_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string ApprovalStatus { get; set; }
        [Column("GBASE_REG_DATE", TypeName = "datetime")]
        public DateTime? GbaseRegDate { get; set; }
        [Column("GBASE_MODI_DATE", TypeName = "datetime")]
        public DateTime? GbaseModiDate { get; set; }
        [Column("CREATED_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string CreatedBy { get; set; }
        [Column("CREATED_DATE", TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("PROFILE_EDITED_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string ProfileEditedBy { get; set; }
        [Column("PROFILE_EDITED_DATE", TypeName = "datetime")]
        public DateTime? ProfileEditedDate { get; set; }
        [Column("RESET_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string ResetBy { get; set; }
        [Column("RESET_DATE", TypeName = "datetime")]
        public DateTime? ResetDate { get; set; }

        [InverseProperty("User")]
        public virtual UsersExt UsersExt { get; set; }
    }
}
