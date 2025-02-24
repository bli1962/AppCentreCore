using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("LOAN_MASTER_COVENANT")]
    public partial class LoanMasterCovenant
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("LOAN_NO")]
        public int LoanNo { get; set; }
        [Column("COVENANT_NO")]
        public int CovenantNo { get; set; }

        [ForeignKey(nameof(CovenantNo))]
        [InverseProperty(nameof(CovenantMaster.LoanMasterCovenants))]
        public virtual CovenantMaster CovenantNoNavigation { get; set; }
        [ForeignKey(nameof(LoanNo))]
        [InverseProperty(nameof(LoanMaster.LoanMasterCovenants))]
        public virtual LoanMaster LoanNoNavigation { get; set; }
    }
}
