using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("TRANCHE_TYPE")]
    public partial class TrancheType
    {
        public TrancheType()
        {
            TrancheMasters = new HashSet<TrancheMaster>();
        }

        [Key]
        [Column("TRANCHE_TYPE")]
        [StringLength(16)]
        public string TrancheType1 { get; set; }
        [Column("TRANCHE_TYPE_DESC")]
        [StringLength(35)]
        public string TrancheTypeDesc { get; set; }

        [InverseProperty(nameof(TrancheMaster.TrancheTypeNavigation))]
        public virtual ICollection<TrancheMaster> TrancheMasters { get; set; }
    }
}
