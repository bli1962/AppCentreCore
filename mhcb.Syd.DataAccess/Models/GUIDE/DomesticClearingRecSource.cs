using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Rec_Source")]
    public partial class DomesticClearingRecSource
    {
        public DomesticClearingRecSource()
        {
            DomesticClearingRecCollections = new HashSet<DomesticClearingRecCollection>();
        }

        [Key]
        public int RecSourceId { get; set; }
        [StringLength(10)]
        public string Abbreviation { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [InverseProperty(nameof(DomesticClearingRecCollection.RecSource))]
        public virtual ICollection<DomesticClearingRecCollection> DomesticClearingRecCollections { get; set; }
    }
}
