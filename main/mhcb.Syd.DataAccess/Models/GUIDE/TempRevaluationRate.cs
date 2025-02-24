﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("temp_REVALUATION_RATE", Schema = "dbo")]
    public partial class TempRevaluationRate
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime DataDate { get; set; }
        [Required]
        [Column("CCY")]
        [StringLength(3)]
        [Unicode(false)]
        public string Ccy { get; set; }
        [Column("DAYS")]
        public int Days { get; set; }
        [Column("RATE", TypeName = "decimal(16, 5)")]
        public decimal Rate { get; set; }
        [Required]
        [Column("IMPORTED_BY")]
        [StringLength(8)]
        [Unicode(false)]
        public string ImportedBy { get; set; }
        [Required]
        [Column("REC_STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string RecStatus { get; set; }
        [Column("GBASE_MSG")]
        [StringLength(78)]
        [Unicode(false)]
        public string GbaseMsg { get; set; }
        [Column("IMPORTED_TIME", TypeName = "datetime")]
        public DateTime ImportedTime { get; set; }
    }
}
