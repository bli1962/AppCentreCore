using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Type")]
    public partial class DomesticClearingRecType
    {
        public DomesticClearingRecType()
        {
            DomesticClearingRecBatches = new HashSet<DomesticClearingRecBatch>();
        }

        [Key]
        public int RecTypeId { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [InverseProperty(nameof(DomesticClearingRecBatch.RecType))]
        public virtual ICollection<DomesticClearingRecBatch> DomesticClearingRecBatches { get; set; }
    }
}
