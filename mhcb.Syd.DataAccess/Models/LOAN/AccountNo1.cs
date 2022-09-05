using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("Account_No1")]
    public partial class AccountNo1
    {
        public AccountNo1()
        {
            LoanTrans = new HashSet<LoanTran>();
        }

        [Key]
        public int AccountNo1Id { get; set; }
        [Required]
        [StringLength(3)]
        public string AccountNo1Code { get; set; }

        [InverseProperty(nameof(LoanTran.AccountNo1Navigation))]
        public virtual ICollection<LoanTran> LoanTrans { get; set; }
    }
}
