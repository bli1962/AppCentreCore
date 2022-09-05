using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("BASE_RATE")]
    public partial class BaseRate
    {
        [Key]
        [Column("OPERATION_DATE", TypeName = "datetime")]
        public DateTime OperationDate { get; set; }
        [Key]
        [Column("START_DATE", TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Key]
        [Column("CCY")]
        [StringLength(4)]
        public string Ccy { get; set; }
        [Key]
        [Column("SOURCE")]
        [StringLength(8)]
        public string Source { get; set; }
        [Key]
        [Column("DURATION", TypeName = "decimal(2, 0)")]
        public decimal Duration { get; set; }
        [Column("RATE", TypeName = "decimal(16, 9)")]
        public decimal Rate { get; set; }
        [Required]
        [Column("IMPORTED_BY")]
        [StringLength(8)]
        public string ImportedBy { get; set; }
        [Column("REC_STATUS")]
        [StringLength(1)]
        public string RecStatus { get; set; }
    }
}
