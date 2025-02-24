﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_UnitCodeAccountLog", Schema = "dbo")]
    public partial class DomesticClearingUnitCodeAccountLog
    {
        [Key]
        public int UnitCodeAccountLogId { get; set; }
        public int UnitCodeAccountId { get; set; }
        [StringLength(1024)]
        public string Type { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }

        [ForeignKey("UnitCodeAccountId")]
        [InverseProperty("DomesticClearingUnitCodeAccountLogs")]
        public virtual DomesticClearingUnitCodeAccount UnitCodeAccount { get; set; }
    }
}
