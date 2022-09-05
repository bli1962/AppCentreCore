using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_GasStatus")]
    public partial class DomesticClearingGasStatus
    {
        public DomesticClearingGasStatus()
        {
            DomesticClearingGopostings = new HashSet<DomesticClearingGoposting>();
        }

        [Key]
        public int StatusId { get; set; }
        [Required]
        [StringLength(450)]
        public string Abbreviation { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [InverseProperty(nameof(DomesticClearingGoposting.Status))]
        public virtual ICollection<DomesticClearingGoposting> DomesticClearingGopostings { get; set; }
    }
}
