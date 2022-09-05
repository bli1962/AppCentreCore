using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("RATING2")]
    public partial class Rating2
    {
        public Rating2()
        {
            FacilityMasters = new HashSet<FacilityMaster>();
        }

        [Key]
        [Column("RATING2")]
        public short Rating21 { get; set; }

        [InverseProperty(nameof(FacilityMaster.Rating2Navigation))]
        public virtual ICollection<FacilityMaster> FacilityMasters { get; set; }
    }
}
