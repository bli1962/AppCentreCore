using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("MASS_DREAMS_APPROVAL_ACCESS", Schema = "dbo")]
    public partial class MassDreamsApprovalAccess
    {
        [Required]
        [Column("DEPT_CODE")]
        [StringLength(6)]
        [Unicode(false)]
        public string DeptCode { get; set; }
        [Required]
        [Column("MENU_OPTION")]
        [StringLength(2)]
        [Unicode(false)]
        public string MenuOption { get; set; }
        [Column("OPTION_DESC")]
        [StringLength(20)]
        [Unicode(false)]
        public string OptionDesc { get; set; }
    }
}
