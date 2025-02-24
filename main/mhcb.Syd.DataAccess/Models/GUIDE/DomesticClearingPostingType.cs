using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_PostingType", Schema = "dbo")]
    public partial class DomesticClearingPostingType
    {
        public DomesticClearingPostingType()
        {
            DomesticClearingGopostings = new HashSet<DomesticClearingGoposting>();
        }

        [Key]
        public int PostingTypeId { get; set; }
        [Required]
        [StringLength(10)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedWhen { get; set; }

        [InverseProperty("PostingType")]
        public virtual ICollection<DomesticClearingGoposting> DomesticClearingGopostings { get; set; }
    }
}
