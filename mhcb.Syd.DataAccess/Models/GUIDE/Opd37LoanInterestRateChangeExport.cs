using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("OPD-37_LoanInterestRateChange_Export")]
    public partial class Opd37LoanInterestRateChangeExport
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("RawID")]
        public int? RawId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("AS_OF_DATE", TypeName = "datetime")]
        public DateTime? AsOfDate { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("DRAW_DOWN_NO")]
        [StringLength(3)]
        public string DrawDownNo { get; set; }
        [Column("ROLL_OVER_NO")]
        [StringLength(3)]
        public string RollOverNo { get; set; }
        [Column("AGENT_LOAN")]
        [StringLength(5)]
        public string AgentLoan { get; set; }
        [Column("NEXT_RATE_CHANGE")]
        [StringLength(12)]
        public string NextRateChange { get; set; }
        [Column("TERM_INT_RATE")]
        [StringLength(11)]
        public string TermIntRate { get; set; }
        [Column("REMARKS")]
        [StringLength(255)]
        public string Remarks { get; set; }
        public int? Processed { get; set; }
    }
}
