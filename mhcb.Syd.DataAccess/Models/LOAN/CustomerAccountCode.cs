using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("Customer_Account_Code")]
    public partial class CustomerAccountCode
    {
        public CustomerAccountCode()
        {
            LoanTrans = new HashSet<LoanTran>();
        }

        [Key]
        public int CustomerAccountCodeId { get; set; }
        [Required]
        [Column("CustomerAccountCode")]
        [StringLength(25)]
        public string CustomerAccountCode1 { get; set; }

        [InverseProperty(nameof(LoanTran.CustomerAccountCodeNavigation))]
        public virtual ICollection<LoanTran> LoanTrans { get; set; }
    }
}
