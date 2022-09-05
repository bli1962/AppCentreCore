using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    public partial class ViewLoanCovenantRecord
    {
        [Column("COVENANT_NO")]
        public int? CovenantNo { get; set; }
        [Column("RECORD_NO")]
        public int? RecordNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
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
        [Column("ACCOUNT_OFFICER")]
        [StringLength(6)]
        public string AccountOfficer { get; set; }
        [Column("DEPARTMENT_CD")]
        [StringLength(2)]
        public string DepartmentCd { get; set; }
        [Column("REPORT_DATE", TypeName = "smalldatetime")]
        public DateTime? ReportDate { get; set; }
        [Column("DUE_DATE", TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
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
        [Column("DATE_RECIEVED", TypeName = "smalldatetime")]
        public DateTime? DateRecieved { get; set; }
        [Column("RATE", TypeName = "decimal(38, 2)")]
        public decimal? Rate { get; set; }
        [Column("DATE_RECIEVED_ADJ", TypeName = "smalldatetime")]
        public DateTime? DateRecievedAdj { get; set; }
        [Column("RATE_ADJ", TypeName = "decimal(38, 2)")]
        public decimal? RateAdj { get; set; }
        [Column("IN_COMPLIANCE")]
        [StringLength(5)]
        public string InCompliance { get; set; }
        [Column("PROC_BY")]
        [StringLength(6)]
        public string ProcBy { get; set; }
        [Required]
        [Column("REC_STATUS")]
        [StringLength(9)]
        public string RecStatus { get; set; }
        [Column("LOAN_NO")]
        public int? LoanNo { get; set; }
        [Column("LOAN_AO")]
        [StringLength(6)]
        public string LoanAo { get; set; }
    }
}
