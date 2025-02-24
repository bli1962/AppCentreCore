using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("LOAN_MASTER_ACCOUNT_OFFICER")]
    public partial class LoanMasterAccountOfficer
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("LOAN_NO")]
        public int? LoanNo { get; set; }
        [Column("ACCOUNT_OFFICER")]
        [StringLength(6)]
        public string AccountOfficer { get; set; }

        [ForeignKey(nameof(LoanNo))]
        [InverseProperty(nameof(LoanMaster.LoanMasterAccountOfficers))]
        public virtual LoanMaster LoanNoNavigation { get; set; }
    }
}
