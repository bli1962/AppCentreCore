using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("OPD-37_Swap_Export", Schema = "dbo")]
    public partial class Opd37SwapExport
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
        [Unicode(false)]
        public string RefNo { get; set; }
        [Column("REF_SUB_NO")]
        [StringLength(2)]
        [Unicode(false)]
        public string RefSubNo { get; set; }
        [Column("START_DATE")]
        [StringLength(10)]
        [Unicode(false)]
        public string StartDate { get; set; }
        [Column("INT_RATE")]
        [StringLength(11)]
        [Unicode(false)]
        public string IntRate { get; set; }
        [Column("NEXT_START_DATE")]
        [StringLength(10)]
        [Unicode(false)]
        public string NextStartDate { get; set; }
        [Column("NEXT_INT_RATE")]
        [StringLength(11)]
        [Unicode(false)]
        public string NextIntRate { get; set; }
        [Column("OPERATION_PATTERN")]
        public int? OperationPattern { get; set; }
        public int? Processed { get; set; }
    }
}
