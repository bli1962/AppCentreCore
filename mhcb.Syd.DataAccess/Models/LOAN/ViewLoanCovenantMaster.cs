using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    public partial class ViewLoanCovenantMaster
    {
        [Column("COVENANT_NO")]
        public int CovenantNo { get; set; }
        [Column("CATEGORY")]
        [StringLength(15)]
        public string Category { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("CUST_NAME")]
        [StringLength(40)]
        public string CustName { get; set; }
        [Column("FREQ_DESC")]
        [StringLength(41)]
        public string FreqDesc { get; set; }
        [Required]
        [Column("TIMING_DESC")]
        [StringLength(10)]
        public string TimingDesc { get; set; }
        [Column("ACCOUNT_OFFICER")]
        [StringLength(6)]
        public string AccountOfficer { get; set; }
        [Column("COVENANT_DECS")]
        [StringLength(25)]
        public string CovenantDecs { get; set; }
        [Column("COV_ORDER")]
        public int CovOrder { get; set; }
        [Column("CONDITION_DESC")]
        [StringLength(50)]
        public string ConditionDesc { get; set; }
        [Column("CONDIT")]
        [StringLength(150)]
        public string Condit { get; set; }
        [Column("MATH_SYMBOL")]
        [StringLength(2)]
        public string MathSymbol { get; set; }
        [Column("VALUE", TypeName = "decimal(38, 2)")]
        public decimal? Value { get; set; }
        [Column("DENOMINATION")]
        [StringLength(10)]
        public string Denomination { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        [Column("COV_STATUS")]
        [StringLength(9)]
        public string CovStatus { get; set; }
        [Column("DEPARTMENT_CD")]
        [StringLength(2)]
        public string DepartmentCd { get; set; }
        [Column("LOAN_NO")]
        public int? LoanNo { get; set; }
        [Column("LOAN_AO")]
        [StringLength(6)]
        public string LoanAo { get; set; }
        [Column("COV_APPR_ON", TypeName = "datetime")]
        public DateTime? CovApprOn { get; set; }
        [Column("COV_APPR_BY")]
        [StringLength(6)]
        public string CovApprBy { get; set; }
    }
}
