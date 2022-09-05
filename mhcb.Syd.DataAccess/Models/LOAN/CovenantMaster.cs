using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("COVENANT_MASTER")]
    public partial class CovenantMaster
    {
        public CovenantMaster()
        {
            CovenantRecords = new HashSet<CovenantRecord>();
            LoanMasterCovenants = new HashSet<LoanMasterCovenant>();
        }

        [Key]
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
        [Column("ACCOUNT_OFFICER")]
        [StringLength(6)]
        public string AccountOfficer { get; set; }
        [Column("COV_TYPE")]
        [StringLength(3)]
        public string CovType { get; set; }
        [Column("REPORT_TYPE")]
        public byte? ReportType { get; set; }
        [Column("FREQ_TYPE")]
        public byte? FreqType { get; set; }
        [Column("DAY_OF_MONTH_TYPE")]
        public byte? DayOfMonthType { get; set; }
        [Column("COV_START_DATE", TypeName = "smalldatetime")]
        public DateTime? CovStartDate { get; set; }
        [Column("COV_END_DATE", TypeName = "smalldatetime")]
        public DateTime? CovEndDate { get; set; }
        [Column("TIME_OF_RECEIPT")]
        public byte? TimeOfReceipt { get; set; }
        [Column("CONDITION_TYPE")]
        public byte? ConditionType { get; set; }
        [Column("MATH_SYMBOL")]
        [StringLength(2)]
        public string MathSymbol { get; set; }
        [Column("VALUE", TypeName = "decimal(38, 2)")]
        public decimal? Value { get; set; }
        [Column("DENOMINATION")]
        [StringLength(10)]
        public string Denomination { get; set; }
        [Column("MARGIN_BASE_TYPE")]
        public byte? MarginBaseType { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(500)]
        public string Description { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("PROC_BY")]
        [StringLength(6)]
        public string ProcBy { get; set; }
        [Column("PROC_ON", TypeName = "datetime")]
        public DateTime? ProcOn { get; set; }
        [Column("APPR_BY")]
        [StringLength(6)]
        public string ApprBy { get; set; }
        [Column("APPR_ON", TypeName = "datetime")]
        public DateTime? ApprOn { get; set; }

        [ForeignKey(nameof(ConditionType))]
        [InverseProperty(nameof(CovenantCondition.CovenantMasters))]
        public virtual CovenantCondition ConditionTypeNavigation { get; set; }
        [InverseProperty(nameof(CovenantRecord.CovenantNoNavigation))]
        public virtual ICollection<CovenantRecord> CovenantRecords { get; set; }
        [InverseProperty(nameof(LoanMasterCovenant.CovenantNoNavigation))]
        public virtual ICollection<LoanMasterCovenant> LoanMasterCovenants { get; set; }
    }
}
