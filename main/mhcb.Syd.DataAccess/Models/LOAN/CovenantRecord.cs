using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("COVENANT_RECORD")]
    public partial class CovenantRecord
    {
        [Key]
        [Column("COVENANT_NO")]
        public int CovenantNo { get; set; }
        [Key]
        [Column("RECORD_NO")]
        public int RecordNo { get; set; }
        [Column("REPORT_FREQ_TYPE")]
        public byte? ReportFreqType { get; set; }
        [Column("REPORT_DATE", TypeName = "smalldatetime")]
        public DateTime? ReportDate { get; set; }
        [Column("DUE_DATE", TypeName = "smalldatetime")]
        public DateTime? DueDate { get; set; }
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
        [Column("REMARKS")]
        [StringLength(200)]
        public string Remarks { get; set; }
        [Column("ORIGINAL_DESC")]
        [StringLength(500)]
        public string OriginalDesc { get; set; }
        [Column("AO_REMARKS")]
        [StringLength(200)]
        public string AoRemarks { get; set; }
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
        [Column("STRESS_VALUE", TypeName = "decimal(38, 2)")]
        public decimal? StressValue { get; set; }

        [ForeignKey(nameof(CovenantNo))]
        [InverseProperty(nameof(CovenantMaster.CovenantRecords))]
        public virtual CovenantMaster CovenantNoNavigation { get; set; }
    }
}
