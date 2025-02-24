﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Source", Schema = "dbo")]
    public partial class DomesticClearingSource
    {
        public DomesticClearingSource()
        {
            DomesticClearingPaymentMethods = new HashSet<DomesticClearingPaymentMethod>();
        }

        [Key]
        public int SourceId { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [InverseProperty("Source")]
        public virtual ICollection<DomesticClearingPaymentMethod> DomesticClearingPaymentMethods { get; set; }
    }
}
