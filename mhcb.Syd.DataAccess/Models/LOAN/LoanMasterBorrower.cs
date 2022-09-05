using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("LOAN_MASTER_BORROWER")]
    public partial class LoanMasterBorrower
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("LOAN_NO")]
        public int LoanNo { get; set; }
        [Required]
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Required]
        [Column("CCIF")]
        [StringLength(7)]
        public string Ccif { get; set; }
        [Required]
        [Column("CCIF_NAME")]
        [StringLength(70)]
        public string CcifName { get; set; }
        [Required]
        [Column("GCIF")]
        [StringLength(6)]
        public string Gcif { get; set; }

        [ForeignKey(nameof(LoanNo))]
        [InverseProperty(nameof(LoanMaster.LoanMasterBorrowers))]
        public virtual LoanMaster LoanNoNavigation { get; set; }
    }
}
