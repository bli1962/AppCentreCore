using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("LOAN_MASTER_SECURITY")]
    public partial class LoanMasterSecurity
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("LOAN_NO")]
        public int LoanNo { get; set; }
        [Column("GUARANTEE")]
        public bool Guarantee { get; set; }
        [Column("GUARANTOR")]
        public bool Guarantor { get; set; }
        [Required]
        [Column("GUARANTOR_SECURITY_TYPE")]
        [StringLength(30)]
        public string GuarantorSecurityType { get; set; }
        [Column("COLLATERAL")]
        public bool Collateral { get; set; }
        [Required]
        [Column("COLLATERAL_SECURITY_TYPE")]
        [StringLength(30)]
        public string CollateralSecurityType { get; set; }
        [Required]
        [Column("COLLATERAL_LEDGER")]
        [StringLength(10)]
        public string CollateralLedger { get; set; }
        [Column("EXPIRY_DATE", TypeName = "smalldatetime")]
        public DateTime? ExpiryDate { get; set; }
        [Required]
        [Column("DETAILS")]
        [StringLength(500)]
        public string Details { get; set; }
        [Required]
        [Column("REMARKS")]
        [StringLength(100)]
        public string Remarks { get; set; }
        [Required]
        [Column("COMMENT")]
        [StringLength(500)]
        public string Comment { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }

        [ForeignKey(nameof(LoanNo))]
        [InverseProperty(nameof(LoanMaster.LoanMasterSecurities))]
        public virtual LoanMaster LoanNoNavigation { get; set; }
    }
}
