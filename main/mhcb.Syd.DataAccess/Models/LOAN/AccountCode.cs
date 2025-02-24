using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("Account_Code")]
    public partial class AccountCode
    {
        public AccountCode()
        {
            LoanTrans = new HashSet<LoanTran>();
        }

        [Key]
        public int AccountCodeId { get; set; }
        [Column("AccountCode")]
        [StringLength(10)]
        public string AccountCode1 { get; set; }

        [InverseProperty(nameof(LoanTran.AccountCodeNavigation))]
        public virtual ICollection<LoanTran> LoanTrans { get; set; }
    }
}
