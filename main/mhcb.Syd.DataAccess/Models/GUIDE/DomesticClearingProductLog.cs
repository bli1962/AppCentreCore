﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_ProductLog", Schema = "dbo")]
    public partial class DomesticClearingProductLog
    {
        [Key]
        public int ProductLogId { get; set; }
        public int ProductId { get; set; }
        [StringLength(1024)]
        public string Type { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }

        [ForeignKey("ProductId")]
        [InverseProperty("DomesticClearingProductLogs")]
        public virtual DomesticClearingProduct Product { get; set; }
    }
}
