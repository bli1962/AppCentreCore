using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_BSB")]
    public partial class DomesticClearingBsb
    {
        [Key]
        public int BsbId { get; set; }
        [StringLength(50)]
        public string BsbNo { get; set; }
        [StringLength(50)]
        public string Mnemonic { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(50)]
        public string Suburb { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(50)]
        public string PostCode { get; set; }
        [Column("PT")]
        [StringLength(50)]
        public string Pt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
    }
}
