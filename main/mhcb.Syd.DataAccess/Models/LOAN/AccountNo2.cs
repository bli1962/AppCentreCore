using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("Account_No2")]
    public partial class AccountNo2
    {
        public AccountNo2()
        {
            LoanTrans = new HashSet<LoanTran>();
        }

        [Key]
        public int AccountNo2Id { get; set; }
        [Required]
        [StringLength(6)]
        public string AccountNo2Code { get; set; }

        [InverseProperty(nameof(LoanTran.AccountNo2Navigation))]
        public virtual ICollection<LoanTran> LoanTrans { get; set; }
    }
}
